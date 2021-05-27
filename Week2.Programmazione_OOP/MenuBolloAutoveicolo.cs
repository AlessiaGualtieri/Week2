using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class MenuBolloAutoveicolo
    {
        private static Bollo bollo = new Bollo();

        public static void Menu ()
        {
            int scelta;
            bool succ = true;
            do
            {
                Console.WriteLine("----- Menù -----\n" +
                "1 - Inserire veicolo\n" +
                "2 - Rimuovere veicolo\n" +
                "3 - Visualizza bollo dei veicoli inseriti\n" +
                "4 - Esci\n");

                succ = Int32.TryParse(Console.ReadLine(), out scelta);
                while (!succ || scelta < 1 || scelta > 4)
                {
                    Console.WriteLine("Scelta immessa non valida. Riprovare.");
                    succ = Int32.TryParse(Console.ReadLine(), out scelta);
                }

                AnalizzaScelta(scelta);

            } while (scelta != 4);
        }

        public static void AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    AggiungiVeicolo();
                    break;
                case 2:
                    RimuoviVeicolo();
                    break;
                case 3:
                    VisualizzaStampaVeicoli();
                    break;
            }
        }

        public static void AggiungiVeicolo()
        {
            bool succ;
            Autoveicolo auto = new Autoveicolo();
            Console.WriteLine("Inserire i dati del veicolo che si vuole aggiungere:");
            Console.Write("Marca:\t");
            auto.Marca = Console.ReadLine();

            Console.Write("kW:\t");
            auto.Kilowatt = VerificaInputDouble();

            Console.Write("Tipologia Euro:\t");
            auto.TipologiaEuro = VerificaInputIntero();

            Console.Write("Anno immatricolazione:\t");
            auto.AnnoImmatricolazione = VerificaInputIntero();

            Console.Write("Prezzo di acquisto:\t");
            auto.PrezzoDiAcquisto = VerificaInputDouble();

            bollo.AggiungiAutoveicolo(auto);

            Console.WriteLine("\nVeicolo aggiunto con successo.\n");
        }

        public static int VerificaInputIntero()
        {
            int n;
            bool succ = Int32.TryParse(Console.ReadLine(), out n);
            while (!succ || n < 0 )
            {
                Console.WriteLine("Errore. Inserire un numero corretto.");
                succ = Int32.TryParse(Console.ReadLine(), out n);
            }
            return n;
        }

        public static double VerificaInputDouble()
        {
            double n;
            bool succ = Double.TryParse(Console.ReadLine(), out n);
            while (!succ || n < 0 || n > 2021)
            {
                Console.WriteLine("Errore. Inserire un numero corretto.");
                succ = Double.TryParse(Console.ReadLine(), out n);
            }
            return n;
        }

        public static void RimuoviVeicolo()
        {
            if ( bollo.ListaAutoveicoli.Count == 0)
            {
                Console.WriteLine("\nNon è presente alcun veicolo.\n");
                return;
            }

            int i = 1;
            bool succ;
            foreach(Autoveicolo a in bollo.ListaAutoveicoli)
            {
                Console.WriteLine( i + ")\n" + a.ToString());
            }
            Console.WriteLine("\n\nQuale vuoi eliminare tra questi? Indicare posizione:\t");
            succ = Int32.TryParse(Console.ReadLine(), out i);
            while(!succ || i < 0 || i > bollo.ListaAutoveicoli.Count())
            {
                Console.Write("Errore. Inserire una posizione corretta: \t");
                succ = Int32.TryParse(Console.ReadLine(), out i);
            }

            bollo.RimuoviAutoveicolo(i - 1);

            Console.WriteLine("\nVeicolo eliminato con successo.\n");
        }

        public static void VisualizzaStampaVeicoli()
        {
            string fileName = "esempio.txt";
            //Console.WriteLine("\nIn che file vuoi salvare i dati?");
            //fileName = Console.ReadLine();

            if (bollo.ListaAutoveicoli.Count() == 0)
                Console.WriteLine("\nNon è presente alcun veicolo.\n");
            Console.WriteLine(bollo.ToString() + "\n");

            StampaSuFile(fileName);         
        }

        protected static void StampaSuFile(string fileName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            StreamWriter file = null;
            try
            {
                using(file = File.CreateText(path))
                {
                    file.WriteLine(bollo.ToString());
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                file.Close();
            }
        }
    }
}
