using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    public class Autoveicolo
    {
        public String Marca { get; set; }
        public double Kilowatt { get; set; }
        public int TipologiaEuro { get; set; }
        public int AnnoImmatricolazione { get; set; }
        public double PrezzoDiAcquisto { get; set; }


        public override string ToString()
        {
            return $"Marca: {Marca}\n" +
                $"kW: {Kilowatt}\n" +
                $"Tipologia: Euro {TipologiaEuro}\n" +
                $"Anno di immatricolazione: {AnnoImmatricolazione}\n" +
                $"Prezzo di acquisto: {PrezzoDiAcquisto}\n";
        }
    }
}
