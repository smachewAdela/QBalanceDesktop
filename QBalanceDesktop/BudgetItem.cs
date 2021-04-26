namespace QBalanceDesktop
{
    [DbEntity("BudgetItems")]
    public class BudgetItem : BaseDbItem
    {
        [DbField()]
        public string CategoryName { get; set; }

        [DbField()]
        public int BudgetAmount { get; set; }

        [DbField()]
        public int StatusAmount { get; set; }

        [DbField()]
        public int GroupId { get; set; }

        [DbField()]
        public int BudgetId { get; set; }
    }
}