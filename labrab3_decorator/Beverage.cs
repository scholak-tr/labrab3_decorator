using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3_decorator
{
   abstract class Beverage
    {  
        public string Name { get; set; }
        public abstract int Cost();
        public abstract string GetDescription();
        public Beverage (string n)
        {
            this.Name = n;
        }

    }
}
