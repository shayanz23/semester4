using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4.BaseClass;

namespace Lab4
{
    internal class Overloading : BaseClass
    {

        public override void BaseMethod()
        {
            Console.WriteLine("Base method overriden");
        }

        public void BaseMethod(int number)
        {
            Console.WriteLine("Base method overloaded " + number);
        }

        public void Method()
        {
            Console.WriteLine("Method ");
        }

        public void Method(int number)
        {
            Console.WriteLine("Method " + number);
        }
    }
}
