using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till huvudmenyn! ");
            bool endProgram = true;

            do
            {
                Console.WriteLine("Du har nu följande val: 1, 2, 3 eller 0 för att stänga ner programmet.");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    // Exit program
                    case 0:
                        Console.WriteLine("Programmet stänger ner.");
                        endProgram = false;
                        break;
                    /* In this case we are able to see every price depending on age.
                     And then how many people they are and the total price depending on that peoples ages. */
                    case 1:
                        Console.WriteLine("Tryck in din ålder för att se vilken pris som gäller.");
                        int age = int.Parse(Console.ReadLine());
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

                        Console.WriteLine("Tryck in 1 om du vill planera ett besök, 2 eller 3 för att bli kvar i menyn.");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Tryck in antal personer.");
                            int count = int.Parse(Console.ReadLine());
                            int sum = 0;

                            Console.WriteLine("Tryck in åldrar av alla personer.");
                            for (int i = 0; i < count; i++)
                            {
                                
                                int yourAge = int.Parse(Console.ReadLine());
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

                            break;
                        }
                        if (choice == 2)
                            goto case 2;
                        if (choice == 3)
                            goto case 3;
                        else
                            goto case 0;


                    // Repeat user input 10 times.
                    case 2:
                        Console.WriteLine("Skriv en text till oss. Den ska vi upprepa 10 gånger!");
                        string text = Console.ReadLine();
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write($"{i}. {text}, ");
                           
                        }
                        Console.WriteLine();
                        break;

                    // Split user input by spaces and print the 3th word of that input.
                    case 3:
                        Console.WriteLine("Skriv en mening till oss minst 3 ord. Vi ska returnera 3e ordet i meningen.");
                        string userInput = Console.ReadLine();
                        string[] wordsArray = userInput.Split(" ");
                        if (wordsArray.Length >= 3)
                        { 
                            Console.WriteLine(wordsArray[2]);
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Meningen ska bestå av minst 3 ord!");
                            break;
                        }
                    // Default case to inform about the wrong inputs.
                    default:
                        Console.WriteLine("This is a wrong input.");
                        break;
                }
            } while (endProgram);
        }
    }
}
