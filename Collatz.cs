using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojCSharp
{
    class Collatz
    {
        int Collatzo(int a)
        {
            int n;
            if (a == 1)
            {
                return 0;
            }
            if (a == 2)
            {
                return 1;
            }
            for (n = 0; a != 1; n++)
            {
                if (n == 1)
                {
                    continue;
                }
                if ((a % 2) == 0)
                {
                    a = a / 2;
                }
                else
                {
                    a = (3 * a) + 1;
                    continue;
                }
            }
            return n - 1;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Collatz c = new Collatz();
            int[] tab_collatz = new int[n];
            int i;
            for(i=0;i<n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                tab_collatz[i] = c.Collatzo(a);
            }

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(tab_collatz[j]);
            }
            Console.ReadKey();
        }
    }
}
