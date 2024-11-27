using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1
{
    class Program
    {
        static void Main(string[] args)
        {
            int midterm;
            int final;
            double av;
            Console.Clear();
            Console.WriteLine("midterm");
            midterm = Convert.ToInt16(Console.ReadLine());
            if (!(midterm >= 0 && midterm <= 100))
            {
                Console.WriteLine("midterm must be 0-100");
            }
            return;
            Console.WriteLine("final");
            final = Convert.ToInt16(Console.ReadLine());
            av = midterm * 0.2 + final * 0.6;
            Console.Write("ava:{0}", av);
            Console.ReadKey();
        }
    }
}
