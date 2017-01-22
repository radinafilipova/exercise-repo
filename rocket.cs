using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n ; row++)

            {
                
                Console.Write("{0}", new string('.',(3*n-2*row-2)/2));
                Console.Write("/");
                Console.Write("{0}", new string(' ', row*2));
                Console.Write("\\");
                Console.Write("{0}", new string('.', (3 * n - 2 * row - 2)/2));
                Console.WriteLine();


            }

            Console.Write("{0}", new string('.', n/2));         
            Console.Write("{0}", new string('*', n * 2));
            Console.Write("{0}", new string('.', n / 2));
            Console.WriteLine();

            for (int row = 0; row < 2*n; row++)

            {

                Console.Write("{0}", new string('.', n/2));
                Console.Write("|");
                Console.Write("{0}", new string('\\', (n-1)*2));
                Console.Write("|");
                Console.Write("{0}", new string('.', n/2));
                Console.WriteLine();


            }

            for (int row = 0; row < n/2; row++)

            {

                Console.Write("{0}", new string('.', n / 2-row));
                Console.Write("/");
                Console.Write("{0}", new string('*', (n - 1) * 2 +2*row));
                Console.Write("\\");
                Console.Write("{0}", new string('.', n / 2-row));
                Console.WriteLine();


            }

        }

    }
}
