using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class MenuBraniMusicali
    {
        public static void Menu()
        {
            int scelta;
            BranoMusicale brano = new BranoMusicale();

            do
            {
                Console.WriteLine("----- Menù -----\n" +
                "1 - Inserisci nuovo brano musicale\n" +
                "2 - Visualizza brano musicale inserito\n" +
                "3 - Uscire\n");

                scelta = Convert.ToInt32(Console.ReadLine());

                AnalizzaScelta(scelta, ref brano);

            } while (scelta != 3);
            
        }

        public static void AnalizzaScelta(int scelta, ref BranoMusicale brano)
        {

            switch (scelta)
            {
                case 1:
                    InserisciBrano(ref brano);
                    break;
                case 2:
                    Console.WriteLine("\n" + brano.ToString() + "\n");
                    break;
            }
        }

        public static void InserisciBrano(ref BranoMusicale branoMusicale)
        {
            Console.WriteLine("\nInserire brano musicale: ");
            Console.Write("Inserisci titolo:\t");
            branoMusicale.Titolo = Console.ReadLine();

            Console.Write("Inserisci durata:\t");
            branoMusicale.Durata = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci artista:\t");
            branoMusicale.Artista = Console.ReadLine();

            Console.WriteLine("Inserisci genere musicale:\t");
            int[] values = new int[] { 1, 2, 3, 4, 5 };
            foreach (int enumValue in values)
                Console.WriteLine(enumValue + " - " + Enum.GetName(typeof(GenereMusicale), enumValue));

            //Console.WriteLine("1 - Rock\n2 - Pop\n3 - Metal\n4 - Rap\n5 - Indie");

            branoMusicale.Genere = (GenereMusicale)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
    }
}
