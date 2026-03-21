namespace DefaultNamespace;

public static class RandomIdGenerator
{
    public static Random rand = new Random();

    public static long GenerateUniqueId()
    { 
        long tick = DateTime.Now.Ticks;
        int random = rand.Next(500);
        long uniqueId = tick*1000 + random;
        return uniqueId;
    }
}