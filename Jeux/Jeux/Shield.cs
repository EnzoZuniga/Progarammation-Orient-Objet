using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Shield
    {
        private string nomShield;
        private int valeur;
        private int ArmurClass;

        public Shield(string nomShield, int valeur, int ArmurClass)
        {
            this.nomShield = nomShield;
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
        public string GetNomShield()
        {
            return this.nomShield;
        }
    }
}
