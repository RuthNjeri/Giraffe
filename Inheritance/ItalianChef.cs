using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ItalianChef : Chef // Italian chef can inherit from the Chef class, Chef class is the super class, Italian Chef is the sub class
    {
        public void MakePasta()
        {
            Console.WriteLine("Italian Chef can make Pasta");
        }

        // Overriding, changing an inherited method
        public override void MakeSalad()
        {
            Console.WriteLine("Italian chef makes pasta salad");
        }
    }
}
