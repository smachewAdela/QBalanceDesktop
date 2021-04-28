using System;
using System.Collections.Generic;
using System.Text;

namespace QBalanceDesktop
{
    [DbEntity("BudgetForMonth")]
    public class Budget : BaseDbItem
    {
        [DbField()]
        public DateTime Month { get; set; }

        public string Title
        {
            get { return $"{Month.ToString("MMMM")}-{Month.Year.ToString()}"; }
        }

        public List<BudgetItem> Items { get; set; }

        public override void LoadExtraData()
        {
            Items = GlobalsProviderBL.Db.GetData<BudgetItem>(new SearchParameters { BudgetItemBudgetId = this.Id });
        }
    }
}
