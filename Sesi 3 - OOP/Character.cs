using System;

namespace HelloWorld
{
	public abstract class Character
	{
		public string charName;
		public abstract void move(); //wajib implement
		public void speak()
		{
		  Console.WriteLine($"My name is {charName}");
		}
	}
}