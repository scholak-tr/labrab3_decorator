using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    abstract class CondimentDecorator: Beverage
    {
        protected Beverage beverage;
        public CondimentDecorator (string n, Beverage beverage) : base (n)
        {
            this.beverage = beverage;
        }

    }
}
