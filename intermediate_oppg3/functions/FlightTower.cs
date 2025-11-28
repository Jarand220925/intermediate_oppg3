using intermediate_oppg3.models;

namespace intermediate_oppg3.functions;

public static class FlightTower
{
    private static int _dronesInAir;

    public static async Task AsyncSendDrones(List<Drone<string>> drones)
    {
        List<Task> asdDronelist = new();
        foreach(var drone in drones)
        {
            var Tsc = AsyncSendSingleDrone(drone);
            asdDronelist.Add(Tsc);
            /*for (int i = drone.CurrentCheckpoint; i < drone.MaxCheckpoints; i++)
            {
                Console.WriteLine($"Drone: {drone.Name} is at checkpoint: {i}");
                await Task.Delay(drone.MsDelay);

            }*/
        }
        
        await Task.WhenAll(asdDronelist);
    }

    public static async Task AsyncSendSingleDrone(Drone<string> drone)
    {
        for (int i = drone.CurrentCheckpoint; i <= drone.MaxCheckpoints; i++)
        {
            Console.WriteLine($"Drone: {drone.Name} is at checkpoint: {i}/{drone.MaxCheckpoints}");
            await Task.Delay(drone.MsDelay);
                
        }
    }
}