using System;

namespace HelloWorld
{
	public class Player : Character
	{
	  public override void move()
	  {
	   Console.WriteLine("Player moved");
	  }
	  public void attack()
	  {
	    Console.WriteLine("Player attacked");
	  }
	}
}