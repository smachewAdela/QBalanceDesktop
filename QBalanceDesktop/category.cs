namespace QBalanceDesktop
{
    [DbEntity("DCategory")]
    public class Category : BaseDbItem
    {
        [DbField()]
        public string Code { get;  set; }
        [DbField()]
        public string Description { get;  set; }
        [DbField()]
        public int GroupId { get;  set; }

        [DbField()]
        public int Amount { get; set; }
    }

    [DbEntity("DCategoryGroup")]
    public class CategoryGroup : BaseDbItem
    {
        [DbField()]
        public string Name { get; set; }
    }
}