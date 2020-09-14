using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01ErdosXenia
{
    class Program
    {
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(' ');
                int[] a = new int[1000];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(adat[i]);
                }
            }
            sr.Close();
        }

        static void Minimumertek()
        {
            
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Minimumertek();

            Console.ReadKey();
        }


    }
}
