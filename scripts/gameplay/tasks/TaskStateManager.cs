using Godot;
using System;

public partial class TaskStateManager : Node
{
	//TODO add more abstraction here? e.g. signals for success, failure, or premature ending.
	
	[Signal]
	public delegate void TaskStartEventHandler();
	
	public override void _Ready()
	{
		// this can be moved if needed for a countdown, etc.
		EmitSignal(SignalName.TaskStart);
	}
}
