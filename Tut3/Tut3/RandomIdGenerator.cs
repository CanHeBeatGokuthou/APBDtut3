namespace DefaultNamespace;

public interface RandomIdGenerator
{
    public static Random rand = new Random();

    public static long GenerateUniqueId()
    {
        DateTime now = new DateTime();
        long tick = now.Ticks;
        int random = rand.Next(500);
        long uniqueId = tick*1000 + random;
        return uniqueId;
    }
}