namespace intermediate_oppg3.functions;

public static class SecondAsyncSample
{
    public static async void PressX()
    {
        ConsoleKeyInfo keyinfo;
        do
        {
            keyinfo = Console.ReadKey();
            Console.WriteLine($" {keyinfo.Key} was pressed");
        }
        while (keyinfo.Key != ConsoleKey.X);
    }
    
    public static async Task TaskPressX()
    {
        ConsoleKeyInfo keyinfo;
        do
        {
            keyinfo = Console.ReadKey();
            Console.WriteLine($" {keyinfo.Key} was pressed");
        }
        while (keyinfo.Key != ConsoleKey.X);
    }
}