namespace DefaultNamespace;

public interface RentalTime
{
    public DateTime RentalDate { get; set;}
    public DateTime ExpectedReturnDate { get; set;}
    public DateTime? ReturnDate { get; set;}
    
    public void  SetReturnDate(DateTime date)
    {
        ReturnDate = date;
    }

    public void SetExpectedReturnDate(DateTime date)
    {
        ExpectedReturnDate = date;
    }

    public void setRentalDate(DateTime date)
    {
        RentalDate = date;
    }

    public TimeSpan? GetReturnTime()
    {
        if (ReturnDate != null)
        {
            return ReturnDate.Value-RentalDate;
        }
        return null;
    }

    public bool IsReturnDateValid()
    {
        return ReturnDate<=ExpectedReturnDate; 
    }
}