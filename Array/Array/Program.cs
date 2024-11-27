using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of integers with 100 elements
            int[] numbers = new int[100];
            double sum = 0, avg;
            //convert: static class so you can use it directly
            //Random: dynamic clas
            //Random number generation
            Random rnd = new Random();


            for(int i = 0; i < 100; i++)
            {
                numbers[i] = rnd.Next(1, 101);//random number between 1-100
                sum = sum + numbers[i];
                Console.WriteLine("numbers of the random : {0}", numbers[i]); 
            }
            avg = sum / 100;
            Console.WriteLine("average:{0}", avg);
            Console.ReadKey();
        }
    }
}
