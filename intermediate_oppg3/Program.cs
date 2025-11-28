using intermediate_oppg3.functions;
using intermediate_oppg3.models;

namespace intermediate_oppg3;

class Program
{
    static async Task Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //await CountWithAsyncAwait();
        /*var stask = AsyncSample.Count();
        var stask2 = AsyncSample.Count();
        await AsyncSample.Count();
        AsyncSample.WriteSample();*/
        List<Drone<string>> droneList = new();
        
        Drone<string> firstDrone = new("firstDrone",100,"Dynamite",1,9);
        Drone<string> secondDrone = new("secondDrone",220,"Lamp oil",1,9);
        
        droneList.Add(firstDrone);
        droneList.Add(secondDrone);
        
        /*var FD = FlightTower.AsyncSendSingleDrone(firstDrone);
        var SD = FlightTower.AsyncSendSingleDrone(secondDrone);*/
        var newTask = CountWithAsyncAwait();
        await FlightTower.AsyncSendDrones(droneList);
        Console.WriteLine("I'm the last WriteLine in the Main method.");
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