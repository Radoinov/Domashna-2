namespace Domashna_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { -3, 5, 1, 9, -12, 4, 6, -2, 0 };
            ReplaceWithZero(numbers);
            Console.WriteLine("Smqna na otricatelni chisla s 0:");
            Print(numbers);            
            int sumOfPositives = SumOfPositives(numbers);
            Console.WriteLine($"Suma na polojitelnite chisla: {sumOfPositives}");            
            MinMaxDif(numbers);
        }

        
        static void ReplaceWithZero(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list[i] = 0;
                }
            }
        }
        static int SumOfPositives(List<int> list)
        {
            int sum = 0;
            foreach (int number in list)
            {
                if (number > 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        
        static void MinMaxDif(List<int> list)
        {
            int maxValue = list.Max();
            int minValue = list.Min();
            int difference = maxValue - minValue;

            Console.WriteLine($"Max Value = {maxValue}, Min Value = {minValue}");
            Console.WriteLine($"Razlika mejdu maksimalnata i minimalnata stoinost: {difference}");
        }

        
        static void Print(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
    

