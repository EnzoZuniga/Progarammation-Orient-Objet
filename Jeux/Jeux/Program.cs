using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeux
{
    class Program
    {
        static void Main(string[] args)
        {

            Armes Dagger = new Armes("Dagger",5,1,4);
            Armes Staff = new Armes("Staff",10,1,5);
            Armes ShortSword = new Armes("Short Sword",15,1,6);

            Armes[] classArmes = new Armes[2];
            classArmes[0] = Dagger;
            classArmes[1] = Staff;
            classArmes[2] = ShortSword;

            Armures Robes = new Armures("Robes", 15,1);
            Armures LeatherArmor = new Armures("Leather Armor", 50, 2);
            Armures Helm2 = new Armures("Chaine Mail", 90, 3);

            Armures[] classArmures = new Armures[2];
            classArmures[0] = Robes;
            classArmures[1] = LeatherArmor;
            classArmures[2] = Helm2;

            Shield SmallShield = new Shield("Small Shield", 20, 2);
            Shield LargeShield = new Shield("Large Shield", 40, 3);
            Shield Shield1 = new Shield("Shield +1", 1500, 4);

            Shield[] classShield = new Shield[2];
            classShield[0] = SmallShield;
            classShield[1] = LargeShield;
            classShield[2] = Shield1;

            Gauntlets CopperGloves = new Gauntlets("Copper Gloves", 6000, 1);
            Gauntlets SilverGloves = new Gauntlets("Silver Gloves", 60000, 3);

            Gauntlets[] classGauntlets = new Gauntlets[1];
            classGauntlets[0] = CopperGloves;
            classGauntlets[1] = SilverGloves;

            Helmet Helm = new Helmet("Helm", 100, 1);
            Helmet Helm1 = new Helmet("Helm +1", 300, 2);
            Helmet Helm2Evil = new Helmet("Helm +2 (Evil)", 8000, 3);

            Helmet[] classHelmet = new Helmet[2];
            classHelmet[0] = Helm;
            classHelmet[1] = Helm1;
            classHelmet[2] = Helm2Evil;

        }
    }
}
