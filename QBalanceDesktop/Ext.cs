using System;
using System.Collections.Generic;
using System.Text;

namespace QBalanceDesktop
{
    public static class Ext
    {
        public static string ToFormatedDate(this DateTime d)
        {
            return $"{d.Year}-{d.Month.ToString().PadLeft(2,'0')}-{d.Day.ToString().PadLeft(2, '0')}";
        }
    }
}
