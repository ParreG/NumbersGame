namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            static int tryCatch(int input, int min, int max)
            {
                bool wrong = true;
                while (wrong)
                {
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        wrong = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Ojdå. Det blev ett fel där. välj ett tal mellan {min} och {max}!");
                    }
                }
                return input;
            }
            static int IntErrorInput(int input, int min, int max) //LÄGG IN DETTA I KODEN!!!!
            {
                bool error = true;

                while (error)
                {

                    if (input >= min && input <= max)
                    {
                        error = false;
                    }
                    else
                    {

                        Console.WriteLine($"Ojdå. Vänligen skriv in ett tal mellan {min} och {max}: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        separator();

                    }
                }
                return input;
            }

            static void separator()
            {
                Console.WriteLine("----------------------------------------------------------");
            }
            bool playAgain = true;

            while (playAgain == true)
            {

                Random random = new Random();
                int randomNumber = random.Next(1, 21);

                Console.WriteLine("🥳🥳🥳 Välkommen! Till gissa talet leken!🥳🥳🥳");
                separator();
                Console.WriteLine("Jag tänker på ett nummer mellan 1-20.🤔");
                Console.WriteLine("Kan du gissa vilket? Du får fem försök: ");
                int guessednum = 0;
                int tries = 0;

                while (guessednum != randomNumber)
                {
                    guessednum = tryCatch(guessednum, 1, 20);
                    guessednum = IntErrorInput(guessednum, 1, 20);
                    

                    tries++;

                    
                    if (guessednum > randomNumber)
                    {
                        Console.WriteLine("Oj du gissade för HÖGT!🤯");
                        separator();
                        Console.WriteLine("Gissa igen: ");
                    }                                                      
                    else if (guessednum < randomNumber)
                    {
                        Console.WriteLine("Oj du gissade för LÅGT!🥴");
                        separator();
                        Console.WriteLine("Gissa igen: ");
                    }
                    else
                    {
                        Console.WriteLine($"Du gissade korrekt. Rätt tal är {randomNumber} 🥳");
                        break;
                    }

                    if (tries == 5)
                    {
                        Console.WriteLine("Du har inte lyckats gissa talet med 5 försök😢!");
                        Console.WriteLine("Du förlorar!😵");
                        Console.WriteLine($"Rätt tal var {randomNumber}!");
                        break;
                    }


                }
                Console.WriteLine("Vill du splea igen? ja/nej ");
                string repeat = Console.ReadLine();

                if (repeat == "ja")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Spelet avslutas");
                    separator();
                    Console.WriteLine("Hejdååå!😘");
                    playAgain = false;
                    
                }
            }
            Console.ReadLine();
            






        }
    }
}
