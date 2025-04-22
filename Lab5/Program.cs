namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        string Season = spring 
        string Season = summer 
        string season = fall 
        string season = winter 
    }
        {
            // Step 2
            
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            Console.Write("Enter a number from 1 to 7: ");
            
             string input = Console.ReadLine();

             if (int.TryParse(input, out int number) && number >= 1 && number <= 7)
             {
                Console.WriteLine($"The day for {number} is: {days[number - 1]}");
             }
             else
             {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
             }
             {
                // Step 3
                public string forfattareEfternamn;
                public string forfattareFornamn;
                public string bokensTittle;
                public int lanseringsDatum;

                public string BokensTittle
                 {
                    get { return bokensTittle; }
                    set { bokensTittle = value; }
                }
                     public string ForfattareFornamn
                {
                    get {return forfattareFornamn;}
                    set {forfattareFornamn = value;}
                }

                    public string ForfattareEfternamn
                {
                    get {return forfattareEfternamn;}
                    set {forfattareEfternamn = value;;}
                }

                    public int LanseringsDatum
                {
                    get { return lanseringsDatum; }
                    set { lanseringsDatum = value; }
             }

                    public override string ToString()
    {
                 Return string.Format("{0}, {1}, {2}, {3} ", forfattareEfternamn, ForfattareFornamn, bokensTittle, lanseringsDatum);
                  {
                    // Step 4 
                     int[] temperatures = { 65, 72, 78, 70, 68 };

                    Array.Sort(temperatures);
                    
                    Console.WriteLine("Sorted Temperatures:");
                    foreach (int temp in temperatures)
                    {
                        Console.WriteLine(temp);
                    }
                    
                    Console.WriteLine("\nHighest Temperature: " + temperatures[temperatures.Length - 1]);
                    Console.WriteLine("Lowest Temperature: " + temperatures[0]);
                  }

    }
        }
          
}