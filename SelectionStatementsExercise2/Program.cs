namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favorite school subject: ");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "math":
                    Console.WriteLine("Math is fun!");
                    break;
                case "science":
                    Console.WriteLine("Are you Bill Nye the Science Guy??");
                    break;
                case "english":
                    Console.WriteLine("Get those creative juices flowing!");
                    break;
                case "gym":
                    Console.WriteLine("We got an athlete in the making!");
                    break;
                case "history":
                    Console.WriteLine("Hindsight 2020!");
                    break;
                default:
                    Console.WriteLine("Le wrong selection...");
                    break;
            }
        }
    }
}