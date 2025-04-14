namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        int i = 1;
        while (i < 11)
      {
        Console.WriteLine(i);
        i++;
        // Step 2
        for (int i = 1; i <= 20; i++) 
      {
        if (i % 2 == 0)
      }    
    }		Console.WriteLine(i);
        // Step 3
        int number = 5;
      while (number >= 1) 
      {
        Console.WriteLine(number);
        number--;
        // Step 4
        int number;

        do
        {
            Console.Write("Enter a number greater than 100: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                
                if (number > 100)
                {
                    Console.WriteLine("Valid number entered: " + number);
                    break; .
                }
                else
                {
                    Console.WriteLine("Number is not greater than 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (true); 
        // Step 5
        int i = 10;
         while (i <= 1000) 
      {
        Console.WriteLine(i);
        i+= 10;
      }
      // Step 6
      public class TrianglePattern
{
    public static void Main(string[] args)
    {
        int rows = 5; // You can change this to adjust the size of the triangle

        for (int i = 1; i <= rows; i++)
        {
            // Print leading spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Move to the next line
        }
    }
}
    
