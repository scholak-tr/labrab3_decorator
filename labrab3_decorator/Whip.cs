using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class Whip: CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage.Name + ", со сливками ") { }
        public override Cost()
        {
            return beverage.Cost() + 1; 
        }
    }
}
