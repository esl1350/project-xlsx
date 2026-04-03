using Godot;
using System;

public partial class SanityBar : ProgressBar
{
    public override void _Ready()
    {
        MaxValue = 100.0f;
        MinValue = 0.0f;
    }

    public void OnSanityChange(float oldSanity, float newSanity, float percentSanityRemaining)
    {
        Value = percentSanityRemaining * 100.0f;
    }
}