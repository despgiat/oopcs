using System;

public partial class Turret : Hostile
{
	private int ammo;
	private double reload_time;
	private string ammo_type;
	private int current_ammo;

	public Turret()
	{
		current_ammo = ammo = 0;
		reload_time = 0;
		ammo_type = "Unknown";
	}
	public Turret(string name, double health, double speed, int damage, int ammo, double reload_time, string ammo_type): base(name, health, speed, damage)
	{
		this.ammo = current_ammo = ammo;
		this.reload_time = reload_time;
		this.ammo_type = ammo_type;
	}

}

public partial class Turret : Hostile
{
	public override void showInfo()
    {
		base.showInfo();
		Console.WriteLine("Ammunition Capacity: " + ammo);
		Console.WriteLine("Reload Time: " + reload_time);
		Console.WriteLine("Ammunition Type: " + ammo_type);
	}

	public void shoot()
    {
		if(current_ammo == 0)
        {
			Console.WriteLine("Reloading...");
			current_ammo = ammo;
        }
		current_ammo--;
		Console.WriteLine("Kaboom!");
    }

}

public partial class Turret: Hostile
{
	public override void deathSound()
	{
		Console.WriteLine("Glonk!");
	}
}
