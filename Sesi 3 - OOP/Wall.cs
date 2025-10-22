using System;

namespace HelloWorld
{
	public class Wall : IsDamageable
	{
    public void displayDamage(int amount)
    {
      Console.WriteLine($"Damage : {amount}");
      health -= amount;
    }
    private int health;
    public void getWallHealth()
    {
      Console.WriteLine($"Wall's HP : {health}");
    }
    public Wall(int input)
    {
      health = input;
    }
	}
}