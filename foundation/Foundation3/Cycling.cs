using System;

namespace Foundation3;

public class Cycling : Activity
{
    private double speedInKph;

    public Cycling(DateTime date, int minutes, double speedInKph) 
        : base(date, minutes)
    {
        this.speedInKph = speedInKph;
    }

    public override double GetDistance() { return speedInKph * (Minutes / 60.0); }
    public override double GetSpeed() { return speedInKph; }
    public override double GetPace() { return 60 / speedInKph; }
}
