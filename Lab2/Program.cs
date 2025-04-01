using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Step 1
        int myNum = 10;               
        double myDoubleNum = 10.99D;  
        char myLetter = 'P';         
        bool myBool = true;          
        string myText = "Greetings";     
        Console.WriteLine(myNum);
        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText); 
        // Step 2
        double myDouble = 9.78;
        int myInt = (int) myDouble;    

        Console.WriteLine(myDouble);   
        Console.WriteLine(myInt);      
        // Step 3
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
        // Step 4
        int num1 = 100;  
        int num2 = 50;
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        // Step 5
        
        
        
        
      





    }

}
