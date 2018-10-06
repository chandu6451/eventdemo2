using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(10000);

            Console.Write("Please enter the amount for Withdraw : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            c.Withdraw(amount);
            //Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
