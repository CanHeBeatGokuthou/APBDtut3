namespace DefaultNamespace;

public class SpecialContainer
{
    /*public DateTime RentalDate { get; set; }
    public DateTime ExpectedReturnDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    
    private int amount;
    private List<User> users;
    private List<Equipment> equipmentList;
    private int index = 1;

    public SpecialContainer(int amount,
        List<User> users, 
        List<Equipment> equipmentList,
        DateTime rentalDate,
        DateTime expecteDateTime
    )
    {
        this.amount = amount;
        this.users = users;
        this.equipmentList = equipmentList;
        RentalDate = rentalDate;
        ExpectedReturnDate = expecteDateTime;
        ReturnDate = null;
    }

    public void SetReturnDate(DateTime date)
    {
        ReturnDate = date;
    }

    public void setRentalDate(DateTime date)
    {
        RentalDate = date;
    }

    public void addRecord(User user,
        Equipment equipment,
        DateTime rentalDate,
        DateTime expectedReturnDate)
    {
        Console.WriteLine("To add record\n" +
                          "please enter user, " +
                          "equipment(Laptop,Projector,Camera), " +
                          "rentalDate, " +
                          "expectedReturnDate in given order: ");
        ++index;
        users.Add(user);
        equipmentList.Add(equipment);
        setRentalDate(rentalDate);
        SetReturnDate(expectedReturnDate);
        
    }

    public void deleteRecord(User user)
    {
        users.Remove(user);
        equipmentList.RemoveAt(index);
        setRentalDate(RentalDate);
        SetReturnDate(ExpectedReturnDate);
        --index;
    }*/
    private List<SpecialRecord> records;
    private int amount;

    public SpecialContainer(int amount)
    {
        this.amount = amount;
        records = new List<SpecialRecord>();
    }
    public void addRecord(User user,
        Equipment equipment,
        DateTime rentalDate,
        DateTime expectedReturnDate)
    {
        records.Add(new SpecialRecord(user, equipment
            , rentalDate, expectedReturnDate));
    }
}