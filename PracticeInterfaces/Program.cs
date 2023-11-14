﻿using System;

public interface IMobilePhone
{
    public void Sell(double offer);
    public void Buy(double offer);

    public void PrintReceipt();
}

public class Samsung : IMobilePhone
{
    public void Sell(double offer)
    {
        Console.WriteLine("The selling price for Samsung S23 is $890.");
        if (offer >= 100)
        {
            Console.WriteLine("Sold!");
        }
        else
        {
            Console.WriteLine("Offer not accepted.");
        }
    }
    public void Buy(double offer)
    {
        Console.WriteLine("The purchase price for Samsung S23 is $1500.");
        if ((offer >= 200))

        {
            Console.WriteLine("Purchased successfully!");
        }
        else
        {
            Console.WriteLine("Offer not accepted.");
        }
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Samsung S23 was bought successfully."); 
    }
}

public class Huawei :  IMobilePhone
{
    public void Sell(double offer)
    {
        Console.WriteLine("The selling price for Huawei 60 Pro is $660.");
        if (offer >= 100)
        {
            Console.WriteLine("Sold!");
        }
        else
        {
            Console.WriteLine("Offer not accepted.");
        }
    }
    public void Buy(double offer)
    {
        Console.WriteLine("The purchase price for Huawei 60 Pro is $1900.");
        if (offer >= 200)
        {
            Console.WriteLine("Purchased!")
        }
        else
        {
            Console.WriteLine("Offer not accepted.");
        }

    }

    public void PrintReceipt()
    {
        Console.WriteLine("Huawei 60 Pro was bought successfully.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Samsung device1 = new Samsung();
        Console.Write("Enter th offer for selling Samsung S23: ");
        double sellOffer1 = Convert.ToDouble(Console.ReadLine());
        device1.Sell(sellOffer1);
       
        device1.PrintReceipt();

        Huawei device2 = new Huawei();
        Console.WriteLine("Enter the offer for selling Huawei 60 Pro: ");
        double sellOffer2 = Convert.ToDouble(Console.ReadLine());
        device2.Sell(sellOffer2);
        device2.PrintReceipt();

        Console.WriteLine();

        Console.Write("Enter the offer for buying Samsung S23: ");
        double buyOffer1 = Convert.ToDouble(Console.ReadLine());
        device1.Buy(buyOffer1);

        Console.Write("Enter offer for buying Huawei 60 Pro: ");
        double buyOffer2 = Convert.ToDouble(Console.ReadLine());
        device2.Buy(buyOffer2);

        Console.ReadLine();
    }
}
