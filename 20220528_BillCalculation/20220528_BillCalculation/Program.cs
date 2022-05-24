using System;

namespace _20220528_BillCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Telephone = 250;
            double Internet = 2629.00;
            double EvoCharji = 0.00;
            double TV = 0;
            double ValueAddedServices = 375.00;
            double Discount = 250.0;
            double Adjustment = 0;

            double TotalServiceCharges = Telephone + Internet + EvoCharji + TV + ValueAddedServices - Discount + Adjustment;

            double Arears = 4.0;
            double Credit = -5.0;

            // Service Tax is 19.5%
            double ServiceTax = TotalServiceCharges * 19.5 / 100;

            // WHTax is 12.5%
            double WHTax = TotalServiceCharges * 12.5 / 100;
            double LatePaySurcharge = 0;

            double GrandTotal = TotalServiceCharges + Arears + Credit + ServiceTax + WHTax + LatePaySurcharge;

            String CustomerName = "Kamran Qadir";
            String BillingMonth = "May 2022";

            Console.WriteLine("*************************************");
            Console.WriteLine("\tCustomer: " + CustomerName);
            Console.WriteLine("\tBilling Month: " + BillingMonth);
            Console.WriteLine("\tGrand Total: " + GrandTotal);
            Console.WriteLine("*************************************");

            Console.ReadKey();
        }
    }
}
