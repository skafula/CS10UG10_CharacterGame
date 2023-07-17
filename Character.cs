public abstract class Character
{
    private int _health;

    public string Name { get; set; }
    public int Health
    {
        set
        {
            if (_health - value < 0)
            {
                _health = 0;
            }
        }
        get
        {
            return _health;
        }
    }

    public int Attack { get; set; }
    public int Defense { get; set; }

    public Character(string name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
    }

    public virtual void AttackAt(Character target)
    {
        int damage = this.Attack - target.Defense;
        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{this.Name} attacks {target.Name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{this.Name}'s attack has no effect on {target.Name}.");
        }
    }

    public virtual void Defend()
    {
        Console.WriteLine($"{this.Name} defends and gain {this.Defense} defense.");
    }

}
