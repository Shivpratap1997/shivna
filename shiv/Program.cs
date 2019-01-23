using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("SUM IS {0}", sum);
            Console.ReadLine();
        }
    }
}
