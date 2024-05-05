using NUnit.Framework;

namespace Program
{
    public class ExampleTest
    {
        [Test]
        public void RemoveItem()
        {

            Item item1 = new Item ("Bastón Mágico", 52, 0, "Arma");
            Item item2 = new Item ("Capa Mágica", 52, 0, "Defensa");

            Wizard wizard1 = new Wizard ("Gerardo", 100);
            wizard1.AddItem(item1);
            wizard1.RemoveItem(item1);

            bool Contains = wizard1.Items.ContainsValue(item1);
            Assert.IsFalse(Contains);


        }
        [Test]
        public void AddItem()
        {
            Item item_sword = new Item ("Espada", 50 , 0 , "Arma");
            Item item_shield = new Item ("Escudo", 0 , 45 , "Defensa");
            Elf elf1 = new Elf ("Ramon", 100);
            elf1.AddItem(item_sword);

            bool Contains = elf1.Items.ContainsValue(item_sword);
            Assert.IsFalse(Contains);



        }

    }
}