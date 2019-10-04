/*
  Progam name:  Life Insurance Application
  Version:   1.1.1
  #Description:  Life insurance policy that calculates sales's person's commissin based on each sales as well all an summary for the total system with extended functionalities
  Dependencies:  N/A
  Database file: N/A
  Change History:   Since: 30 September, 2019
 */

using LifeInsuranceApp.BusinessModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceApp.Utility
{

       /*
       Class name:  SalesPersonUtility
       Version:   1.1.1
       #Description:  This is a utility class for model class SalesPerson which provides all the utility functions for the application to be running and sepration logic layer from UI
       Dependencies:  N/A
       Database file: N/A
       Change History:   Since: 30 September, 2019
       */
    class SalesPersonUtility
    {

        /*
          Method name: DetermineCommissionAndRate()
          Version:   1.1.1
          #Description:  This method determine commission and based on rate
          Inputs:   Parameters- aSalesPerson
          Outputs: N/A
          Return value: N/A
          Change History:   20190930 By Md Ahsanul Hoque
         */
        public static void DetermineCommissionAndRate(SalesPerson aSalesPerson)
        {
            if (aSalesPerson.InsuranceAmount < 1000 && aSalesPerson.InsuranceAmount >= 0)
            {
                CalcCommissionEarned(SalesPerson.RATE_1, aSalesPerson);
                aSalesPerson.Rate = SalesPerson.RATE_1;
            }
            else if (aSalesPerson.InsuranceAmount >= 1000 && aSalesPerson.InsuranceAmount < 100000)
            {
                CalcCommissionEarned(SalesPerson.RATE_2, aSalesPerson);
                aSalesPerson.Rate = SalesPerson.RATE_2;
            }
            else
            {
                CalcCommissionEarned(SalesPerson.RATE_3, aSalesPerson);
                aSalesPerson.Rate = SalesPerson.RATE_3;
            }
        }

        /*
          Method name: AddOrUpdateToSalesPersonRepo
          Version:   1.1.1
          #Description:  This method add or update SalesPerson info on the repo
          Inputs:   Parameters- aSalesPerson, salesPersonRepo
          Outputs: N/A
          Return value: N/A
          Change History:   20190930 By Md Ahsanul Hoque
         */
        public static void AddOrUpdateToSalesPersonRepo(SalesPerson aSalesPerson, List<SalesPerson> salesPersonRepo)
        {
            aSalesPerson.IndividualTotalCommissionEarned = aSalesPerson.IndividualCommissionEarnedPerSales;
            aSalesPerson.IndividualTotalSales = aSalesPerson.InsuranceAmount;

            //If sales person is an existing element then update the info to the repo otherwise just Add
            if (IsSalesPersonFound(aSalesPerson, salesPersonRepo))
            {
                var itemToBeUpdated = salesPersonRepo.First(x=> x.FirstName == aSalesPerson.FirstName && x.LastName == aSalesPerson.LastName);

                itemToBeUpdated.IndividualTotalCommissionEarned += aSalesPerson.IndividualCommissionEarnedPerSales;
                itemToBeUpdated.IndividualTotalSales += aSalesPerson.InsuranceAmount;

                salesPersonRepo[salesPersonRepo.IndexOf(itemToBeUpdated)] = itemToBeUpdated;

            }
            else
            {
                salesPersonRepo.Add(aSalesPerson);
            }
        }


        /*
         Method name: CalcCommissionEarned
         Version:   1.1.1
         #Description:  This method check whether a sales person does exists in the repo
         Inputs:   Parameters- aSalesPerson, salesPersonRepo
         Outputs: bool
         Return value: flag
         Change History:   20190930 By Md Ahsanul Hoque
        */
        private static void CalcCommissionEarned(double rate, SalesPerson aSalesPerson)
        {
            aSalesPerson.IndividualCommissionEarnedPerSales = aSalesPerson.InsuranceAmount * aSalesPerson.GetCommissionRate(rate);
        }

        public static bool IsSalesPersonFound(SalesPerson aSalesPerson, List<SalesPerson> salesPersonRepo)
        {
            bool flag = false;

            foreach (var item in salesPersonRepo)
            {
                if (item.FirstName == aSalesPerson.FirstName && item.LastName == aSalesPerson.LastName)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        /*
        Method name: IsEmpty
        Version:   1.1.1
        #Description:  This method check whether a string value is empty or not
        Inputs:   Parameters- input
        Outputs: bool
        Return value: bool
        Change History:   20190930 By Md Ahsanul Hoque
        */
        public static bool IsEmpty(string input)
        {
            return input == "" ? true : false;
        }
    }
}
