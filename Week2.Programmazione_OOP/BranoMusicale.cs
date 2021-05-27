using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Programmazione_OOP
{
    enum GenereMusicale
    {
        Rock = 1,
        Pop,
        Metal,
        Rap,
        Indie
    }

    class BranoMusicale
    {
        //gestione brani musicali: titolo durata artista genere
        //dev'essere possibile capire se un brano è live o meno con metodo
        //bool IsVersioneLive (durata > 5min)

        public string Titolo { get; set; } = "";    //serve per evitare che sia null quando non inizializzato e dia exception
        public double Durata { get; set; }
        public string Artista { get; set; } = "";
        public GenereMusicale Genere { get; set; }

        public static String Formato = "mp3";

        public bool VersioneLive { get { return IsVersioneLive(); } }


        //Metodo
        public bool IsVersioneLive()
        {
            return Durata > 5;
        }

        public string ToString()
        {
            string branoLive = "Versione registrata";
            if (VersioneLive == true)
                branoLive = "Versione concerto";

            return $"Titolo: {Titolo} \n" +
                $"Durata: {Durata} min\n" +
                $"Artista: {Artista} \n" +
                $"Genere: {Genere}\n" +
                $"Versione Live: {branoLive}";
        }


    }
}
