using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class Decaf: Beverage
    {
        public Decaf() : base("Кофе без кофеина");

        public override Cost()
        {
            return 20;
        }
    }
}
