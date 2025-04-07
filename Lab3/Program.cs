namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    // Step 1
    int a = 10;
    int b = 5;
    int c = 15;
    Console.WriteLine(a > b);
    Console.Writeline(a < c);
    Console.WriteLine(a > b && a > c);
    // Step 2
    bool isRaining = true;
    bool haveUmbrella = false;
    
    if (isRaining >= haveUmbrella);
    {
    Console.WriteLine("take an umbrella!");
    }
    else
    {
    Console.WriteLine("You're good to go!")
    }
    // Step 3
    
    // Step 4
    int day = 7;
    switch (day) 
    {
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
    }
