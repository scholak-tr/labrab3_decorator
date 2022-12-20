using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class Soya: CondimentDecorator
    { 
        public Soya (Beverage beverage): base (beverage.Name + ", с соей") { }
        public override Cost()
        {
            return beverage.Cost() + 2;
        }
    } 
}
