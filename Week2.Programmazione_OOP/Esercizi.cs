using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    class Esercizi
    {

        #region ITERAZIONE vs RICORSIONE

        // 0    1   1   2   3   5   8...
        public static int FibonacciIterativo(int n)
        {
            int fib_old = 0, fib = 1, res = 0;

            if (n == 1)
                return fib_old;
            if (n == 2)
                return fib;
            else 
                for (int i = 0; i < n-2; i++)
                {
                    res = fib_old + fib;
                    fib_old = fib;
                    fib = res;
                }

            return res;
        }


        public static int FibonacciRicorsivo(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;
            return FibonacciRicorsivo(n - 1) + FibonacciRicorsivo(n - 2);

        }

        #endregion


        #region COPIA CLASSE PER REF vs PER COPIA
        public static void EsPersona()
        {
            Persona persona3 = new Persona("Naco", "Catto", 21);
            Console.WriteLine(persona3.ToString());

            //Persona persona4 = persona3;
            //Console.WriteLine(persona4.ToString());

            //persona3.Nome = "Miao";
            //persona3.Cognome = "Bulabula";
            //persona3.Eta = 43;
            //Console.WriteLine(persona3.ToString());
            //Console.WriteLine(persona4.ToString());

            //Persona persona4;
            //Studente s = new Studente()
            //{
            //    Nome = "Mario",
            //    Cognome = "Rossi",
            //    Eta = 43,
            //    Matricola = 911442
            //};
            //Console.WriteLine(s.ToString());

        }

        

            #endregion

        #region EREDITARIETA'



        #endregion

        #region EXCEPTION

        public static bool EsempioException(string s)
        {
            double res = 0;
            bool esito = true;

            try
            {
                res = Convert.ToInt16(s) ;
            }
            catch( FormatException a)
            {
                Console.WriteLine(a.Message);
                esito = false;
            }
            catch( OverflowException b)
            {
                Console.WriteLine(b.Message);
                esito = false;
            }
            catch( Exception c)
            {
                Console.WriteLine(c.Message);
                esito = false;
            }
            return esito;

        }

        public static void EccezioneLanciata()
        {
            Persona p = new Persona()
            {
                Cognome = "1Rossi",
                Nome = "Mario",
                Eta = 35
            };


            try
            {
                p.CalcolaStipendio();

            } catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        #endregion
    }
}
