using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            var c = new Child();

            Console.WriteLine(p.GetType().FullName);
            Console.WriteLine(c.GetType().FullName);

            Console.ReadLine();
        }
    }

    class Parent
    {

    }

    class Child : Parent
    {

    }
}
