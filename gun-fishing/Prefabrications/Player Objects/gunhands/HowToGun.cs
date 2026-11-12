using Godot;
using System;

public partial class HowToGun : AnimationPlayer
{
	private bool isOut = false;
	private bool isReloading = false;

	public int numBullets = 6;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!isOut && !IsPlaying() && IsActive())
		{
			Play("pullout");
			isOut = true;
		}

		if (Input.IsActionJustPressed("ui_inspect") && !isReloading)
			Play("pullout");

		if (numBullets != 6 && Input.IsActionJustPressed("ui_reload"))
		{
			isReloading = true;
			numBullets = 6;
			Play("reload", -1, 1.5f);
		}

		if (Input.IsActionJustPressed("ui_pew") && !isReloading && numBullets > 0)
		{
			Stop();
			numBullets -= 1;
			Play("shoot", -1, 1.5f);
		}

		if (!IsPlaying())
		{
			isReloading = false;
			Play("idle");
		}
	}
}
