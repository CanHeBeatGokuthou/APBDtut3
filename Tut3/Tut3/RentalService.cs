namespace DefaultNamespace;

public class RentalService
{
    private readonly List<User> users = new();
    private readonly List<Equipment> equipment = new();
    private readonly List<SpecialRecord> rentals = new();
    
    private const double DailyPenaltyRate = 10;

    public void AddUser(User user) => users.Add(user);
    public void AddEquipment(Equipment item) => equipment.Add(item);

    public IEnumerable<Equipment> GetAllEquipment() => equipment;
    public IEnumerable<Equipment> GetAvailableEquipment() => equipment.Where(e => e.available);

    public void RentEqp(long userId, long equipmentId, DateTime date, int days)
    {
    }

}