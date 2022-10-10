namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Innan funktionen");
            myFunction();
            myFunction();
            Console.WriteLine("Efter funktionen");
        }

        public static void myFunction()
        {
            Console.WriteLine("Inuti en Metod!");
        }

    }
}