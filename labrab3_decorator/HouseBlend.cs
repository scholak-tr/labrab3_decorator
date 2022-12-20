using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class HouseBlend:Beverage
    {
        public HouseBlend() : base("Кофе средней обжарки") { }
        public override int GetCost()
        {
            return 25;
        }

    }
}
