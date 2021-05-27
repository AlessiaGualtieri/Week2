using System;
using System.Collections;
using System.Diagnostics;

namespace Week2.Programmazione_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ITERAZIONE vs RICORSIONE

            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //Console.WriteLine("Iterativo:\t" + Esercizi.FibonacciIterativo(30));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);

            //watch.Reset();
            ////Stopwatch.StartNew();
            //watch.Start();
            //Console.WriteLine("\n\nRicorsivo:\t" + Esercizi.FibonacciRicorsivo(30));
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);

            #endregion

            #region CLASSE PERSONA
            //Persona persona = new Persona();
            //persona.Nome = "Meow";
            //persona.Cognome = "BulaBula";
            //persona.Eta = 26;
            //Console.WriteLine("Il mio nome è: " + persona.Nome);
            //Console.WriteLine("La mia età è: " + persona.Eta);
            //Console.WriteLine("Il cognome è: " + persona.Cognome);
            //Console.WriteLine("Lo stipendio è: " + persona.Stipendio);
            //persona.CalcolaStipendio();
            //Console.WriteLine("Lo stipendio è: " + persona.Stipendio);
            //Console.WriteLine("Data di nascita: " + persona.DataNascita);

            //Persona persona2 = new Persona()
            //{
            //    Cognome = "Rossi",
            //    Nome = "Mario",
            //    Eta = 40,
            //    DataNascita = new DateTime(1980, 12, 7)
            //};

            //Persona persona3 = new Persona("Naco", "Catto", 21);
            //Console.WriteLine(persona3.Nome + " guadagna " + persona3.Stipendio);
            //Console.WriteLine(persona3.ToString());

            #endregion

            #region ESERCIZIO BRANO MUSICALE

            //BranoMusicale branoMusicale = new BranoMusicale();
            //Console.WriteLine("Inserire brano musicale: ");
            //Console.Write("Inserisci titolo:\t");
            //branoMusicale.Titolo = Console.ReadLine();

            //Console.Write("Inserisci durata:\t");
            //branoMusicale.Durata = Convert.ToDouble( Console.ReadLine() );

            //Console.Write("Inserisci artista:\t");
            //branoMusicale.Artista = Console.ReadLine();

            //Console.WriteLine("Inserisci genere musicale:\t");
            //Console.WriteLine("1 - Rock\n2 - Pop\n3 - Metal\n4 - Rap\n5 - Indie");
            //branoMusicale.Genere = (GenereMusicale) Convert.ToInt32(Console.ReadLine());

            ////bool succ = Enum.TryParse(GenereMusicale, Console.ReadLine(), out (GenereMusicale) BranoMusicale.Genere) ;

            //Console.WriteLine("\n" + branoMusicale.ToString());

            //BranoMusicale branoMusicale1 = new BranoMusicale()
            //{
            //    Artista = "Mao",
            //    Durata = 7.5,
            //    Genere = (GenereMusicale) 3,
            //    Titolo = "maomaomao"
            //};

            //Console.WriteLine("\n" + branoMusicale1.ToString());


            #endregion

            #region ESERCIZIO non so cosa
            //MenuBraniMusicali.Menu();



            //Utente u = new Utente();
            //Bolletta b = new Bolletta();
            //Console.WriteLine( u.ToString() + "\n\n" );
            //Console.WriteLine(b.ToString() + "\n\n\n\n");


            //Utente u1 = new Utente
            //{
            //    Nome = "Mao",
            //    Cognome = "Bilbo",
            //    DataNascita = new DateTime(1993, 01, 14),
            //    CodiceUtente = "ASDFCKJ10301"
            //};
            //Bolletta b1 = new Bolletta()
            //{
            //    //Consumo = new double[] { 142.4, 104.2, 5551.3 },
            //    Consumo = 2234.2,
            //    DataScadenza = new DateTime(2021, 08, 14),
            //    User = (Utente)u1
            //};
            //Console.WriteLine(u1.ToString() + "\n\n");
            //Console.WriteLine(b1.ToString() + "\n");

            //MenuBolletta.Menu();
            #endregion

            #region ECCEZIONI
            //bool esito;
            //Console.WriteLine("Inserisci un Int16");
            //esito = Esercizi.EsempioException(Console.ReadLine());
            //while (!esito)
            //{
            //    Console.WriteLine("Ritenta.");
            //    esito = Esercizi.EsempioException(Console.ReadLine());
            //}


            //Esercizi.EccezioneLanciata();
            #endregion

            #region GESTIONE RISORSE
            //string directoryName;
            ////Console.Write("Inserisci il nome della cartella che vuoi creare/eliminare/spostare:\t");
            ////directoryName = Console.ReadLine();
            ////GestioneIO.CreaDirectory(directoryName);

            ////GestioneIO.EliminaDirectory(directoryName);

            ////GestioneIO.SpostaDirectory(directoryName);
            ////GestioneIO.StampaContenutoDirectory();
            //string folderName = "testo.txt";
            ////Persona p = new Persona()
            ////{
            ////    Nome = "Mario",
            ////    Cognome = "Rossi",
            ////    Eta = 34
            ////};
            ////GestioneIO.ScritturaFile(folderName, p.ToString());
            ////GestioneIO.LeggiDaFile(folderName);

            //ArrayList persone = GestioneIO.CaricaPersoneDaFile(folderName);
            ////foreach (Persona item in persone)
            ////{
            ////    GestioneIO.ScritturaFile("testo1.txt", item.ToString());
            ////    Console.WriteLine(item.ToString());
            ////}
            //GestioneIO.StampaPersoneSuFile(persone);

            #endregion

            #region ESERCIZIO BOLLO AUTOVEICOLO

            MenuBolloAutoveicolo.Menu();

            #endregion

        }
    }
}
