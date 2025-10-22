using System;

namespace HelloWorld
{
	public partial class Enemy : Character
	{
		public int health;
		public override void move()
		{
		  Console.WriteLine("Enemy moved");
		}
	}
}