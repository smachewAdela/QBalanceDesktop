using System;
using System.Collections.Generic;
using System.Linq;

namespace QBalanceDesktop
{
    public class DbAccess : DbAccessProvider
    {
        public DbAccess(string connStr) : base(connStr)
        {

        }

        public void Add(BaseDbItem item)
        {
            Insert(item);
        }

        public void Delete(BaseDbItem item)
        {
            base.Delete(item);
        }

        public T GetSingle<T>(SearchParameters parameters) where T : BaseDbItem
        {
            return GetData<T>(parameters).FirstOrDefault();
        }

        public List<T> GetData<T>(SearchParameters parameters) where T : BaseDbItem
        {
            List<DbParam> innerParams = new List<DbParam>();
            var i = (T)Activator.CreateInstance(typeof(T));
            var query = $"select * from {i.GetTableName()}";
            List<string> paramsText = ExtractParameters(parameters, innerParams);
            if (paramsText.Count > 0)
            {
                query += $" where { string.Join(" and ", paramsText)}";
            }

            return Get<T>(query, innerParams.ToArray());
        }

        private List<string> ExtractParameters(SearchParameters parameters, List<DbParam> innerParams)
        {
            List<string> param = new List<string>();

            //if (parameters.BudgetTransactionStartDate.HasValue)
            //{
            //    param.Add("Date>=@StartDate");
            //    innerParams.Add(new DbParam("@StartDate", parameters.BudgetTransactionStartDate.Value));
            //}
            if (!string.IsNullOrEmpty(parameters.TransID))
            {
                param.Add("TransID=@TransID");
                innerParams.Add(new DbParam("@TransID", parameters.TransID));
            }

            return param;
        }
    }

}