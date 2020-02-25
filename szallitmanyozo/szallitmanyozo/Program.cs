using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szállitmanyozo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = { "ABC-123", "ASD-234", "FGH-432", "BAB-987", "SEX-444" };
            List<string> bent = new List<string>();
            string választás;
            // Kiíró eljárás, Melyikek vannak bent jelenleg, Hívd meg az Elmegynél és a Bejönnél

            do
            {
                // A választási lehetőségek kiírása
                Console.WriteLine("Elmegy ('E')");
                Console.WriteLine("Bejön ('B')");
                Console.WriteLine("Kilépés ('K')");
                // Be kell kérni 1 választást
                Console.Write("Válasszon műveletet: ");
                választás = Console.ReadLine();
                switch (választás)
                {
                    case "E":
                        Elmegy(választás, bent);
                        break;
                    case "B":
                        Bejön(választás, bent);
                        break;
                    case "K":
                        Kilépés(ref választás);
                        break;
                    default:
                        Console.WriteLine("Nem megfelelő a választás");
                        break;
                }
            } while (választás != "K"); // K = Kilépés 

            Console.ReadKey();
        }
        static void Elmegy(string választás, List<string> bent)
        {
            if (bent.Count == 0)
            {
                Kiíró(bent);
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("Rendszám: ");
                string rendszám = Console.ReadLine();
                for (int i = 0; i < bent.Count; i++)
                {
                    if (rendszám == bent[i])
                    {
                        bent.Remove(rendszám);
                        Console.WriteLine("Az autó elment");
                        Kiíró(bent);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (i == bent.Count - 1)
                    {
                        Console.WriteLine("Nincs bent ilyen autó");
                        Kiíró(bent);
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
            }
        }
        static void Bejön(string választás, List<string> bent)
        {
            Console.Write("Rendszám: ");
            string rendszám = Console.ReadLine();
            if (bent.Count == 0)
            {
                bent.Add(rendszám);
                Console.WriteLine("Autó hozzáadva");
                Kiíró(bent);
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                for (int i = 0; i < bent.Count; i++)
                {
                    if (bent[i] == rendszám)
                    {
                        Console.WriteLine("Már van bent ilyen Autó");
                        Kiíró(bent);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        bent.Add(rendszám);
                        Console.WriteLine("Autó hozzáadva");
                        Kiíró(bent);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }

        }
        static string Kilépés(ref string választás)
        {
            Console.WriteLine("Biztostan kilép? (igen/nem)");
            string válasz = Console.ReadLine();
            if (válasz == "igen")
            {
                választás = "K";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                választás = Console.ReadLine();
            }
            return választás;
        }
        static void Kiíró(List<string> bent)
        {
            if (bent.Count == 0)
            {
                Console.WriteLine("Nincs bent autó");
            }
            else
            {
                Console.Write("Bent lévő autók: ");
                foreach (string item in bent)
                {
                    Console.Write($"{item}  ");
                }
                Console.WriteLine();
            }

        }
    }
}