using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken");
        }

        public virtual void MakeSalad()// Virtual means that subclasses can change the functionality of the method
        {
            Console.WriteLine("The chef makes salads");
        }

        
    }
}
