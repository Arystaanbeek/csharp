using System;
using System.Collections.Generic;

class UtilityPayments
{
    public double HeatingRate { get; set; } 
    public double WaterRate { get; set; }   
    public double GasRate { get; set; }    
    public double RepairRate { get; set; }  

    public UtilityPayments(double heatingRate, double waterRate, double gasRate, double repairRate)
    {
        HeatingRate = heatingRate;
        WaterRate = waterRate;
        GasRate = gasRate;
        RepairRate = repairRate;
    }

    public void CalculatePayments(int area, int numberOfResidents, bool isWinter, bool hasDiscount)
    {
        string season = isWinter ? "Winter" : "Other";
        double totalPayments = 0;

        List<string> paymentTypes = new List<string> { "Heating", "Water", "Gas", "Repair" };
        foreach (string paymentType in paymentTypes)
        {
            double rate = 0;
            switch (paymentType)
            {
                case "Heating":
                    rate = HeatingRate;
                    if (isWinter) rate *= 1.2; 
                    break;
                case "Water":
                    rate = WaterRate;
                    break;
                case "Gas":
                    rate = GasRate;
                    break;
                case "Repair":
                    rate = RepairRate;
                    break;
            }

            double payment = area * rate;
            if (paymentType == "Heating" || paymentType == "Water")
                payment *= numberOfResidents;

            if (hasDiscount)
            {
                if (paymentType == "Heating") payment *= 0.7; 
                if (paymentType == "Water") payment *= 0.5; 
            }

            totalPayments += payment;
            Console.WriteLine($"Payment Type: {paymentType}, Charged: {payment:C}, Discount: {(hasDiscount ? "Yes" : "No")}");
        }

        Console.WriteLine($"Total Payment: {totalPayments:C}");
    }
}

class Task2
{
    static void Main()
    {
        double heatingRate = 1.0;
        double waterRate = 0.5;
        double gasRate = 0.7;
        double repairRate = 0.2;

        UtilityPayments utilityPayments = new UtilityPayments(heatingRate, waterRate, gasRate, repairRate);

        Console.Write("Enter the area (m^2): ");
        int area = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of residents: ");
        int numberOfResidents = int.Parse(Console.ReadLine());

        Console.Write("Is it winter (Y/N): ");
        bool isWinter = Console.ReadLine().Trim().ToUpper() == "Y";

        Console.Write("Is there a discount (Y/N): ");
        bool hasDiscount = Console.ReadLine().Trim().ToUpper() == "Y";

        utilityPayments.CalculatePayments(area, numberOfResidents, isWinter, hasDiscount);
    }
}
