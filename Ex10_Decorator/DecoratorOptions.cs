using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10_Decorator
{
    class DecoratorOptions : AutoBase
    {
        public AutoBase AutoProperty { protected get; set; }
        public string Title { get; set; }

        public DecoratorOptions(AutoBase au, string title)
        {
            AutoProperty = au;
            Title = title;
        }

        public override double GetCost()
        {
            throw new NotImplementedException();
        }
    }
}
