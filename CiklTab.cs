using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UčenjeCS
{
    class CiklTab
    {
        public static void Izvedi()
        {

            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("    Ciklična tablica    ");
            Console.WriteLine();
            Console.WriteLine("************************");
            
            Console.WriteLine();
            
            Console.Write("Ispiši tablicu 5 x 5 :");
            
            Console.WriteLine();    

           


            int[,] tablica = NapraviCiklTab(5, 5);

            // Ispis tablice
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] NapraviCiklTab(int redovi, int stupci)
        {
            int[,] tablica = new int[redovi, stupci];
            int broj = 1;
            int gornjiRed = 0, donjiRed = redovi - 1;
            int lijeviStup = 0, desniStup = stupci - 1;

            while (gornjiRed <= donjiRed && lijeviStup <= desniStup)
            {
                // Popunjava gornji red
                for (int i = lijeviStup; i <= desniStup; i++)
                {
                    tablica[gornjiRed, i] = broj++;
                }
                gornjiRed++;

                // Popunjava desni stupac
                for (int i = gornjiRed; i <= donjiRed; i++)
                {
                    tablica[i, desniStup] = broj++;
                }
                desniStup--;

                // Popunjava donji red unazad
                if (gornjiRed <= donjiRed)
                {
                    for (int i = desniStup; i >= lijeviStup; i--)
                    {
                        tablica[donjiRed, i] = broj++;
                    }
                    donjiRed--;
                }

                // Popunjava lijevi stupac unazad
                if (lijeviStup <= desniStup)
                {
                    for (int i = donjiRed; i >= gornjiRed; i--)
                    {
                        tablica[i, lijeviStup] = broj++;
                    }
                    lijeviStup++;
                }
            }

            return tablica;
        }
    }
    

}

