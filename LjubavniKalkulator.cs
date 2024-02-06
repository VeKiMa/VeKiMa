using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UčenjeCS.E12KlasaObjekt;

namespace UčenjeCS
{
    internal class LjubavniKalkulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozdravna poruka Ljubavni kalkulator");
            Console.WriteLine("Unesi prvo ime: ");
            string PrvoIme = Console.ReadLine();

            Console.WriteLine("Unesite drugo ime: ");
            string DrugoIme = Console.ReadLine();

            
            string spojenaImena = (PrvoIme + DrugoIme).ToLower().Replace(" ", "");

            
            int ljubavniRezultat = 0;
            foreach (char c in "ljubav")
            {
                int count = 0;
                foreach (char n in spojenaImena)
                {
                    if (n == c)
                    {
                        count++;
                    }
                }
                ljubavniRezultat += count;
            }

            Console.WriteLine($"Ljubavni rezultat {PrvoIme} + {DrugoIme} = {ljubavniRezultat}%.");

            
            if (ljubavniRezultat >= 80)
            {
                Console.WriteLine("Juhu! Vas dvoje bi trebali biti zajedno");
            }
            else if (ljubavniRezultat >= 50)
            {
                Console.WriteLine("Čini se da ima potencijala! Nastavi njegovati vezu!");
            }
            else
            {
                Console.WriteLine("Hmm... Možda ima mjesta za napredak. Ne odustaj!");
            }
        }
    }
}

