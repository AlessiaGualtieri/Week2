using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class MenuBolletta
    {
        private static Utente utente = new Utente();
        private static Bolletta bolletta = new Bolletta();

        public static void Menu()
        {
            bool continua = true ;
            int selezione;

            do
            {
                Console.WriteLine("1 - Inserisci dati utente\n" +
                    "2 - Inserisci dati bolletta\n" +
                    "3 - Visualizza bolletta\n" +
                    "4 - Esci");
                selezione = Convert.ToInt32( Console.ReadLine() );
                AnalizzaScelta(selezione, ref continua);
            } while (continua);
        }

        public static void AnalizzaScelta(int selezione, ref bool continua)
        {
            switch(selezione)
            {
                case 1:
                    InserisciDatiUtente();
                    break;
                case 2:
                    InserisciDatiBolletta();
                    break;
                case 3:
                    StampaBolletta();
                    break;
                case 4:
                    continua = false;
                    break;
            }
        }

        public static void InserisciDatiUtente()
        {
            Console.Write("Inserisci codice utente: \t");
            utente.CodiceUtente = Console.ReadLine();
            Console.Write("Inserisci nome: \t");
            utente.Nome = Console.ReadLine();
            Console.Write("Inserisci cognome: \t");
            utente.Cognome = Console.ReadLine();
            Console.Write("Inserisci data di nascita: \t");
            bool esito = DateTime.TryParse(Console.ReadLine(), out DateTime data );
            while(!esito)
            {
                Console.WriteLine("Inserisci una data coerente");
                esito = DateTime.TryParse(Console.ReadLine(), out data);
            }
            utente.DataNascita = data;
        }

        public static void InserisciDatiBolletta()
        {

            bool esito;
            double consumo;
            TipoBolletta tipo;

            Console.Write("\nInserisci tipologia bolletta: \n");
            int[] values = new int[] { 0, 1, 2 };
            foreach (int item in values)
                Console.WriteLine(item + " - " + Enum.GetName(typeof(TipoBolletta), item));
            
            esito = Enum.TryParse(Console.ReadLine(), out tipo);
            while(!esito)
            {
                Console.WriteLine("Inserisci una tipologia coerente");
                esito = Enum.TryParse(Console.ReadLine(), out tipo);
            } 
            bolletta.TipologiaBolletta = tipo;

            Console.Write("Inserisci consumo in {0}: \t", bolletta.UnitaMisura);
            //bolletta.Consumo = Convert.ToDouble(Console.ReadLine());

            do
            {
                esito = InserimentoConsumo(out consumo);
            } while (!esito);
            bolletta.Consumo = consumo;

            Console.Write("Inserisci data di scadenza: \t");
            esito = DateTime.TryParse(Console.ReadLine(), out DateTime data);
            while (!esito)
            {
                Console.WriteLine("Inserisci una data coerente");
                esito = DateTime.TryParse(Console.ReadLine(), out data);
            }
            bolletta.DataScadenza = data;

            bolletta.User = utente;
        }

        public static bool InserimentoConsumo(out double consumo)
        {
            bool esito = true;

            try
            {
                consumo = Convert.ToDouble(Console.ReadLine());
                esito = true;
            } catch(FormatException)
            {
                Console.WriteLine("Formato inserito non corretto");
                consumo = 0.0;
                esito = false;
            }
            return esito;
        }

        public static void StampaBolletta()
        {
            Console.WriteLine("\nI dati della tua bolletta sono:\n" + bolletta.ToString() + "\n");
        }



    }
}
