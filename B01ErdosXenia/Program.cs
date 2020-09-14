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
        static int[] a = new int[1000];

        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(adat[0]);
                }
            }
            sr.Close();
        }

        static void Minimumertek()
        {
            int min = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
            }
            Console.WriteLine("A minimum: {0}", min);
        }

        static void Egyediek()
        {
            int i = 0;
            int db = 0;
            while (i < a.Length && a[i] % 5 == 0 && a[i] % 4 !=0)
            {
                if (i<a.Length)
                {
                    db++;
                }
            }
            Console.WriteLine("5-el osztható de 4-el nem oszthatóak száma: {0}", db);
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Minimumertek();
            Egyediek();

            Console.ReadKey();
        }


    }
}
