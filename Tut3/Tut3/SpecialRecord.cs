namespace DefaultNamespace;

public class SpecialRecord:RentalTime
{
    public DateTime RentalDate { get; set; }
    public DateTime ExpectedReturnDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    
    public User User { get; set; }
    public Equipment Equipment { get; set; }
    
    public SpecialRecord(User user, Equipment equipment,
        DateTime rentalDate, DateTime expectedReturnDate)
    {
        User = user;
        Equipment = equipment;
        RentalDate = rentalDate;
        ExpectedReturnDate = expectedReturnDate;
        ReturnDate = null;
    }

    public override string ToString()
    {
        
    }


}