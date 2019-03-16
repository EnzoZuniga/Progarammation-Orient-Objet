using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Helmet
    {
        private string nomHelmet;
        private int valeur;
        private int ArmurClass;

        public Helmet(string nomHelmet, int valeur, int ArmurClass)
        {
            this.nomHelmet = nomHelmet;
            this.valeur = valeur;
            this.ArmurClass = ArmurClass;
        }

        public int GetValeur()
        {
            return this.valeur;
        }
        public int GetArmurClass()
        {
            return this.ArmurClass;
        }
        public string GetNomHelmet()
        {
            return this.nomHelmet;
        }
    }
}
