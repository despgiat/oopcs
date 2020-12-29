using System;

public sealed class Slime : Hostile
{
	string color;
	double jump_height;

	public Slime()
    {
		color = "Unknown";
		jump_height = 0;
    }

	public Slime(string name, double health, double speed, int damage, string color, double jump_height): base(name, health, speed, damage)
	{
		this.color = color;
		this.jump_height = jump_height;
	}

    public override void showInfo()
    {
        base.showInfo();
		Console.WriteLine("Slime Color: " + color);
		Console.WriteLine("Jump Height: " + jump_height);
    }

	public override void deathSound()
	{
		Console.WriteLine("*bubbling sounds*");
	}
}
