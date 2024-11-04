public abstract class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public DateTime Date { get { return date; } }
    public int Minutes { get { return minutes; } }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F2} min/km";
    }
}