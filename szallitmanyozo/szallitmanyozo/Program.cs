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
            string[] teljes = { "ABC-123", "Asd-234", "FGH-432", "BAB-987", "SEX-444" };
            List<string> bent = new List<string>();
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
                    case "B":Bejön();
                        break;
                    case "K":Kilépés();
                        break;
                    default: Console.WriteLine("Nem megfelelő választás");
                        break;
                }

            } while (választás!="K");
            Console.ReadKey();
        }
    }
}
