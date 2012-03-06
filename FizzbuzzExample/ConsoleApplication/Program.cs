using System;
using FizzBuzz;
using FizzBuzz.NumberSource;
using FizzBuzz.Rules;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var write = new FizzBuzzWriter(Console.Out);

            write.Configure(new DefaultNumberRule());
            write.Configure(new DivisibleByRule(3, "Fizz"));
            write.Configure(new DivisibleByRule(5, "Buzz"));
            write.Configure(new FizzBuzzRule());

            var numberSource = new ConsoleBasedNumberSource();

            foreach (var number in numberSource)
            {
                write.WriteLine(number);
                Console.WriteLine();
            }

            Console.WriteLine("Finished...");
            Console.ReadLine();
        }
    }
}
