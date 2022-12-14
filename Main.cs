using System;

namespace Robe
{
	public class RobeGame
	{
		static void Main()
		{
			Graphics.DrawTitle();
			Graphics.DrawTitleOptions();

			Player player = new Player(100, 10);
			Enemy enemy = new Enemy(50, 5);

			enemy.TakeDamage(player.Attack());

			Console.WriteLine(player.Attack());

			enemy.PrintStats();
		}
	}
}