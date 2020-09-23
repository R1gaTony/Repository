namespace MaisonReve.Database.Exceptions
{
    public class PropertyException : BuildingRepoException
    {


        public PropertyException(string property, string message) : base(property,message)
        {
       
        }
    }


}