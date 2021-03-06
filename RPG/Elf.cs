﻿using System;
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
            WeaponW1 = 0;
            WeaponW2 = 0;
            WSelected = false;
            Hero = "Elf";
            WeaponsE[0] = "Arrows";
            WeaponsE[1] = "Dagger";
            WeaponsE[2] = "Runes";
            WeaponsE[3] = "Sword"; 

        }
//Variables of "Engine.cs" Interface
      

        public  string Hero { get; set; }

        public bool WSelected{get;set;}

        public string[] WeaponsE = new string[4];


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
            Console.WriteLine("Choose a Weapon for your "+ Hero+":\n" + "1.- " + WeaponsE[0] + "\n" + "2.- " + WeaponsE[1] + "\n" + "3.- " + WeaponsE[2] + "\n" + "4.- " + WeaponsE[3] + "\n");
            Console.WriteLine("First Weapon: ");
            WeaponW1 = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine("You've chosen: " + WeaponsE[WeaponW1] + "!");
            Console.ReadKey();
            Console.WriteLine("Second Weapon: ");
            WeaponW2 = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine("You've chosen: " + WeaponsE[WeaponW2] + "!");
            this.WSelected = true;
            Console.ReadKey();           
            Attack(WeaponsE[WeaponW1], WeaponsE[WeaponW2]);        
        }

        public void SpecialAttack(string Weapon, int count)
        {
            
            string specialA = "x";
            string conf = "";

            if (count >= 3)
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
                Console.WriteLine(Hero + " has used the {{" + Weapon + "}}!!!" + "\n");
                Console.WriteLine("Especial Attack " + count +"/3");
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

