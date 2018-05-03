using DesignPatterns.Facade.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Give me a number and I will give you dogs of many legs...");
            var numberFromCustomer = int.Parse(Console.ReadLine());

            FacadeDogClass facadeDog = new FacadeDogClass();

            facadeDog.DoItAll(numberFromCustomer);

            Console.ReadLine();
        }
    }
}
