using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jeux;

namespace SlamCrawler
{
    class Potion
    {
        private int nombrePointDeVie;
        private TypeDePotion typeDePotion;
        private string couleurPotion;

        public Potion(int nombrePointDeVie, TypeDePotion typeDePotion) 
        {
            int borne;
            Random r = new Random();
            this.nombrePointDeVie = nombrePointDeVie;
            this.typeDePotion = typeDePotion;
            borne = r.Next(0,100);

            if (borne <= 80)
            {
                if (typeDePotion == TypeDePotion.poison)
                {
                    couleurPotion = "rouge";
                }
                else
                {
                    if (typeDePotion == TypeDePotion.antipoison)
                    {
                        couleurPotion = "verte";
                    }
                    else
                    {
                        couleurPotion = "bleu";
                    }
                }
                if (borne > 80 && borne <= 90)
            {
                if (typeDePotion == TypeDePotion.poison)
                {
                    couleurPotion = "verte";
                }
                if (typeDePotion == TypeDePotion.antipoison)
                {
                    couleurPotion = "rouge";
                }
                if (typeDePotion == TypeDePotion.neutre)
                {
                    couleurPotion = "verte";
                }
            }
            if (borne > 90 && borne <= 100)
            {
                if (typeDePotion == TypeDePotion.poison)
                {
                    couleurPotion = "bleu";
                }
                if (typeDePotion == TypeDePotion.antipoison)
                {
                    couleurPotion = "bleu";
                }
                if (typeDePotion == TypeDePotion.neutre)
                {
                    couleurPotion = "rouge";
                }

            }
        }
        public int GetNombre()
        {
            return this.nombrePointDeVie;
        }

    }
}