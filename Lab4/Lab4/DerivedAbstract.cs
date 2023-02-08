using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4.AbstractClass;

namespace Lab4
{
    internal class DerivedAbstract : AbstractClass
    {
        public override void abstractMethod()
        {
            Console.WriteLine("Abstract method implemented.");
        }
    }
}
