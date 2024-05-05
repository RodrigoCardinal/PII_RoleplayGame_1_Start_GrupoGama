using System.Collections.Generic;


namespace Program
{
    public interface ICharacter
    {
        string Name {get; set;}
        int Health {get; set;}
        Dictionary<string,Item> Items {get; set;}

        void Attack(ICharacter enemy) {}
        void AddItem(Item item) {}

        void RemoveItem(string typeItem) {}

        int CalculateDefense() {return new int();}

        int CalculateDamage() {return new int();}
    }
}