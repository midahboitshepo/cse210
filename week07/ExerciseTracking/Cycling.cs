public class Cycling : Activity
{
    private double _distance; // in miles
    private double _speed; // in miles per hour
    private double _pace; // in minutes per mile

    public Cycling(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
        _speed = CalculateSpeed();
        _pace = CalculatePace();
    }

    private double CalculateSpeed()
    {
        return _distance / (Duration / 60.0);
    }

    private double CalculatePace()
    {
        return Duration / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetBaseSummary()} - Distance: {_distance} miles, Speed: {_speed:F2} mph, Pace: {_pace:F2} min/mile";
    }
}