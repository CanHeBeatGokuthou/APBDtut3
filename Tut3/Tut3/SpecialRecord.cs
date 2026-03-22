namespace DefaultNamespace;

public class SpecialRecord
{
    public long Id { get; } = RandomIdGenerator.GenerateUniqueId();
    public User Renter { get; }
    public Equipment RentedItem { get; }
    public DateTime RentalDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get;  set; }
    public double PenaltyAmount { get; set; }

    public bool IsActive => ReturnDate == null;
    
    public SpecialRecord(User renter, Equipment rentedItem, DateTime rentalDate, DateTime dueDate)
    {
        Renter = renter;
        RentedItem = rentedItem;
        RentalDate = rentalDate;
        DueDate = dueDate;
    }

    public void CompleteReturn(DateTime actualReturnDate, long penaltyPerDay)
    {
        ReturnDate = actualReturnDate;
        
        if (actualReturnDate > DueDate)
        {
            var daysLate = (actualReturnDate - DueDate).Days;
            PenaltyAmount = daysLate * penaltyPerDay; 
        }
    }


}