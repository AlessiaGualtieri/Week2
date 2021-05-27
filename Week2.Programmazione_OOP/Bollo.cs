using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    public class Bollo
    {
        public List<Autoveicolo> ListaAutoveicoli { get; set; } = new List<Autoveicolo>();
        List<double> CostoBollo { get { return CalcolaCostoBollo(); } } 

        //Metodi
        public void AggiungiAutoveicolo (Autoveicolo a)
        {
            ListaAutoveicoli.Add(a);
        }

        public void RimuoviAutoveicolo (Autoveicolo a)
        {
            bool rimozione = ListaAutoveicoli.Remove(a);
            if (!rimozione)
                throw   new ArgumentException("Errore. L'autoveicolo che si vuole rimuovere non esiste");
        }

        public void RimuoviAutoveicolo(int i)
        {
            try
            {
                ListaAutoveicoli.RemoveAt(i);
            } catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Errore. L'autoveicolo che si vuole rimuovere non esiste");
            }

        }

        public List<double> CalcolaCostoBollo()
        {
            List<double> costo = new List<double>(); 

            foreach (Autoveicolo auto in ListaAutoveicoli )
            {
                switch (auto.TipologiaEuro)
                {
                    case 1:
                        if (auto.Kilowatt <= 100)
                            costo.Add(2.90);
                        else
                            costo.Add(4.35);
                        break;
                    case 2:
                        if (auto.Kilowatt <= 100)
                            costo.Add(2.80);
                        else
                            costo.Add(4.20);
                        break;
                    case 3:
                        if (auto.Kilowatt <= 100)
                            costo.Add(2.70);
                        else
                            costo.Add(4.05);
                        break;
                    default:
                        if (auto.Kilowatt <= 100)
                            costo.Add(2.58);
                        else
                            costo.Add(3.87);
                        break;
                }
            }
            return costo;
        }

        public override string ToString()
        {
            string stampa = "";
            for (int i = 0; i < ListaAutoveicoli.Count; i++)
                stampa += ListaAutoveicoli[i] + $"Costo del bollo: {CostoBollo[i]}\n\n";
            return stampa;
        }
    }
}
