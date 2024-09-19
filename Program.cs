namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Funktion för att ta emot input och hantera eventuella format fel!
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

            // Funktion för att se till om int input från användaren ligger inom det godkända ramen!
            static int intErrorInput(int input, int min, int max) 
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
                        input = tryCatch(input, min, max);
                        separator();

                    }
                }
                return input;
            }

            // Funktion för att skriva ut en avgränsare
            static void separator()
            {
                Console.WriteLine("----------------------------------------------------------");
            }

            bool playAgain = true;

            while (playAgain)
            {

                Random random = new Random();
                
                

                Console.WriteLine("🥳🥳🥳 Välkommen! Till gissa talet spelet!🥳🥳🥳");
                separator();
                Console.WriteLine("I denna spel ska du få välja svårighets grad.");
                Console.WriteLine("Du får nu välja svårighetsgrad mellan 1-5.");
                Console.WriteLine("Tänk på att 5 är jättesvårt och 1 är jättenkelt!");
                separator();
                Console.WriteLine("Välj svårighets grad mellan 1 - 5: ");
                int difficulty = 0;
                difficulty = tryCatch(difficulty, 1, 5);
                difficulty = intErrorInput(difficulty, 1, 5);

                int randomNumber = 0;
                int tries = 0;
                int highNr = 0;

                if (difficulty == 5)
                {
                    tries = 3;
                    randomNumber = random.Next(1, 101);
                    highNr = 100;
                }
                else if (difficulty == 4)
                {
                    tries = 4;
                    randomNumber = random.Next(1, 81);
                    highNr = 80;
                }
                else if (difficulty == 3)
                {
                    tries = 5;
                    randomNumber = random.Next(1, 61);
                    highNr = 60;
                }
                else if (difficulty == 2)
                {
                    tries = 6;
                    randomNumber = random.Next(1, 41);
                    highNr = 40;
                }
                else
                {
                    tries = 8;
                    randomNumber = random.Next(1, 21);
                    highNr = 20;
                }


                Console.WriteLine($"Jag tänker på ett nummer mellan 1 - {highNr}.🤔");
                Console.WriteLine($"Kan du gissa vilket? Du får {tries} försök: ");
                int guessednum = 0;
                

                while (guessednum != randomNumber)
                {
                    guessednum = tryCatch(guessednum, 1, highNr);
                    guessednum = intErrorInput(guessednum, 1, highNr);
                    
                    tries--;

                    
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

                    if (tries == 0)
                    {
                        Console.WriteLine("Du har inte lyckats gissa talet med 5 försök😢!");
                        Console.WriteLine("Du förlorar!😵");
                        Console.WriteLine($"Rätt tal var {randomNumber}!");
                        break;
                    }


                }
                Console.WriteLine("Vill du splea igen? ja/nej: ");
                string repeat = Console.ReadLine().ToLower();

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
