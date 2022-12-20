using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class Milk: CondimentDecorator
    {
        public Milk(Beverage b) : base(b.Name + ", с молоком", b) { }
         
        public override int Cost()
        {
            return beverage.Cost() + 2;
        }
    }
}
