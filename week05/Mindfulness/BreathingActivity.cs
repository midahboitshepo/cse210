public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void run()
    {
        displayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        setDuration(duration);
        Console.WriteLine("Get ready...");
        showSpinner(3);
        int halfDuration = duration / 2;
        Console.WriteLine("Breathe in...");
        showCountdown(halfDuration);
        Console.WriteLine("Breathe out...");
        showCountdown(halfDuration);
        displayEndingMessage();
    }
}