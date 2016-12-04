<Query Kind="Program" />

void Main()
{

            int carpim=1;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    carpim = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, carpim);
                }
                Console.WriteLine("............");
            }
            
        
}

// Define other methods and classes here
