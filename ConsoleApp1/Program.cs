using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string[] varsta = new int[10];
             //string[] cars = { "Volvo", "BMW", "Ford", "Mazda","Dacia" };

             /*cars[0] = "Mustang";
             cars[1] = "Volvo";
             cars[2] = "BMW";
             cars[3] = "Ford";
             cars[4] = "Mazda";

             for (int i = 0; i < varsta.Length; i++)
             {

                 varsta[i] = Int32.Parse(Console.ReadLine());

             }
         foreach(int s in varsta)
                 Console.WriteLine(s);*/

            string name = "romania";
             for ( int i=0;  i< name.Length; i++)
                {
                Console.WriteLine(name[i]);
}


            Console.ReadKey();
        }
    }
}
