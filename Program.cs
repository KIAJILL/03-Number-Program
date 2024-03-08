namespace _03_Number_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your number");

            int number;
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Your number is 0");
            }
            if (number <0)
            {
                Console.WriteLine("Your number is negative");
            }
            if (number > 0)
            {
                Console.WriteLine("Your number is positive");

            }
        }
    }
}
