using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class Mocha:CondimentDecorator

    {
        public Mocha(Beverage beverage) : base(beverage.Name + ", с мокко") { }
        public override int Cost()
        {
            return beverage.Cost() + 3;
        }

    }
}
