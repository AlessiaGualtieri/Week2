using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class Utente
    {
        public string CodiceUtente { get; set; } = "xxxxx";
        public string Nome { get; set; } = "xxxxx";
        public string Cognome { get; set; } = "xxxxx";
        public DateTime DataNascita { get; set; } = new DateTime(2000, 01, 01);

        //Metodo
        public string ToString()
        {
            return $"Codice utente: \t{CodiceUtente}\n" +
                $"Nome: \t\t{Nome}\n" +
                $"Cognome: \t{Cognome}\n" +
                $"Data di nascita: {DataNascita.ToShortDateString()}\n";
        }
    }
}
