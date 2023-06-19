using System;

internal class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Input amount of guarding posts:");
        int N = Convert.ToInt32(Console.ReadLine());
        while (N > 100 || N < 1)
        {
            Console.WriteLine("The input is wrong! Try again.");
            N = Convert.ToInt32(Console.ReadLine());
        }
        int[] walls = new int[N];
        int longestWall = 0;
        int temporaryWall = 0;
        longestWall = ReadData(walls, N, longestWall, temporaryWall);

        OutRes(longestWall);
        Console.WriteLine();
    }
    public static int ReadData(int[] walls, int N, int longestWall, int temporaryWall)
    {
        Console.WriteLine("Input the value for post 1:");
        walls[0] = Convert.ToInt32(Console.ReadLine());
        while (walls[0] < 0 || walls[0] > 1)
        {
            Console.WriteLine("The input is wrong! Try again.");
            walls[0] = Convert.ToInt32(Console.ReadLine());
        }



        for (int i = 1; i < N; i++)
        {
            Console.WriteLine($"Input the valufe for post {i+1}");
            walls[i] = Convert.ToInt32(Console.ReadLine());
            while (walls[i] < 0 || walls[i] > 1)
            {
                Console.WriteLine("The input is wrong! Try again.");
                walls[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (walls[i] + walls[i - 1] != 2)
            {
                temporaryWall++;
            }
            else
            {
                if (longestWall <= temporaryWall)
                {
                    longestWall = temporaryWall;
                    temporaryWall = 0;
                }
                else
                {
                    temporaryWall = 0;
                }
            }
        }
        if (temporaryWall != 0 && longestWall == 0 || longestWall < temporaryWall)
            longestWall = temporaryWall;

        return longestWall;
    }
    public static void OutRes(int longest) 
    {
        Console.WriteLine("The longest wall section without protected walls:");
        Console.WriteLine(longest);
    }
}