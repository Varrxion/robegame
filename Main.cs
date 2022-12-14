using System;

namespace Robe
{
	public class Robegame
	{
		static void Main()
		{
			Player player = new Player(100, 10);
			Enemy enemy = new Enemy(50, 5);

			enemy.Takedamage(player.Attack());

			Console.WriteLine(player.Attack());

			enemy.printstats();

			Console.WriteLine("TEST");
		}
	}
}