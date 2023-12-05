using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    class Program
    {
        static void Main(string[] args)
        {
            int karte, bodovi = 0;
            while (bodovi < 31)
            {
                Console.Write("Upisite vrijednost karte: ");
                try
                {
                    karte = Convert.ToInt32(Console.ReadLine());
                    if (karte > 13 || karte < 1)
                    {
                        Console.WriteLine("Pogrešan unos!");
                        continue;
                    }
                    else
                    {
                        bodovi += karte;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            if (bodovi == 31)
            {
                Console.WriteLine("Bodovi: " + bodovi);
                Console.WriteLine("Pobjedili ste!");
            }
            else
            {
                Console.WriteLine("Bodovi: " + bodovi);
                Console.WriteLine("Izgubili ste!");
            }
            Console.ReadKey();
        }
    }
}