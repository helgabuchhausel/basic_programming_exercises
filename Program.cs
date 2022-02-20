using System;

namespace all
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my C# projects through my first year of programming");
            Console.WriteLine("1. Currency exchange");
            Console.WriteLine("Choose one number from 1 to 18\nType X to quit");
            bool notWantToQuit = true;
            do
            {
                Console.Write("Your choice: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        HelloWorld();
                        break;
                    case "2":
                        CurrencyExchange();
                        break;
                    case "3":
                        FunSentence();
                        break;
                    case "4":
                        BasicMath();
                        break;
                    case "5":
                        Ratio();
                        break;
                    case "6":
                        Loops();
                        break;
                    case "7":
                        WeightInSpace();
                        break;
                    case "8":
                        Avrage();
                        break;
                    case "9":
                        ArmstrongNumber();
                        break;
                    case "10":
                        DNA();
                        break;
                    case "11":
                        multipliers();
                        break;
                    case "12":
                        Euler();
                        break;
                    case "13":
                        ComplexProgram();
                        break;
                    case "14":
                        pizzaMachine();
                        break;
                    case "15":
                        dunnonoo3();
                        break;
                    case "16":
                        showNaturalNumber();
                        break;
                    case "17":
                        SytemInfos();
                        break;
                    case "18":
                        ResistanceCalculator();
                        break;
                    case "X":
                        notWantToQuit = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("----------------------------------------------------------------------");
            }
            while (notWantToQuit);



            Console.ReadKey();

        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void CurrencyExchange()
        {
            double euro, dollar, exchangeRate;

            exchangeRate = 1.1750;

            Console.WriteLine("How much euro do you want to exchange? ");
            euro = Convert.ToDouble(Console.ReadLine());
            dollar = euro * exchangeRate;

            Console.WriteLine($"{euro} euro is {dollar} dollar ");

        }

        static void FunSentence()
        {
            string color;
            string food;
            string car;
            string movie;

            Console.WriteLine("What is your favorite color");
            color = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            food = Console.ReadLine();

            Console.WriteLine("What is your favorite car?");
            car = Console.ReadLine();

            Console.WriteLine("What is your favorite movie?");
            movie = Console.ReadLine();

            Console.WriteLine("Your favorite color is " + movie + ".You like to eat " + car + ".Your favorite car is " + food + ".Your favortie movie is " + color + ".");

        }

        static void BasicMath()
        {
            double g1, g2, g3, g4;


            g1 = (-1) + 4 * 6;

            g2 = (35 + 5) % 7;

            g3 = 14 + (-4) * 6 / 11;

            g4 = 2 + 15 / 6 * 1 - 7 % 2;


            Console.WriteLine(g1 + ", " + g2 + ", " + g3 + ", " + g4);
        }


        static void Ratio()
        {
            double kills, deaths, ratio;

            kills = 34;

            deaths = 50;

            ratio = kills / deaths;

            Console.WriteLine($"{kills} kills \n{deaths} deaths \n{ratio} ratio ");

            Console.WriteLine(ratio);
        }

        static void Loops()
        {
            int number, solution, v;

            number = 411;

            for (v = 1; v <= 10; v++)
            {
                solution = number * v;
                Console.WriteLine(v + " x " + number + " = " + solution);
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void WeightInSpace()
        {

            double m = 0.38, v = 0.91, ma = 0.38, j = 2.34, s = 1.06, u = 0.92, n = 1.19, p = 0.06;

            // planets
            string p1 = "Mercurius", p2 = "Venus", p3 = "Mars", p4 = "Jupiter", p5 = "Saturnus", p6 = "Uranus", p7 = "Neptunus", p8 = "Pluto";

            //weight on earth
            double goa = 54;

            //weight on earth  = goa, weight on venus = gov... 
            double gom = goa * m, gov = goa * v, goma = goa * ma, goj = goa * j, gos = goa * s, gon = goa * u, gop = goa * n;

            string a = "Your weight is  ";
            Console.WriteLine(a + p1 + " " + gom + "kg ");
            Console.WriteLine(a + p2 + " " + gov + "kg ");
            Console.WriteLine(a + p3 + " " + goma + "kg ");
            Console.WriteLine(a + p4 + " " + goj + "kg ");
            Console.WriteLine(a + p5 + " " + gos + "kg ");
            Console.WriteLine(a + p6 + " " + gon + "kg ");
            Console.WriteLine(a + p7 + " " + gop + "kg ");

        }

        static void Avrage()
        {
            int a, b, c, avr;

            a = 20;
            b = 40;
            c = 80;

            avr = (a + b + c) / 3;

            Console.WriteLine(avr);
        }

        static void ArmstrongNumber()
        {

            int sum = 0;

            Console.WriteLine("Geef een getal in:");
            string g = Console.ReadLine();

            //lengte van de getal
            int length = g.Length;

            int number = Convert.ToInt32(g);

            int divider = Convert.ToInt32(Math.Pow(10, length));


            for (int i = 0; i < length; i++)
            {

                int result = number / divider;


                number = number - (result * divider);
                divider /= 10;


                int calculation = (int)Math.Pow(result, length - i);


                sum += calculation;

            }

            if (number == sum) Console.WriteLine("It is an Armstrong number");
            else Console.WriteLine("Not an Armstrong number");
        }


        static void DNA()
        {

            string rna;
            Console.WriteLine("DNA-string: ");
            string dna = Convert.ToString(Console.ReadLine());

            switch (dna)
            {
                case "G":
                    rna = "C";
                    break;
                case "C":
                    rna = "G";
                    break;
                case "T":
                    rna = "A";
                    break;
                case "A":
                    rna = "U";
                    break;
            }
        }

        static void multipliers()
        {

            int x = 1;
            int y = 1;
            int z = 10;
            int result = 0;

            for (x = 1; x <= z; x++)
            {

                for (int i = 1; i <= z; i++)
                {
                    result = x * i;
                    Console.WriteLine($"{x}*{i}={result}");
                }

                Console.WriteLine("");
            }
        }

        static void Euler()
        {
            int max = 1000;
            int som = 0;

            Console.Write("De veelvouden van 3 of 5 tussen 0 en 1000: ");
            for (int i = 0; i <= max; i++)
            {
                int delenDoorDrie = i % 3;
                int delenDoorVijf = i % 5;
                if (delenDoorDrie == 0 || delenDoorVijf == 0)
                {
                    Console.Write($"{i}\t");
                    som += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"De som is {som}");
        }

        static void ComplexProgram()
        {
            //menu 
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Rekenmachine");
            Console.WriteLine("2.Password tester");
            Console.WriteLine("3.Recyclage");
            Console.WriteLine("4.Computersolver");
            int keuze = Convert.ToInt32(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    Console.WriteLine("Geef een getal:");
                    double g1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Geef een andere getal:");
                    double g2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Maak een keuze (+-*/)");
                    string keuze2 = Console.ReadLine();
                    double oplossing = 0;

                    switch (keuze2)
                    {
                        case "+":
                            oplossing = g1 + g2;
                            break;
                        case "-":
                            oplossing = g1 - g2;
                            break;
                        case "*":
                            oplossing = g1 * g2;
                            break;
                        case "/":
                            oplossing = g1 / g2;
                            break;
                        default:
                            Console.WriteLine("Verkeerde keuze");
                            break;
                    }

                    if (oplossing < 0) Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"De oplossing is {oplossing}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.WriteLine("Wat is uw password?");
                    string password = Console.ReadLine();
                    if (password == "TrumpSux")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Toegelaten");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Verboden");
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("Hello ");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write("World");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("!");
                    break;
                case 4:
                    Console.WriteLine("Does the computer turn on?");
                    string antwoord1 = Console.ReadLine();
                    if (antwoord1 == "ja")
                    {
                        Console.WriteLine("Is there any error messages?");
                        string antwoord2 = Console.ReadLine();
                        if (antwoord2 == "ja") Console.WriteLine("Perform a search for the error message");
                        else Console.WriteLine("Computer is fine");
                    }
                    else
                    {
                        Console.WriteLine("Is the computer power light on?");
                        string antwoord3 = Console.ReadLine();
                        if (antwoord3 == "ja") Console.WriteLine("Turn the computer monitor on");
                        else Console.WriteLine("Check the computer power cord");
                    }
                    break;
                default:
                    Console.WriteLine("Verkeerde keuze");
                    break;
            }
        }

        static void pizzaMachine()
        {
            double pizzaPrice = 0;
            double transportCost = 0;
            int pizzaBase;
            int chefextra = 0;
            int topping;


            Console.WriteLine("Pizza factory");

            // pizza base
            Console.WriteLine("Choose your pizza base:");
            Console.WriteLine("1.Cheesy crust");
            Console.WriteLine("2.Martian meal");
            Console.WriteLine("3.Pegasus");
            Console.WriteLine("Pizza base:");

            do
            {
                pizzaBase = Convert.ToInt32(Console.ReadLine());

                switch (pizzaBase)
                {
                    case 1:
                        pizzaPrice += 5;
                        break;
                    case 2:
                        Console.WriteLine("How old are you?");
                        int jaar = Convert.ToInt32(Console.ReadLine());
                        if (jaar <= 54)
                        {
                            Console.WriteLine("Martian meal is not for children under 54 ");
                            break;
                        }
                        pizzaPrice += 2.8;
                        break;
                    case 3:
                        pizzaPrice += 12.4;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            } while (!(pizzaBase <= 3));


            //Toppings
            Console.WriteLine("Possible toppings:");
            Console.WriteLine("1.Endrail pies");
            Console.WriteLine("2.Italian Cheese");
            Console.WriteLine("3.Geen");

            Console.WriteLine("Topping:");

            do
            {
                topping = Convert.ToInt32(Console.ReadLine());
                switch (topping)
                {
                    case 1:
                        if (pizzaBase == 1)
                            pizzaPrice += 10;
                        else if (pizzaBase == 2 || pizzaBase == 3)
                            pizzaPrice += 15;
                        else break;
                        break;
                    case 2:
                        pizzaPrice += 5.5;
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (!(topping <= 3));

            //Chef extra option
            if (topping == 3)
            {
                Console.WriteLine("Chefs extra (1=yes/2=no)");
                chefextra = Convert.ToInt32(Console.ReadLine());
                if (chefextra == 1)
                    pizzaPrice += 1;

            }

            //Distance
            Console.WriteLine("Address in light years");
            Console.WriteLine("It has to be between 1 and 100 ");

            int lightYears = Convert.ToInt32(Console.ReadLine());
            if (lightYears < 1 || lightYears > 100)
            {
                Console.Write("Invalid value");
            }

            //Calculation

            if (lightYears < 10)
                transportCost += 10;
            else
                transportCost += Math.Sqrt(lightYears / pizzaPrice) + pizzaPrice;

            if (chefextra == 1) pizzaPrice -= 0.10 * transportCost;


            //Random promotion 
            Random rnd = new Random();
            int rk = rnd.Next(0, 51);
            double randomkorting = (double)rk;
            pizzaPrice -= pizzaPrice * (randomkorting / 100);


            //Bill
            switch (pizzaBase)
            {
                case 1:
                    Console.WriteLine("Cheesy crust \t\t 5 IC");
                    break;
                case 2:
                    Console.WriteLine("Martian meal \t\t 2.8 IC");
                    break;
                case 3:
                    Console.WriteLine("Pegasus lime \t\t 12.4 IC");
                    break;
            }

            switch (topping)
            {
                case 1:
                    Console.WriteLine("Endrail pies \t\t 10 IC");
                    break;
                case 2:
                    Console.WriteLine("Endrail pies \t\t 15 IC");
                    break;
                case 3:
                    Console.WriteLine("Italian cheese \t\t 5.5 IC");
                    break;
                case 4:
                    Console.WriteLine("Zonder topping \t\t 0 IC");
                    break;
            }

            if (chefextra == 1)
                Console.WriteLine("Chefs extra /t/t 1 IC");

            Console.WriteLine();

            Console.WriteLine("- - - - - - - - - - - - - - -");
            Console.WriteLine($"Totaal pizza \t\t {pizzaPrice} IC{Environment.NewLine}");
            Console.WriteLine($"Distance \t\t {lightYears} IC ");
            Console.WriteLine($"Transportcosts: \t\t {transportCost} IC");
            Console.WriteLine("- - - - - - - - - - - - - - -");
            Console.WriteLine($"TOTAAL \t\t {pizzaPrice}");
        }


        static void dunnonoo3()
        {

            Console.WriteLine("Maxmimum waarde: ");
            int max = Convert.ToInt32(Console.ReadLine());

            string sterretje = "*";

            for (int i = 1; i <= max; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = max; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static void showNaturalNumber()
        {
            // Toon alle natuurlijke getallen van 1 tot n.
            Console.WriteLine("Geef een maximaal getal");
            uint n = Convert.ToUInt32(Console.ReadLine());
            for (uint i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.Write("\n\n");
            // Toon alle natuurlijke getallen van n tot 1.

            // Toon alle even getallen tussen 1 en 100.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
            Console.Write("\n\n");

            // Toon alle oneven getallen tussen 1 en 100.
            for (int i = 1; i <= 100; i++)
            {
                if (!(i % 2 == 0)) Console.WriteLine(i);
            }
            Console.Write("\n\n");


            // Toon de som van alle getallen van 1 tot n(dus 1 + 2 + 3 + 4 +...+ n).


            // Toon de som van alle even getallen van 1 tot n.

            // Toon de som van alle oneven getallen van 1 tot n.

            // Schrijf een programma dat het aantal digits in een getal telt(het getal 12348 heeft bijvoorbeeld 5 digits).

            // (PRO) Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd drie en twintig.

            // Schrijf een programma dat alle ascii karakters en hun waarde toont van 10 tot n(tip: char c = Convert.ToChar(65); zal hoofdletter A tonen) 

            // Toon het alfabet van a tot z.

            // Schrijf een programma dat de macht van een getal toont. De gebruiker voor eerst het getal in, gevolgd door de macht(bv 2 en 4 zal als resultaat 16 geven(2 tot de 4e)).

            // Schrijf een programma een getal n ontbindt in factoren.Factoren zijn de getallen waardoor je n kan delen zonder rest(van  bijvoorbeeld het getal 100 zijn de factoren 1, 2, 4, 5, 10, 20, 25, 50, 100).

            // Schrijf een programma dat controleert of een getal priem is of niet.

            // Toon ale priemgetallen van 1 tot n.

            // Toon de reeks van Fibonacci tot n termen.
        }


        static void SytemInfos()
        {
            bool is64bit = Environment.Is64BitOperatingSystem;
            string pcname = Environment.MachineName;
            int proccount = Environment.ProcessorCount;
            string username = Environment.UserName;
            long memory = Environment.WorkingSet;
            bool userinteractive = Environment.UserInteractive;
            int tickcount = Environment.TickCount;
            int systempagesize = Environment.SystemPageSize;


            // long cdriveinbytes = DriveInfo.GetDrives()[0].AvailableFreeSpace;



            Console.WriteLine($"systempagesize: {systempagesize}");
            Console.WriteLine($"tickcount: {tickcount}");
            Console.WriteLine($"userinteractive: {userinteractive}");
            Console.WriteLine($"processorcount: {proccount}");
            Console.WriteLine($"memory: {memory}");
            Console.WriteLine($"username:{username}");
            Console.WriteLine($"pcname:{pcname}");
            Console.WriteLine($"is64bit:{is64bit}");

            Console.WriteLine("Geef het nummer van de harde schijf waarover meer informatie wilt: ");
            int invoer = Convert.ToInt32(Console.ReadLine());
            // long totalsize = DriveInfo.GetDrives()[invoer].TotalSize;



        }

        static void ResistanceCalculator()
        {
            Console.WriteLine("ring1: ");
            int ring1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ring2: ");
            int ring2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ring3: ");
            int ring3 = Convert.ToInt32(Console.ReadLine());


            double weerstand = (ring1 * 10 + ring2) * Math.Pow(10, ring3);

            Console.WriteLine($"\nweerstand: {weerstand} Ohm");






            Console.WriteLine("╔═════════════════════╦═══════════════════╗");
            Console.WriteLine("║ring1        ║ ring2 ║ring3 ║ Totaal(Ohm)║");
            Console.WriteLine("╟─────────────────────╫───────────────────╢");
            Console.WriteLine($"║{ring1} ║ {ring2}    ║{ring3} ║{weerstand} ║");
            Console.WriteLine("╚═════════════════════╩═══════════════════╝");




        }





    }



}
