// See https://aka.ms/new-console-template for more information
using System;

    class Program
    {
    static void Main()
      {
        Beverage beverage1 = new Decaf();
        beverage1 = Milk(beverage1);
        Console.WriteLine($"Название:{beverage1.Name()} \n Цена:{beverage1.Cost()} ");
        Beverage beverage2 = new DarkRoast();
        beverage2 = Mocha(beverage2);
        beverage2 = Whip(beverage2);
        Console.WriteLine($"Название:{beverage2.Name()} \n Цена:{beverage2.Cost()} ");
        Beverage beverage3 = new HouseBlend();
        beverage3 = Soya(beverage3);бб0б
        beverage3 = Mocha(beverage3);
        beverage3 = Milk(beverage3);
        Console.WriteLine($"Название:{beverage3.Name()} \n Цена:{beverage3.Cost()} ");
    }

     }
