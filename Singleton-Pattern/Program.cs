using Singleton_Pattern;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // To demonstrate thread safety
            Parallel.Invoke(
                () => Singleton.GetInstance.PrintMessage("Object 1"),
                () => Singleton.GetInstance.PrintMessage("Object 2")
            );

            Console.ReadLine();
        }
    }
}