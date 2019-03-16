using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Armures
    {
        private string nomArmure;
        private int valeur;
        private int ArmurClass;

        public Armures(string nomArmure, int valeur, int ArmurClass)
        {
            this.nomArmure = nomArmure;
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

        public string GetNomArmure()
        {
            return this.nomArmure;
        }
    }
}
