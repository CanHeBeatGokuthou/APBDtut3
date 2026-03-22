namespace DefaultNamespace;

public class RentalService
{
    private readonly List<User> users = new();
    private readonly List<Equipment> equipment = new();
    private readonly List<SpecialRecord> rentals = new();
    
    private const double DailyPenaltyRate = 10;

    public void AddUser(User user) => users.Add(user);
    public void AddEquipment(Equipment item) => equipment.Add(item);

    public List<Equipment> GetAllEquipment() 
    {
        return equipment.ToList(); 
    }

    public List<Equipment> GetAvailableEquipment() 
    {
        return equipment.Where(e => e.available).ToList();
    }

    public void RentEqp(long userId, long equipmentId, DateTime date, int days)
    {
        User foundUser = users.FirstOrDefault(u => u.id == userId) ?? throw new RentalException("User not found.");
        Equipment foundItem = equipment.FirstOrDefault(e => e.iD == equipmentId) ?? throw new RentalException("Equipment not found.");

        if (!foundItem.available)
        {
            throw new RentalException($"Equipment '{foundItem.name}' is currently unavailable."); 
        }
        int activeRentalsCount = rentals.Count(r => r.Renter.id == userId && r.IsActive);
        
        if (activeRentalsCount >= foundUser.MaxRentals)
        {
            throw new RentalException($"User {foundUser.name} has reached their rental limit of {foundUser.MaxRentals}."); 
        }
        SpecialRecord newRental = new SpecialRecord(foundUser, foundItem, date, date.AddDays(days));
        foundItem.available = false;
        rentals.Add(newRental);
    }

}