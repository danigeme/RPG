using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Wizard : Engine
    {

        //initializing variables (?)
        public Wizard()
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

     
        
        //Variables of "Engine.cs" Interface
        public  int Id { get; set; }

        public  string Hero { get; set; }

        public bool WSelected{get;set;}

        public string[] WeaponsW = new string[4];

       /* public  string this[int index] {
            get {return WeaponsW[index];}
            set { WeaponsW[index] = value; } 
            }*/

        //Variables of "Wizard.cs" Class
        public static bool exit = false;
        int _WeaponW1, _WeaponW2;

        public int WeaponW2
        {
            get { return _WeaponW2; }
            set { _WeaponW2 = value; }
        }

        public int WeaponW1
        {
            get { return _WeaponW1; }
            set { _WeaponW1 = value; }
        }

        //Methods of "Engine.cs" Interface
        public void ChooseWeapon(){
            Console.WriteLine("Choose a Weapon for your "+ Hero+":\n" + "1.- " + WeaponsW[0] + "\n" + "2.- " + WeaponsW[1] + "\n" + "3.- " + WeaponsW[2] + "\n" + "4.- " + WeaponsW[3] + "\n");
            Console.WriteLine("First Weapon: ");
            WeaponW1 = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine("You've chosen: " + WeaponsW[WeaponW1] + "!");
            Console.ReadKey();
            Console.WriteLine("Second Weapon: ");
            WeaponW2 = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine("You've chosen: " + WeaponsW[WeaponW2] + "!");
            this.WSelected = true;
            Console.ReadKey();           
            Attack(WeaponsW[WeaponW1], WeaponsW[WeaponW2]);        
        }

        public void SpecialAttack(string Weapon, int count)
        {
            
            string specialA = "x";
            string conf = "";

            if (count > 3)
            {
                
                Console.WriteLine("Do you want to use the special Attack? Press 'x'!");
                conf = Console.ReadLine();
                
                if (specialA.Equals(conf))
                {
                    Console.WriteLine(Hero + " has used the special attack! of his {{" + Weapon + "}}!!!" + "\n");
                    Console.ReadKey();
                 }
               
   
            }
            else
            {
                Console.WriteLine(Hero + " has used the magic of the {{" + Weapon + "}}!!!" + "\n");
                Console.WriteLine("Especial Attack +1!");
                Console.ReadKey();
               

            }
            
        
        }


        public void Attack(string Weapon1, string Weapon2) {
            int count = 0;
            if(!this.WSelected){
                Console.WriteLine("No Weapons Selected");
            }
            else{
                while(!exit){
                    Console.WriteLine("Menu\n");

                    Console.WriteLine("1. Attack Opponent with {{" + Weapon1+ "}}" +"\n");
                    Console.WriteLine("2. Attack Opponent with {{" + Weapon2 +"}}" +"\n");
                    Console.WriteLine("0. Exit\n");
                    Console.WriteLine("Weapon: ");
                    int opt = Int32.Parse(Console.ReadLine());
                    switch (opt) {
                        case 0: 
                            exit = true;  
                                break;
                        case 1:
                                count++;
                                SpecialAttack(Weapon1, count);
                                if (count > 3) { count = 0; }
                                break;
                        case 2: 
                                count++;
                                SpecialAttack(Weapon2, count);
                                if (count > 3) { count = 0; }
                                break;
                    
                                  }

                             }            
                         }
        
                     }

    }
}