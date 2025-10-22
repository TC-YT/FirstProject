using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  public partial class Enemy
  {
    public string enemyType = "Goblin";
  }
	public class Program
	{
		public static void Main(string[] args)
		{
			//Interface : class harus memiliki function yang ada di interface
			Console.WriteLine("=====Interface=====");
			Wall Castle = new Wall(100);
			Castle.getWallHealth();
			Castle.displayDamage(10);
			Castle.getWallHealth();
			
			//Abstract
			Console.WriteLine("=====Abstract=====");
			Player player1 = new Player();
			player1.charName = "Mike";
			player1.speak();
			player1.move();
			player1.attack();
			
			//Partial
			Console.WriteLine("=====Partial=====");
			Enemy enemy1 = new Enemy();
			Console.WriteLine($"Enemy type is {enemy1.enemyType}");
			Console.WriteLine($"Enemy health is {enemy1.health}");
			enemy1.move();
			enemy1.charName = "Gob";
			enemy1.speak();
			
			//Sealed = class 
			Console.WriteLine("=====Sealed=====");
			ScoreManager sm = new ScoreManager();
			sm.myScore = 100;
			Console.WriteLine($"Score : {sm.myScore}");
		}
	}
}