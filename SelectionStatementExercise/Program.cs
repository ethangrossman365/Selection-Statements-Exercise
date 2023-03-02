namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 22;
            Console.WriteLine("Try and guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber > 22)
            {
                Console.WriteLine("Too high.");
            }
            else if (favNumber < 22)
            {
                Console.WriteLine("Too low.");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }


        }
    }
}
