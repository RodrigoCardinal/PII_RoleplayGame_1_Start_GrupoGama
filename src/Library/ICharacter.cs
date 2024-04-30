using System;
using System.Collections.Generic;
namespace Roleplay1
{
    public interface ICharacter
    {
        

        string Name { get; set; }
        int Health { get;}
        int Damage { get; set; }
        int Defense { get; set; }

        void Attack(ICharacter enemi);
        void Heal (int amount);
         
        // P1("Toto",100,30,"arco","armadura",20)
        // P2("Tota",100,40,"espada", 0, "")
        //lugar("tres cruces")
        //pelea(p1,p2,lugar)
        //win(p1 o p2)

    }
}
