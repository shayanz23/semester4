using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BaseClass
    {

        public virtual void BaseMethod()
        {
            Console.WriteLine("Base method ");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual method ");
        }

    }
}
