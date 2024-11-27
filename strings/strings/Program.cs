using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("inter a word : ");
            s = Console.ReadLine();
            int counterAZ = 0, counteraz = 0, counter09 = 0;
            int len = s.Length;
            int i = 0;
            while (i<len)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                    counterAZ++;
                else if (s[i] >= 'a' && s[i] <= 'z')
                    counteraz++;
                else if (s[i] >= '0' && s[i] <= '9')
                    counter09++;
                i++;
            }
            Console.WriteLine("number of char between A-Z:{0}", counterAZ);
            Console.WriteLine("number of char between a-z:{0}", counteraz);
            Console.WriteLine("number of char between 0-9:{0}", counter09);
            Console.ReadKey();
        }
    }
}
