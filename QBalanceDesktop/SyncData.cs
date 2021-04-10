using System;
using System.Collections.Generic;
using System.Text;

namespace QBalanceDesktop
{
    public class SyncData : BaseDbItem
    {
        [DbField()]
        public DateTime SyncStart { get; set; }
        [DbField()]
        public DateTime SyncEnd { get; set; }
        [DbField()]
        public string LogInfo { get; set; }
        [DbField()]
        public string Session { get;  set; }
        [DbField()]
        public string Account { get;  set; }
        [DbField()]
        public int NewTransactions { get;  set; }
        [DbField()]
        public bool Success { get;  set; }
    }
}
