using System.Xml.Linq;

public class Dragon : Character
{
    public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void BreatheFire(Character target)
    {
        int damage = this.Attack * 4 - target.Defense;
        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{this.Name} breathes fire on {target.Name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{this.Name}'s fire has no effect on {target.Name}.");
        }
    }

    public override void Defend()
    {
        Console.WriteLine($"{this.Name} defends and gains 10 defense.");
        this.Defense += 10;
    }
}