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
    public void ReturnEquipment(long rentalId, DateTime returnDate) 
    {
        SpecialRecord activeRental = rentals.FirstOrDefault(r => r.Id == rentalId && r.IsActive) 
                              ?? throw new RentalException("Active rental not found.");

        activeRental.CompleteReturn(returnDate, DailyPenaltyRate);
        activeRental.RentedItem.available = true;
    }

    public void MarkEquipmentUnavailable(long equipmentId) 
    {
        Equipment equipmentToMark = equipment.FirstOrDefault(e => e.iD == equipmentId);
        
        if (equipmentToMark != null) 
        {
            equipmentToMark.available = false;
        }
    }
    public SpecialRecord GetRentalForEquipment(long equipmentId) 
    {
        return rentals.FirstOrDefault(r => r.RentedItem.iD == equipmentId && r.IsActive);
    }
    public void PrintSummaryReport() 
    {
        Console.WriteLine("\n--- RENTAL SERVICE SUMMARY ---");
        Console.WriteLine($"Total Users: {users.Count}");
        Console.WriteLine($"Total Equipment: {equipment.Count} ({equipment.Count(e => e.available)} available)");
        Console.WriteLine($"Total Active Rentals: {rentals.Count(r => r.IsActive)}");
        Console.WriteLine($"Total Penalties Generated: {rentals.Sum(r => r.PenaltyAmount)} PLN");
        Console.WriteLine("------------------------------\n");
    }

}