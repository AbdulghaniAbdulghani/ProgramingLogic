﻿namespace Lab6;

using System;

class Car
{
  public string model;
  public string color;
  public int year;

  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
}

class Program
{
  static void Main()
  {
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display();
    {
      Console.WriteLine("The car is starting.");
    }

    static void Main(string[] args)
    {
      MyMethod();
   static void MyMethod(string fname) 
{
  Console.WriteLine("The car dove 50 miels.");
}
  }
  
}