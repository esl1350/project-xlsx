using Godot;
using System;

public partial class Task : Node
{
	[Export] protected float TimeLimitSeconds;
	
	[Signal]
	public delegate void TaskStartEventHandler();
	
	[Signal]
	public delegate void TaskSuccessEventHandler(float sanityChange);
	
	[Signal]
	public delegate void TaskFailureEventHandler(float sanityChange);
	
	public override void _Ready()
	{
		EmitSignal(SignalName.TaskStart);
	}
}
