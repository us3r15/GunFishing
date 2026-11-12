using Godot;
using System;

public partial class BulletDisplay : TextEdit
{
	public HowToGun gun;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		gun = GetNode<HowToGun>("/root/AnimationPlayer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Text = gun.numBullets + "/6";
	}
}
