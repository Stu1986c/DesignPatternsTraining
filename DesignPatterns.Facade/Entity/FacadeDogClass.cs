using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Entity
{
    public class FacadeDogClass
    {
        public Tuple<int, int> DoItAll(int numberFromCustomer)
        {
            int calculatedResult;

            if (numberFromCustomer > 10)
            {
                calculatedResult = numberFromCustomer - 8;
            }
            else
            {
                calculatedResult = numberFromCustomer + 4;
            }

            Console.WriteLine($"Your new number is: {calculatedResult}");

            Console.WriteLine($"Let's create you {calculatedResult} dogs");
            int numberOfDogs = 0;
            int totalNumberOfLegs = 0;
            for (int i = 0; i < calculatedResult; i++)
            {
                var name = $"Dog{i}";
                var numberOfLegs = i % 4;
                Console.WriteLine($"You now have a dog called {name}");
                Console.WriteLine($"{name} has {numberOfLegs} leg/s");
                numberOfDogs++;
                totalNumberOfLegs = totalNumberOfLegs + numberOfLegs;
            }

            return new Tuple<int, int>(numberOfDogs,totalNumberOfLegs);
        }
    }
}
