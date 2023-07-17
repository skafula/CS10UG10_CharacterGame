using System.Xml.Linq;

public class Warrior : Character
{
    public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
    }

    public void Charge(Character target)
    {
        int damage = Attack * 2 - target.Defense;
        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{this.Name} charges {target.Name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{this.Name}'s charge has no effect on {target.Name}.");
        }
    }

    public override void Defend()
    {
        this.Defense += 5;
        Console.WriteLine($"{this.Name} defemds amd gains 5 defense.");
    }
}