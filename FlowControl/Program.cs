using System;
using System.Collections.Generic;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till huvudmenyn! ");

            do
            {
                Console.WriteLine("Du har nu följande val: 1, 2, 3, 4 eller 0 för att stänga ner programmet.");
                UserInput();

            } while (true);
        }

        private static void UserInput()
        {

            string input = Console.ReadLine();
            switch (input)
            {
                // Exit program
                case "0":
                    Environment.Exit(0);
                    break;

                //In this case we are able to see every price depending on age.
                case "1":
                    PrintPriceForAge();
                    break;

                // And then how many people they are and the total price depending on that peoples ages.
                case "2":
                    CalculateTotalPrice();
                    break;

                // Repeat user input 10 times.
                case "3":
                    RepeatTenTimes();
                    break;

                // Split user input by spaces and print the 3th word of that input.
                case "4":
                    PrintThirdWord();
                    break;

                // Default case to inform about the wrong inputs.
                default:
                    Console.WriteLine("Det här är en felaktig input. ");
                    break;
            }
        }

        private static void PrintThirdWord()
        {
            Console.WriteLine("Skriv en mening till oss minst 3 ord. Vi ska returnera 3e ordet i meningen.");
            bool moreThanThree = false;

            do
            {
                string userInput = Console.ReadLine();
                userInput.Trim();
                string[] wordsArray = userInput.Split(" ");
                List<string> noSpace = new List<string>();
                foreach (var item in wordsArray)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        noSpace.Add(item);
                    }
                }
                if (noSpace.Count >= 3)
                {
                    Console.WriteLine(noSpace[2]);
                    moreThanThree = true;
                }
                else
                {
                    Console.WriteLine("Meningen ska bestå av minst 3 ord!");

                }

            } while (!moreThanThree);

        }

        private static void RepeatTenTimes()
        {
            Console.WriteLine("Skriv en text till oss. Den ska vi upprepa 10 gånger!");
            string text;

            do { text = Console.ReadLine(); } while (string.IsNullOrEmpty(text));

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. {text}, ");

            }
            Console.WriteLine();

        }

        private static void PrintPriceForAge()
        {
            Console.WriteLine("Tryck in din ålder för att se vilken pris som gäller.");
            int age = AskForInt();
            if (age <= 5 || age >= 100)
            {
                Console.WriteLine("Pris: 0kr");
            }
            else
            {
                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else
                {
                    if (age > 64)
                    {
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120kr");
                    }
                }
            }
        }

        private static void CalculateTotalPrice()
        {
            Console.WriteLine("Tryck in antal personer.");
            int count = AskForInt();
            int sum = 0;

            Console.WriteLine("Tryck in åldrar av alla personer.");
            for (int i = 0; i < count; i++)
            {

                int yourAge = AskForInt();
                if (yourAge < 20)
                {
                    sum += 80;
                }
                else
                {
                    if (yourAge > 64)
                    {
                        sum += 90;
                    }
                    else
                        sum += 120;
                }
            }
            Console.WriteLine($"Antal personer: {count}");
            Console.WriteLine($"Total costnad: {sum}");

        }

        private static int AskForInt()
        {
            bool isInt = false;
            int answer;
            do
            {
                string userCount = Console.ReadLine();
                isInt = int.TryParse(userCount, out answer) && answer > 0;

            } while (!isInt);

            return answer;
        }
    }
}
