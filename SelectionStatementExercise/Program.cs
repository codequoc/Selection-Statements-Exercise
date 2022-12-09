namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var userinput = int.Parse(Console.ReadLine());

            if (userinput < favNumber)
            {
                Console.WriteLine("too low");
            } 
            else if (userinput > favNumber)
            {
                Console.WriteLine("too high");
            } 
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
