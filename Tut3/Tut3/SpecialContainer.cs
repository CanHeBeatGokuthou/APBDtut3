namespace DefaultNamespace;

public class SpecialContainer
{
    
    private static List<SpecialRecord> records;
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

    public void removeRecord(User user)
    {
        SpecialRecord recordToRemove = null;
        foreach (SpecialRecord record in records)
        {
            if (record.User == user)
            {
                recordToRemove = record;
                break;
            }
        }

        if (recordToRemove != null)
        {
            records.Remove(recordToRemove);
        }
    }
    public int size()
    {
        return records.Count;
    }

    public int countUserRentals(User user)
    {
        int count = 0;
        foreach (SpecialRecord record in records)
        {
            if (record.User == user)
            {
                count++; 
            }
        }
        return count;
    }

    public List<SpecialRecord> getAllRecords()
    {
        return records;
    }
}