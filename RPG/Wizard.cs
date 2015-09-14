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
            Console.WriteLine("Choose a Weapon for your "+ Hero+":\n" + "1.- " + WeaponsW[0] + "\n" + "1.- " + WeaponsW[1] + "\n" + "1.- " + WeaponsW[2] + "\n" + "1.- " + WeaponsW[3] + "\n");
            Console.WriteLine("First Weapon: ");
            WeaponW1 = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine("Second Weapon: ");
            WeaponW2 = Int32.Parse(Console.ReadLine())-1;
            this.WSelected = true;
            string Wep1 = WeaponsW[WeaponW1];
            string Wep2 = WeaponsW[WeaponW2];
            Attack(Wep1, Wep2);
        
        }

        public void Attack(string Weapon1, string Weapon2) { 
            if(!this.WSelected){
                Console.WriteLine("No Weapons Selected");
            }
            else{
                while(!exit){
                    Console.WriteLine("Menu\n");

                    Console.WriteLine("1. Attack Opponent with {{" + WeaponsW[WeaponW1]+"}}" +"\n");
                    Console.WriteLine("2. Attack Opponent with {{" + WeaponsW[WeaponW2] +"}}" +"\n");
                    Console.WriteLine("0. Exit\n");                
                    int opt = Int32.Parse(Console.ReadLine());
                    switch (opt) {
                        case 0: exit = true;  
                                break;
                        case 1: Console.WriteLine(Hero +" has attacked Opponent with {{" + WeaponsW[WeaponW1]+"}}!!!" + "\n"); 
                                break;
                        case 2: Console.WriteLine(Hero + " has attacked Opponent with {{" + WeaponsW[WeaponW2] + "}}!!!" + "\n");  
                                break;
                    
                                  }

                             }            
                         }
        
                     }

    }
}