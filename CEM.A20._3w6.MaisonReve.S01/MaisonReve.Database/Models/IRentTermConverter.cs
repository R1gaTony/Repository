namespace MaisonReve.Database.Models
{
    public interface IRentTermConverter
    {
        int ConvertLeaseLength(int actualLeaseLength, RentTerm previousTerm, RentTerm newTerm);
    }





}



