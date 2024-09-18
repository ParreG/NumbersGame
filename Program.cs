namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            void avgränsare()
            {
                Console.WriteLine("----------------------------------------------------------");
            }
            bool playAgain = true;

            while (playAgain == true)
            {

                Random random = new Random();
                int randomNumber = random.Next(1, 21);

                Console.WriteLine("🥳🥳🥳 Välkommen! Till gissa talet leken!🥳🥳🥳");
                avgränsare();
                Console.WriteLine("Jag tänker på ett nummer mellan 1-20.🤔");
                Console.WriteLine("Kan du gissa vilket? Du får fem försök: ");
                int guessednum = 0;
                int tries = 1;

                while (guessednum != randomNumber)
                {
                    guessednum = Convert.ToInt32(Console.ReadLine());

                    if (tries == 5)
                    {
                        Console.WriteLine("Du har inte lyckats gissa talet med 5 försök😢!");
                        Console.WriteLine("Du förlorar!😵");
                        Console.WriteLine($"Rätt tal var {randomNumber}!");
                        break;
                    }
                    else if (guessednum > randomNumber)
                    {
                        Console.WriteLine("Oj du gissade för HÖGT!🤯");
                        avgränsare();
                        Console.WriteLine("Gissa igen: ");
                    }                                                       //////// OM JAG SVARAR RÄTT PÅ 5e försöket så räknas inte det!!!
                    else if (guessednum < randomNumber)
                    {
                        Console.WriteLine("Oj du gissade för LÅGT!🥴");
                        avgränsare();
                        Console.WriteLine("Gissa igen: ");
                    }
                    else
                    {
                        Console.WriteLine($"Du gissade korrekt. Rätt tal är {randomNumber} 🥳");
                        break;
                    }
                    tries++;

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
                    avgränsare();
                    Console.WriteLine("Hejdååå!😘");
                    playAgain = false;
                    
                }
            }
            Console.ReadLine();
            






        }
    }
}
