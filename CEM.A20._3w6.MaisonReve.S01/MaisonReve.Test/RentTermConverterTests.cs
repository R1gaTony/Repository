using MaisonReve.Database.Models;
using Xunit;

namespace MaisonReve.Test
{
    public class RentTermConverterTests
    {

        IRentTermConverter converter = new RentTermConverter();
        public RentTermConverterTests()
        {
            
        }

        [Fact()]
        public void ConvertLeaseLength_MoisEnAnnee(){
            //Arrange 
            var actualLeaseLength = 12;
            var previousLeaseTerm = RentTerm.Monthly;
            var newLeaseTerm = RentTerm.Yearly;
            var expected = 1;
            
            //Act
            var real = converter.ConvertLeaseLength(actualLeaseLength,previousLeaseTerm,newLeaseTerm);

            //Assert
            Assert.Equal(real,expected);
        }

    }
}