/*using System;

class task11
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (IsLuckyTicket(input))
        {
            Console.WriteLine("lucky ticket");
        }
        else
        {
            Console.WriteLine("unlucky ticket ");
        }
        Console.ReadKey();
    }

    static bool IsLuckyTicket(string ticketNumber)
    {
        if (ticketNumber.Length != 6)
        {
            return false;
        }

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < 3; i++)
        {
            sum1 += int.Parse(ticketNumber[i].ToString());
        }

        for (int i = 3; i < 6; i++)
        {
            sum2 += int.Parse(ticketNumber[i].ToString());
        }

        return sum1 == sum2;
    }
}
*/