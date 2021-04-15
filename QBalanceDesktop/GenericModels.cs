using System;
using System.Collections.Generic;
using System.Text;

namespace QBalanceDesktop
{
    class GenericModels
    {
    }

    public class LIstItem
    {
        public object Value { get; set; }
        public string Display { get; set; }
        public object ExtraValue { get; set; }

        public override string ToString()
        {
            return Display;
        }
    }
}
