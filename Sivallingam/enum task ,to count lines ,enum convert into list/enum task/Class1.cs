using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_task
{
        public static List<string> GetDescriptionsAsText(this Enum yourEnum)
        {
            List<string> descriptions = new List<string>();

            foreach (Enum enumValue in Enum.GetValues(yourEnum.GetType()))
            {
                if (yourEnum.HasFlag(enumValue))
                {
                    descriptions.Add(enumValue.GetDescription());
                }
            }

            return descriptions;
        }
    
}
[Flags]
public enum Result
{
    [Description("Value 1 with spaces")]
    Value1 = 1,
    [Description("Value 2 with spaces")]
    Value2 = 2,
    [Description("Value 3 with spaces")]
    Value3 = 4,
    [Description("Value 4 with spaces")]
    Value4 = 8
}

