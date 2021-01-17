using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_FP
{
    class Program
    {
        //39. Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.

        //functia determina daca numarul este cub perfect si afiseaza rezultatul
        private static void cubPerfect(int n) 
        {
            // 0 ...... 27
            //cube = 0*0*0
            //cube = 1*1*1
            //...
            //cube = 3*3*3
            int cub;

            // parcurgem toate numerele intre 1 si n si determinam daca indicele i ridicat la puterea 3-a este egal cu numarul n
            for (int i = 1; i <= n; i++)
            {
                cub = i * i * i;
               //daca indicele i ridicat la puterea a 3-a este egal cu n se va afisa "este cub perfect" si se va iesi din functie
                if (cub == n)
                { Console.WriteLine(n + " este cub perfect");
                    return;
                }
                //in caz contrar se va afisa mesajul respectiv si se va iesi din functie
                else if (cub > n)
                {
                  Console.WriteLine(n + " nu este cub perfect");
                    return;
                }
            }
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Introdu nr de la tastatura:");
            string input = Console.ReadLine();
            int n;
            Int32.TryParse(input, out n);
            cubPerfect(n);
        }
    }
}
