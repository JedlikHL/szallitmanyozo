using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallitmanyozo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = { "ABC-123", "ASD-234", "FGH-432", "BAB-987", "SEX-444" };
            List<string> bent = new List<string>();
            string választás;
            do
            {
                //A választási lehetőségek kiírása
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                //A választás bekéréseú
                választás = Console.ReadLine();
                switch (választás)
                {
                    case "E":Elmegy();
                        break;
                    case "B":Bejön(teljes,bent);
                        break;
                    case "K":Kilépés();
                       break;
                    default: Console.WriteLine("Nem megfelelő választás");
                        break;
                }

            } while (választás!="K");
            Console.ReadKey();
        }

        private static void Kilépés()
        {
            
        }

        private static void Elmegy()
        {
            //Ha üres a lista, akkor írjuk ki, hzogy nincs bent autó
            //Ellenőrzés, hogy az autó a listában van-e
            //Ha igen, akkor ki kell törölni
        }

        static void Bejön(string[] teljes, List<string> bent)
        {
            if (bent.Count)
            {

            }
            Console.WriteLine("Adja meg a rendszámot:");
            string rendszám = Console.ReadLine();
            if (teljes.Contains(rendszám))
            {
                bent.Add(rendszám);
                Console.WriteLine("Engedélyezve");
            }
            else { Console.WriteLine("Ez az autó nem jöhet be, mert nem szerepel a nyilvántartásban!"); }
        }
    }
}
