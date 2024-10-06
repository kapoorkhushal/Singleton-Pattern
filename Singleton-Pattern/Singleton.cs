namespace Singleton_Pattern
{
    internal sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton? instance = null;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            counter++;
            Console.WriteLine("Inside Singleton class constructor");
            Console.WriteLine($"counter: {counter}");
        }

        public static Singleton GetInstance
        {
            get
            {
                // This is double-checked locking
                if (instance is null)
                {
                    lock (lockObject)
                    {
                        if (instance is null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void PrintMessage(string str)
        {
            Console.WriteLine($"Message: {str}");
        }
    }
}
