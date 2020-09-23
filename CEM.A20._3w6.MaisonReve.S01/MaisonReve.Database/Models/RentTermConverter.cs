
using System;
using System.Collections.Generic;

namespace MaisonReve.Database.Models
{

    public class RentTermConverter : IRentTermConverter
    {

        public Dictionary<RentTerm, decimal> rentDailyBaseFactor = new Dictionary<RentTerm, decimal>(){

        {RentTerm.Daily, 1m},
        {RentTerm.Weekly, (7)},
        {RentTerm.Yearly, (365.25m)},
        {RentTerm.Monthly, (365.25m/12)},

        };


        public Dictionary<RentTerm, decimal> rentFromDailyBaseFactor = new Dictionary<RentTerm, decimal>(){

        {RentTerm.Daily, 1m},
        {RentTerm.Weekly, 1/7},
        {RentTerm.Yearly, 1/365.25m},
        {RentTerm.Monthly, 12/365.25m},

        };




        public int ConvertLeaseLength(int actualLeaseLength, RentTerm previousTerm, RentTerm newTerm)
        {
            var dailyBaseLeaseLength = actualLeaseLength * rentDailyBaseFactor[previousTerm];
            var newLeaseLength = dailyBaseLeaseLength * rentFromDailyBaseFactor[newTerm];
            var result = Convert.ToInt32(Math.Round(newLeaseLength));
            Console.WriteLine(actualLeaseLength + " from " + previousTerm + " to " + newTerm + " = " + result);


            return result;

        }



    }





}



