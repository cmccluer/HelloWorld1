using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Console.Write("Enter name: ");
            userName = Console.ReadLine();
            Console.Write("Enter age ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My Name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);
            Console.Read();
        }
    }
}
