using Godot;
using System;

public partial class NewGame : Button
{
	private PackedScene tutorial;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		tutorial = GD.Load<PackedScene>("res://Worlds/Tutoria/TutorialWorld.tscn");
		Pressed += OnButtonPressed;
	}

	private void OnButtonPressed()
	{
		GetTree().CurrentScene.QueueFree(); // kills your start menu + all its 3D stuff
		GetTree().Root.AddChild(tutorial.Instantiate());
	}
}
