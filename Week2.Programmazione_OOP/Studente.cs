using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class Studente : Persona
    {
        public int Matricola { get; set; }

        internal override double CalcolaStipendio ()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + $"Matricola: {Matricola}";
        }

    }
}
