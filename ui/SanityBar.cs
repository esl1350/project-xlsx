using Godot;
using System;

public partial class SanityBar : ProgressBar
{
    [Export] private float _maxSanity = 100.0f;

    [Export] private float _sanityDrainRatePerSecond = 5.0f;

    private float _currentSanity;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _currentSanity = _maxSanity;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}