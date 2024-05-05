using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Item item1 = new Item ("Bastón Mágico", 53, 0, "Arma");
            Item item2 = new Item ("Capa Mágica", 0 , 48, "Defensa");

            Wizard wizard1 = new Wizard ("Jose", 100);

            wizard1.AddItem(item1);
            wizard1.AddItem(item2);

            Item itemHelmet = new Item ("Casco", 0, 20, "Defensa");
            Item itemSword = new Item ("Espada", 60, 0, "Arma");

            Dwarf dwarf1 = new Dwarf("Carlos", 100);

            dwarf1.AddItem(itemHelmet);
            dwarf1.AddItem(itemSword);


            Item item_sword = new Item ("Espada", 50 , 0 , "Arma");
            Item item_shield = new Item ("Escudo", 0 , 45 , "Defensa");
            Elf elf1 = new Elf ("Ramon", 100);
            elf1.AddItem(item_sword);
            elf1.AddItem(item_shield);

            Item LargeBow = new Item ("Arco Largo", 75, 0, "Arma" );
            Item LightArmor = new Item ("Armadura Lijera", 0, 50, "Defensa" );
            Elf Marcos = new Elf ("Marcos", 100);

            Marcos.AddItem(LargeBow);
            Marcos.AddItem(LightArmor);

            Console.WriteLine ();



        }
    }
}


