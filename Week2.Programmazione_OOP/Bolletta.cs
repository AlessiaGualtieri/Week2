using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    // -->
   enum TipoBolletta
    {
        corrente,
        gas,
        telefono
    }

    enum UnitaMisura
    {
        kwh,
        mc,
        min
    }       // <--
    class Bolletta
    {
        private static double ImportoBase = 40;
        private static double MoltiplicativoBase = 10;

        // -->
        public TipoBolletta TipologiaBolletta { get; set; }
        public UnitaMisura UnitaMisura { get {return GetUnitaMisura(); } }
        public double Consumo { get; set; } 
        public double Importo { get { return GetImporto(); } }  // <--

        //public static string[] TipologiaBolletta = { "corrente", "gas", "telefono" };
        //public static string[] UnitaMisura = { "kwh", "mc", "min" };
        //public double[] Consumo { get; set; } = { 0, 0, 0 };
        //public double[] Importo { get {return GetImporto(); } } 

        public DateTime DataScadenza { get; set; } = new DateTime(2000, 01, 01);
        public Utente User { get; set; } = new Utente();


        // Metodi

        //private double[] GetImporto()
        //{
        //    double[] imp = { 0, 0, 0 };

        //    imp[0] = ImportoBase + MoltiplicativoBase * Consumo[0];
        //    imp[1] = ImportoBase + MoltiplicativoBase * Consumo[1];
        //    imp[2] = ImportoBase + MoltiplicativoBase * Consumo[2];

        //    return imp;
        //}


        //public string ToString()
        //{
        //    return $"----- Utente ----- \n{User.ToString()}\n" +
        //        $"----- Bolletta -----\n" +
        //        $"Tipologia: \t{TipologiaBolletta[0]}({UnitaMisura[0]}) \t " +
        //        $"{TipologiaBolletta[1]}({UnitaMisura[1]})\t{TipologiaBolletta[2]}({UnitaMisura[2]})\n" +
        //        $"Consumo: \t{Consumo[0]} \t\t {Consumo[1]} \t\t{Consumo[2]} \n" +
        //        $"Importo (eur):\t{Importo[0]} \t\t {Importo[1]} \t\t{Importo[2]} \n" +
        //        $"Data di scadenza: {DataScadenza.ToShortDateString()}"; 
        //}

        private double GetImporto()
        {
            return ImportoBase + MoltiplicativoBase * Consumo;
        }

        private UnitaMisura GetUnitaMisura()
        {
            if (TipologiaBolletta == TipoBolletta.corrente)
                return UnitaMisura.kwh;
            if (TipologiaBolletta == TipoBolletta.gas)
                return UnitaMisura.mc;
            return UnitaMisura.min;
        }

        public string ToString()
        {
            return $"----- Utente ----- \n{User.ToString()}\n" +
                $"----- Bolletta -----\n" +
                $"Tipologia: \t{TipologiaBolletta}({UnitaMisura}) \n" +
                $"Consumo: \t{Consumo} \n" +
                $"Importo (eur):\t{Importo}\n" +
                $"Data di scadenza: {DataScadenza.ToShortDateString()}";
        }
    }
}
