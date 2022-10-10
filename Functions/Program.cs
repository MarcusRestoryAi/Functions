namespace Functions
{
    internal class Program
    {
        private static string globName = "";

        static void Main(string[] args)
        {
            //FUnktion myFunction
            Console.WriteLine("Innan funktionen");
            myFunction();
            myFunction();
            Console.WriteLine("Efter funktionen");
            globName += "Marcus";

            //Funktion oneOrTwo
            oneOrTwo(1);
            oneOrTwo(2);
            oneOrTwo(3);

            //Funktion sayHey
            string name = "Anders";
            string message = sayHey(name);

            Console.WriteLine(message);

            /*
            //Försöker anropa variabel CarColor
            car();
            string description = "Min bil har färgen " + carColor;
            */

            Console.WriteLine(globName);

            //Anropar metoden add() för att summera 2 tal
            int summa = add(5, 7);
            Console.WriteLine("Summan är {0}", summa);

            //summa = add(45, -365);
            Console.WriteLine("Summan är {0}", add(45, -365));

            //Använda ett returvärde som variabel
            Console.WriteLine( sayHey("Jonathan") );

            //Anroppar biggestNumber 2 ggr, och använder värdet som parameter
            summa = biggestNumber(34, biggestNumber(23, 35) );
            Console.WriteLine("Största nummret är {0}", summa);

            Console.WriteLine("Summan av inget är {0}", add() );
            Console.WriteLine("Summan av 5 är {0}", add(5) );
            Console.WriteLine("Summan av 5 och 6 är {0}", add(5, 6) );
        }

        //Funktion för att skriva ut meddelande till Console
        public static void myFunction()
        {
            Console.WriteLine("Inuti en Metod!");
            globName += "Hej";
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

        //Funktion sayHey som skall returnera ett hälsningsmeddelande
        public static string sayHey(string name)
        {
            //Returnera ett hälsningsmeddelande
            return "Hejsan " + name;
        }

        public static void car()
        {
            string carColor = "Röd";
        }

        //Funktion add som tar in 2 parametrar och returnerar summa
        public static int add(int tal1 = 0, int tal2 = 0)
        {
            return tal1 + tal2;
        }

        //Funktion biggestNumber, returnerar det största nummret
        public static int biggestNumber(int tal1, int tal2)
        {
            //Jämnför tal1 och tal2, returnerar det största talet
            if (tal1 > tal2) return tal1;
            else return tal2;
        }

        //Funktion biggestNumber, returnerar parametern
        public static int biggestNumber(int tal1)
        {
            return tal1;
        }

        //Funktion biggestNumber, returnerar parametern
        public static string biggestNumber(string tal1)
        {
            return tal1;
        }
    }
}