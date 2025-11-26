using intermediate_oppg3.functions;

namespace intermediate_oppg3;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //await CountWithAsyncAwait();
        await AsyncSample.Count();
        AsyncSample.WriteSample();
        Console.WriteLine("I'm the last WriteLine.");
    }
    
    
    public class CounterModel(string name, int maxCount, int delay)

    {

        public string Name {get;set;} = name;

        public int MaxCount {get;set;} = maxCount;

        public int DelayMs {get;set;} = delay;

    }



    public static async Task CountWithAsyncAwait()

    {

        Console.WriteLine("Starting counter on Async Task...");



        var counter1 = new CounterModel("Async Counter 1", 5, 500);

        var counter2 = new CounterModel("Async Counter 2", 6, 300);



        var task1 = AsyncCounter(counter1);

        var task2 = AsyncCounter(counter2);



        // Venter på at begge oppgavene skal fullføres

        await Task.WhenAll(task1, task2);

    

        Console.WriteLine("Async Tasks completed!");

    }



    private static async Task AsyncCounter(CounterModel model)

    {

        Console.WriteLine($"Async Task {model.Name} starting..");

    

        for (int i = 0; i <= model.MaxCount; i++)

        {

            await Task.Delay(model.DelayMs);

            Console.WriteLine($"Async Task {model.Name} has counted {i} / {model.MaxCount}...");

        }



        Console.WriteLine($"Async Task {model.Name} has completed the count...");

    }


}