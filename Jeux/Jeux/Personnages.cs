using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jeux;

namespace Jeux
{
    class Personnage
    {
        private int force;
        private int intelligence;
        private Peuple peuple;
        private int vitalite;
        private int agilite;
        private int chance;
        private int pointsDeVie;
        private int pointsDeVieMaximum;
        private string nom;
        private Class classPersonnage;
        private Alignement alignement;
        private Potion potion;
        private Bourse bourse;
        private Helmet helmet;
        private Armures armures;
        private Armes armes;
        private Shield shields;
        private Gauntlets gauntlets;

        public Personnage(int pointsDeVieMaximum, int force, int agilite, string nom,
        Peuple peuple, int chance, Class classPersonnage , int vitalite , int intelligence, Alignement alignement)
        {
            this.pointsDeVie = pointsDeVieMaximum;
            this.pointsDeVieMaximum = pointsDeVieMaximum;
            this.force = force;
            this.agilite = agilite;
            this.peuple = peuple;
            this.nom = nom;
            this.chance = chance;
            this.classPersonnage = classPersonnage;
            this.vitalite = vitalite;
            this.intelligence = intelligence;
            this.alignement = alignement;
        }

        public Personnage(string nom)
        {
            Random r = new Random();
            this.pointsDeVie = pointsDeVieMaximum;
            this.pointsDeVieMaximum = r.Next(6, 15);
            this.force = r.Next(6, 15);
            this.agilite = r.Next(6, 15);
            this.peuple = (Peuple)r.Next(0, 7);
            this.nom = nom;
            this.chance = r.Next(6, 15);
            this.classPersonnage = (Class)r.Next(0, 3);
            this.vitalite = r.Next(6, 15);
            this.intelligence = r.Next(6, 15);
            this.alignement = (Alignement)r.Next(0, 2);
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public int GetAgilite
        {
            get
            {
                return this.agilite;
            }
        }
        public int GetForce
        {
            get
            {
                return this.force;
            }
        }
        public int GetIntelligence
        {
            get
            {
                return this.intelligence;
            }
        }
        public int GetChance
        {
            get
            {
                return this.chance;
            }
        }
        public int GetPointsDeVie
        {
            get
            {
                return this.pointsDeVie;
            }
        }
        public int GetPointsDeVieMaximum
        {
            get
            {
                return this.pointsDeVieMaximum;
            }
        }
        public int GetVitalite
        {
            get
            {
                return this.vitalite;
            }
        }
        public Alignement GetAlignement
        {
            get
            {
                return this.alignement;
            }
        }
        public Class GetClass
        {
            get
            {
                return this.classPersonnage;
            }
        }
        public Peuple GetPeuple
        {
            get
            {
                return this.peuple;
            }
        }
        public void Deplacer(int direction) { }

        public void Regarder(int distance, int direction) { }

        public void Frapper(Personnage adversaire, int degats) { }

        public void Boire(Potion potion, int pointDeVie)
        {
            this.pointsDeVie = this.pointsDeVie + Potion.;
            
        }
        private void recevoirCoup(int degats){ }

        public bool EstVivant() { return true; }

        private void mourir(){ }

        public new string ToString()
        {
            string caracteristique;
            caracteristique = string.Format("Votre personnage possède ces caractérisques : {0} en agilité, {1} en intelligence,{2} en chance, {3} en force, {4} en vitalitée, {5} points de vie, de classe {6}, d'alignement {7} et de peuple {8}", this.agilite, this.intelligence, this.chance, this.force, this.vitalite, this.pointsDeVie, this.classPersonnage, this.alignement, this.peuple);
            return caracteristique;
        }
    }

}
