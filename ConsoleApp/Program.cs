using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmis ededin reqemlerinin hasilini tapin.

            //Console.WriteLine("ededi daxil et");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int q;
            //int total = 1;
            //while (n > 0) {
            //    q = n % 10;
            //    n /= 10;
            //    total *= q;
            //};
            //Console.WriteLine(total);



            //Verilmis ededin sade ve ya murekkeb oldugunu tapan alqoritm.

            //Console.WriteLine("ededi daxil et");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i;
            //int count = 0;
            //for (i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //    }
            //}
            //if (count >= 2)
            //{
            //    Console.WriteLine("eded murekkebdir");
            //}
            //else
            //{
            //    Console.WriteLine("eded sadedir");
            //}



            //Verilmis ededin faktorialini tapin.

            //Console.WriteLine("ededi daxil et");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int total = 1;
            //while (n > 0)
            //{
            //    total *= n;
            //    n -= 1;
            //}
            //Console.WriteLine(total);



            //Verilmiş ədədin polindrom olub olmadığını tapan alqoritm
            //    (Meselen: 1221->polindrom, 1231->polindrom deyil)(optional)

            Console.WriteLine("ededi daxil et");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n % 10;
            int b = (n / 10) % 10;
            int c = (n / 100) % 10;
            int d = n / 1000;
            if (d == a && c == b)
            {
                Console.WriteLine("eded polindromdur");
            }
            else
            {
                Console.WriteLine("eded polindrom deyil");
            }


        }
    }
}
