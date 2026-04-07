using Godot;
using System;

public partial class SanityManager : Node
{
	[Export] private float _maxSanity = 100.0f;

	[Export] private float _sanityDrainRatePerSecond = 3.0f;
	
	[Export] private float _sanityTicksPerSecond = 20.0f;

	[Signal]
	public delegate void SanityChangeEventHandler(float oldSanity, float newSanity, float percentSanityRemaining);
	
	private float _currentSanity;
	
	private Timer _sanityTimer = new Timer();

	private float _sanityDrainRatePerTick;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_currentSanity = _maxSanity;
		_sanityTimer.WaitTime = 1.0f / _sanityDrainRatePerSecond;
		_sanityTimer.Autostart = true;
		_sanityDrainRatePerTick = _sanityDrainRatePerSecond / _sanityTicksPerSecond;
		EmitSignal(SignalName.SanityChange, _currentSanity, _currentSanity, 1.0f);
		AddChild(_sanityTimer);
		_sanityTimer.Timeout += OnSanityTimerTick;
	}
	
	public void OnSanityTimerTick()
	{
		var newSanity = _currentSanity - _sanityDrainRatePerTick;
		EmitSignal(SignalName.SanityChange, _currentSanity, newSanity, newSanity/_maxSanity);
		_currentSanity = newSanity;
	}
}
