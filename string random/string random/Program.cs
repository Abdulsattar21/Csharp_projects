using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_random
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            char c;
            int number=0, category;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                category = rnd.Next(0, 3);
                if (category == 0)
                {
                    number = rnd.Next(0, 26) + 65;
                }
                else if (category == 1)
                {
                    number = rnd.Next(0, 26) + 97;
                }
                else if (category == 2)
                {
                    number = rnd.Next(0, 9) + 48;
                }
                c = Convert.ToChar(number);
                password = password + c;
            }
            Console.WriteLine("password"+password);
            Console.ReadKey();
        }
    }
}
