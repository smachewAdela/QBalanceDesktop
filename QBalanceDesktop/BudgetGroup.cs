using System;
using System.Collections.Generic;
using System.Text;

namespace QBalanceDesktop
{
    [DbEntity("BudgetItemGroup")]
    public class BudgetGroup : BaseDbItem
    {
        [DbField()]
        public string Name { get; set; }
    }
}
