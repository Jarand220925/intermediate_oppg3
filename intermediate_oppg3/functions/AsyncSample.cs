namespace intermediate_oppg3.functions;

public static class AsyncSample
{
    private static int _runTimerExCount;
    public static async Task Count()
    {
        await _runTimer();
        Console.WriteLine("Count is done, World!");
        WriteSample();
    }

    public static async Task _runTimer()
    {
        for (int i = 0; i < 11; i++)
        {
            await Task.Delay(250);
            Console.WriteLine(i);
        }
        _runTimerExCount++;
        Console.WriteLine($"{_runTimerExCount} times executed _runTimer");
        WriteSample();
    }

    public static async void WriteSample()
    {
        Console.WriteLine("WriteSample");
    }
}