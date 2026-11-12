using Godot;
using System;

public partial class FishBehaviors : Node3D
{
	public Vector3 angleThang;
	
	private PlayerMovement player;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetNode<PlayerMovement>("/root/root/PlayerCharacterBody");
		angleThang = RotationDegrees;
		Console.WriteLine("");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (player.time)
		{
			angleThang.Y += 3; 
			RotationDegrees = angleThang;

			Position += (player.GlobalPosition - GlobalPosition) * 2f * (float) delta;

			if ((GlobalPosition.X <= player.GlobalPosition.X + 0.25 && GlobalPosition.X >= player.GlobalPosition.X - 0.25) && (GlobalPosition.Z <= player.GlobalPosition.Z + 0.25 && GlobalPosition.Z >= player.GlobalPosition.Z - 0.25))
			{
				SetVisible(false);
				SetProcess(false);
			}
		}
	}
}
