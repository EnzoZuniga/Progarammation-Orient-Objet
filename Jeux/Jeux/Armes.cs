using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Armes
    {
        private string nomArme;
        private int valeur;
        private int degats;

        public Armes(string nomArme, int valeur, int degatMin, int deagtMax)
        {
            Random rnd = new Random();
            this.nomArme = nomArme;
            this.valeur = valeur;
            this.degats = rnd.Next(degatMin,deagtMax);
        }

        public int GetValeur()
        {
            return this.valeur;
        }
        public int GetDegats()
        {
            return this.degats;
        }

        public string GetNomArme()
        {
            return this.nomArme;
        }
    }
}
