namespace intermediate_oppg3.models;

public class Drone<T> where T: IComparable<string>
{
    public string Name;
    public int MsDelay {get; set;}
    public T Package {get; set;}
    public int PackageAmount {get; set;}
    public int MaxCheckpoints {get; set;}
    public int CurrentCheckpoint;
    
    public Drone(string name,int msDelay, T package, int packageAmount, int maxCheckpoints)
    {
        MsDelay = msDelay;
        Package = package;
        PackageAmount = packageAmount;
        MaxCheckpoints = maxCheckpoints;
        Name = name;
    }
    
    public Drone(string name,int msDelay, T package, int packageAmount, int maxCheckpoints, int currentCheckpoint)
    {
        MsDelay = msDelay;
        Package = package;
        PackageAmount = packageAmount;
        MaxCheckpoints = maxCheckpoints;
        Name = name;
        CurrentCheckpoint = currentCheckpoint;
    }

    public int GetCurrentCheckpoint()
    {
        return CurrentCheckpoint;
    }
}