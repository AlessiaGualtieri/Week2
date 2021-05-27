using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class Persona
    {
        // Campi
        private string _nome;
        private int _eta;
        private double _stipendo = 1000.00;
                
        public DateTime DataNascita { get; set; } = new DateTime(1970, 1, 1);

        //Proprietà
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }

        }

        public int Eta
        {
            get { return _eta; }
            set { _eta = value; }
        }

        public string Cognome { get; set; }

        public double Stipendio { get {return CalcolaStipendio(); } }

        //public double Stipendio { get { return _stipendo(); } }

        // equivalente a quello sotto

        //public double Stipendio { get; } = 1000.00;

        // Oppure più comodamente, facendo le opportune modifiche
        //public double Stip
        //{
        //    get { return CalcolaStipendio(); }
        //}


        // Costruttori

        public Persona() { }    //Esiste anche senza dichiararlo, senza argomenti
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        //Metodi
        internal virtual double CalcolaStipendio ()
        {
            if(Cognome.StartsWith("1"))
            {
                throw new ArgumentException("Cognome non valido");
            }

            if (_eta >= 20 && _eta <= 25)
                _stipendo = 1000.00 + 0.1 * 1000.00;
            else if (Eta > 25)
                _stipendo = 1000.00 + 0.2 * 1000.00;

            return _stipendo;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nCognome: {Cognome} \nEtà: {Eta}\n" +
                $"Data di nascita: {DataNascita.ToShortDateString()} \nStipendio: {Stipendio}\n"   ;
        }

    }
}
