using System;

namespace Foundation3;

public class Running : Activity
{
    private double distanceInKm;

    public Running(DateTime date, int minutes, double distanceInKm) 
        : base(date, minutes)
    {
        this.distanceInKm = distanceInKm;
    }

    public override double GetDistance() { return distanceInKm; }
    public override double GetSpeed() { return (distanceInKm / Minutes) * 60; }
    public override double GetPace() { return Minutes / distanceInKm; }
}
