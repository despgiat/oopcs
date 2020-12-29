using System;

public class NonPlayable : Character
{
	private double health;
	private string name;
	private double speed;

    public double Health { get => health; set => health = value; }
    public string Name { get => name; set => name = value; }
    public double Speed { get => speed; set => speed = value; }

    public NonPlayable()
	{
		health = 0;
		name = "Unknown";
		speed = 0;
	}

	public NonPlayable(string name, double health, double speed)
	{
		this.health = health;
		this.name = name;
		this.speed = speed;
	}

	public override void showInfo()
	{
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Health: " + health);
		Console.WriteLine("Speed: " + speed);
	}

    public override void deathSound()
    {
		Console.WriteLine("Oh no! I died!");
    }
}