using System;

public class Hostile : NonPlayable
{
	private int damage;

    public int Damage { get => damage; set => damage = value; }

    public Hostile()
	{
		damage = 0;
	}
	public Hostile(string name, double health, double speed, int damage)
    {
		Name = name;
		Health = health;
		Speed = speed;
		this.damage = damage;
    }

	public override void showInfo()
    {
		base.showInfo();
		Console.WriteLine("Damage: " + damage);
    }

	public override void deathSound()
	{
		Console.WriteLine("I'll see you in hell!");
	}
}
