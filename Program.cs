﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Create some characters
        Warrior c1 = new Warrior("Arthur", 100, 20, 10);
        Mage c2 = new Mage("Merlin", 80, 15, 5);
        Dragon c3 = new Dragon("Smaug", 200, 30, 20);

        // Test the characters' methods
        c1.AttackAt(c2);
        c2.Defend();
        c3.BreatheFire(c1);
        c3.Defend();
        c1.Defend();

        // Create a new game and simulate some battles
        Game game = new Game();
        game.Battle(c1, c2);
        game.Battle(c3, c1);
        game.Battle(c2, c3);

        Console.ReadKey();
    }
}
