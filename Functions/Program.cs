namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUnktion myFunction
            Console.WriteLine("Innan funktionen");
            myFunction();
            myFunction();
            Console.WriteLine("Efter funktionen");

            //Funktion oneOrTwo
            oneOrTwo(1);
            oneOrTwo(2);
            oneOrTwo(3);
        }

        //Funktion för att skriva ut meddelande till Console
        public static void myFunction()
        {
            Console.WriteLine("Inuti en Metod!");
        }

        //Funktion för att ta in en paramenter och avgöra om det är 1 eller 2
        public static void oneOrTwo(int number)
        {
            //If sats för att kontrollera parameter
            if (number == 1)
            {
                Console.WriteLine("Nummret är 1");
            } else if (number == 2)
            {
                Console.WriteLine("Nummret är 2");
            }
        }

    }
}