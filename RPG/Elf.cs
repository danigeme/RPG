using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Elf : Engine
    {

         public Elf()
        {
            Id = 0;
            WeaponW1 = 0;
            WeaponW2 = 0;
            WSelected = false;
            Hero = "Wizard";
            WeaponsW[0] = "Wand";
            WeaponsW[1] = "Gems";
            WeaponsW[2] = "Amulet";
            WeaponsW[3] = "Potions"; 

        }




    }
}
