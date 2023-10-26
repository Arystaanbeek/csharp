using System;
using System.Collections.Generic;
using System.Linq;

class SalesForecast
{
    public List<double> SalesData { get; set; }

    public SalesForecast(List<double> salesData)
    {
        SalesData = salesData;
    }

    public double[] PredictSales(int numMonths)
    {
        int n = SalesData.Count;
        if (n < 2)
        {
            Console.WriteLine("Not enough data for forecasting.");
            return null;
        }

        double sumX = Enumerable.Range(1, n).Sum();
        double sumY = SalesData.Sum();
        double sumXY = Enumerable.Range(1, n).Zip(SalesData, (x, y) => x * y).Sum();
        double sumX2 = Enumerable.Range(1, n).Select(x => x * x).Sum();

        double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
        double b = (sumY - a * sumX) / n;

        double[] forecast = new double[numMonths];
        for (int i = 1; i <= numMonths; i++)
        {
            forecast[i - 1] = a * (n + i) + b;
        }

        return forecast;
    }
}

class Program
{
    static void Main()
    {
        List<double> salesData = new List<double> { 120, 130, 140, 150, 160 }; 
        SalesForecast forecast = new SalesForecast(salesData);

        int numMonthsToPredict = 3;
        double[] predictedSales = forecast.PredictSales(numMonthsToPredict);

        if (predictedSales != null)
        {
            for (int i = 0; i < numMonthsToPredict; i++)
            {
                Console.WriteLine($"Sales forecast for month {salesData.Count + i + 1}: {predictedSales[i]}");
            }
        }

        Console.ReadKey();
    }
}
