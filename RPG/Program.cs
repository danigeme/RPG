using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
           bool exitmenu = false;
           while (!exitmenu)
           {
               Console.WriteLine("Menu\nChoose your player: \n");
               Console.WriteLine("1. Wizard ");
               Console.WriteLine("2. Elf");
               Console.WriteLine("3. Warrior");
               Console.WriteLine("0. Exit\n");
               int opt = Int32.Parse(Console.ReadLine());
               switch (opt)
               {
                   case 0: 
                       exitmenu = true;
                       break;
                   case 1:
                       Wizard PWizard = new Wizard();
                       PWizard.ChooseWeapon();
                       break;
                   case 2:
                       Elf PElf = new Elf();
                       PElf.ChooseWeapon();                       
                       break;
                   case 3:
                       Warrior PWarrior = new Warrior();
                       PWarrior.ChooseWeapon();                       
                       break;

               }

           } 


        }
    }
}
