using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class cikličnatablica2
    {
        public static void Izvedi()
        {
            Console.Write("Unesite broj redova: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Unesite broj stupaca: ");
            int m = int.Parse(Console.ReadLine());

            int[,] tablica = new int[n, m];

            int broj = 1;

            for (int ciklus = 0; ciklus < Math.Min((n + 1) / 2, (m + 1) / 2); ciklus++)
            {
                // Popunjavanje gornjeg reda
                for (int i = ciklus; i < m - ciklus; i++)
                {
                    tablica[ciklus, i] = broj++;
                }

                // Popunjavanje desnog stupca
                for (int i = ciklus + 1; i < n - ciklus; i++)
                {
                    tablica[i, m - 1 - ciklus] = broj++;
                }

                // Popunjavanje donjeg reda
                for (int i = m - 2 - ciklus; i >= ciklus && n - 1 - ciklus != ciklus; i--)
                {
                    tablica[n - 1 - ciklus, i] = broj++;
                }

                // Popunjavanje lijevog stupca
                for (int i = n - 2 - ciklus; i > ciklus && m - 1 - ciklus != ciklus; i--)
                {
                    tablica[i, ciklus] = broj++;
                }
            }

            // Ispis ciklične tablice
            Console.WriteLine("Ciklična tablica:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}