namespace MaisonReve.Database.Exceptions
{

    public class NotFoundException : BuildingRepoException
    {
        public NotFoundException(string message) : base(message)
        {
            
        }
    }


}