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
    }
}
