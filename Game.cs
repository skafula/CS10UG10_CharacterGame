public class Game
{
     public void Battle(Character c1, Character c2)
     {
        Console.WriteLine($"--- Battle between {c1.Name} and {c2.Name} ---");
        while (c1.Health > 0 && c2.Health > 0)
        {
            c1.AttackAt(c2);
            if (c2.Health > 0)
            {
                c2.AttackAt(c1);
            }
        }

        if (c1.Health <= 0)
        {
            Console.WriteLine($"{c2.Name} wins!");
        }
        else
        {
            Console.WriteLine($"{c1.Name} wins!");
        }
     }
}
