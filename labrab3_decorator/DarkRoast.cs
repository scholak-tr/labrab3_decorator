using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
    class DarkRoast: Beverage
    {
        public DarkRoast( ): base(" Кофе темной обжарки") { }
         
        public override Cost()
        {
            return 22;
        }
    }
}
