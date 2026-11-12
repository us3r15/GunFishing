using Godot;
using System;

public partial class Verticalise : Camera3D
{
	private PlayerMovement player;
	
	public override void _Ready()
	{
		player = GetNode<PlayerMovement>("/root/root/PlayerCharacterBody");
	}
	
	public override void _Input(InputEvent @event)
	{
		if ((@event is InputEventMouseMotion mouseMotion) && player.time)
		{
			if (GetRotation().X < Mathf.Pi / 2 && GetRotation().X > -Mathf.Pi / 2)
			{
				RotateX(mouseMotion.Relative.Y * player.sensitivity);
			}

			Rotation = new Vector3(Mathf.Clamp(Rotation.X + mouseMotion.Relative.Y * player.sensitivity, -Mathf.Pi / 2, Mathf.Pi / 2), Rotation.Y, Rotation.Z
);   
		}
	}
}
