using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QBalanceDesktop
{
    public class BackUpManager
    {
        internal static void Perform()
        {
            var lastSync = GlobalsProviderBL.Db.GetData<DbBackUpLog>().Where(x => x.Success).OrderByDescending(x => x.LastBackUp).FirstOrDefault();
            if (lastSync == null)
            {
                lastSync = new DbBackUpLog();
                lastSync.LastBackUp = DateTime.Now.AddYears(-1);
                GlobalsProviderBL.Db.Insert(lastSync);
            }
            try
            {
                lastSync.Start = DateTime.Now;

                if ((DateTime.Now - lastSync.LastBackUp).TotalHours > 1)
                {
                    var sourceDbName = GetSourceDbName();
                    var newDb = sourceDbName + "_backUp";

                    var srvSource = new Server(".");
                    var dbSource = srvSource.Databases[sourceDbName];

                    var srvDestination = new Server(".");
                    var dbDestination = srvDestination.Databases[newDb];

                    var transfer = new Transfer(dbSource)
                    {
                        DestinationServer = srvDestination.Name,
                        DestinationDatabase = dbDestination.Name,
                        CopyAllObjects = true,
                        DestinationLoginSecure = true,
                        DropDestinationObjectsFirst = true,
                        CopyData = true
                    };

                    transfer.Options.ContinueScriptingOnError = false;
                    transfer.Options.WithDependencies = false;

                    transfer.TransferData();

                    lastSync.LastBackUp = DateTime.Now;

                    var span = DateTime.Now - lastSync.Start;

                    lastSync.LogInfo = $"back up process lasted - {span.TotalMinutes}:{span.TotalSeconds}";
                    lastSync.Success = true;
                    GlobalsProviderBL.Db.Update(lastSync);
                }
            }
            catch (Exception ex)
            {
                lastSync.LogInfo = ex.Message;
                lastSync.Success = false;
                GlobalsProviderBL.Db.Update(lastSync);
            }
        }

        private static string GetSourceDbName()
        {
#if DEBUG
            return ConfigurationManager.AppSettings["bkpSourceDbName"];
#else
            return ConfigurationManager.AppSettings["bkpSourceDbName_prod"];
#endif 

        }
    }

    [DbEntity("DbBackUpLog")]
    public class DbBackUpLog : BaseDbItem
    {
        [DbField()]
        public DateTime LastBackUp { get; set; }

        [DbField()]
        public string LogInfo { get; set; }

        [DbField()]
        public bool Success { get; set; }
        public DateTime Start { get; internal set; }
    }
}
