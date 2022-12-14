using System;

namespace Robe
{
	public class RobeGame
	{
		static void Main()
		{
			Player player = new Player(100, 10);
			Enemy enemy = new Enemy(50, 5);

			enemy.TakeDamage(player.Attack());

			Console.WriteLine(player.Attack());

			enemy.PrintStats();

			Console.WriteLine("TEST");
		}
	}
}