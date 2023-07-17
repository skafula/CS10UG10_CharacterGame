public class Mage : Character
{
    public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void CastSpell(Character target)
    {
        int damage = Attack * 3 - target.Defense;
        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{this.Name} casts a spell on {target.Name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{this.Name}'s spell has no effect on {target.Name}.");
        }
    }

    public sealed override void Defend()
    {
        Console.WriteLine($"{this.Name} cannot defend!");
    }
}