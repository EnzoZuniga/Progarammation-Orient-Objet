using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Gauntlets
    {
        private string nomGauntlets;
        private int valeur;
        private int ArmurClass;

        public Gauntlets(string nomGauntlets, int valeur, int ArmurClass)
        {
            this.nomGauntlets = nomGauntlets;
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
        public string GetNomGauntlets()
        {
            return this.nomGauntlets;
        }
    }
}
