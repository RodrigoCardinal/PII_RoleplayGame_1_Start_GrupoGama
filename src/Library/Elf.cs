using System;
using System.Collections.Generic;

namespace Roleplay1
{
    public class Elf : ICharacter
    {
        

        public string Name {get; set;}
        public int Health{get; set;}
        public int Damage {get; set;}
        public int Defense {get; set;}  

        public void Elf_Builder (string name, int health, int damage, int defense)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Defense = defense; 
            
            
        }
        public void Attack(ICharacter character)
        {
            
        }
        public void Heal (int amount)
        {
            
        }
    }



}
