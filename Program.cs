namespace assignment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " | ");
                }
                Console.WriteLine();
            }




        }





        

    }
}
