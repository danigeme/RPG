using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    interface Engine
    {
        

            string Hero { get; set; }

            bool WSelected { get; set;}

          //  string this [int index]{ get; set; }

            void ChooseWeapon();

            void Attack(string Weapon1,string Weapon2);

            void SpecialAttack(string Weapon, int count);


    }
}
