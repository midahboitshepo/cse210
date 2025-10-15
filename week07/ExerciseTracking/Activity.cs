public abstract class Activity{
    public string Date { get; set; }
    public int Duration { get; set; } // in minutes

    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public string GetBaseSummary()
    {
        return $"{Date} - Duration: {Duration} minutes";
    }

    public abstract string GetSummary();
}
