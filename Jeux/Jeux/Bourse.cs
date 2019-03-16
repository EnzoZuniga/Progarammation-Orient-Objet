using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Bourse
    {
        private int nombreOr;
        public Bourse(int nombreOr)
        {
            this.nombreOr = nombreOr;
            nombreOr = 0;
        }

        public void Placer(int quantite)
        {
            nombreOr = nombreOr + quantite;
        }

        public void Prendre(int quantite)
        {
            if (quantite <= nombreOr)
            {
                nombreOr = nombreOr - quantite;
            }
            else
            {
                Console.WriteLine("tu n'as pas assez de pièce");
            }
        }

        
        public int GetNombrePiece()
        {
            return this.nombreOr;
        }

        public new string ToString()
        {
            string quantitéOr;
            quantitéOr = string.Format("Vous disposer de {0} d'or", nombreOr);
            return quantitéOr;
        }

    }
}
