using System;
using System.Security.Cryptography.X509Certificates;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indicate your gender.\nmale or female");
            string MaleFemale = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hello. What is you name?");
            string Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Nice to meet you {Name}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{Name} do you want a game with a question?");
            string YeasNo = Console.ReadLine();
            Console.Clear();
            
            switch (YeasNo)
            {
                case "yeas":
                    Console.WriteLine("Great, let's start");
                    break;

                case "no":
                    Console.WriteLine($"I'm sorry {Name} but you have no choice.");
                    break;

                default:
                    Console.WriteLine("I wanted to see either yes or no. Although that wouldn't change anything.");
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("I'll ask you four question, be careful.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Which of these countries is landlocked?\n1.Greece 2.Qatar 3.Belgium 4.Somali");
            string QuestionOne = Console.ReadLine();

            switch (QuestionOne)
            {
                case "Belgium":
                    Console.WriteLine("You answered correctly. Not bad.");
                    break;

                default:
                    Console.WriteLine("You wrong.");                    
                    break;
            }

            Console.WriteLine("Which country is bigger?\n1.Italia 2.Egipt 3.Iran 4.Canada");
            string QuestionTwo = Console.ReadLine();

            switch (QuestionTwo)
            {
                case "Canada":
                    Console.WriteLine("The correct answer is great.");
                    break;

                default:
                    Console.WriteLine("You wrong.");
                    break;
            }

            Console.WriteLine("Who was the greatest of the armenian kings?\n1.Tigranes II 2.Smbat III 3.Levon II 4.Arshak I");
            string QuestionTree = Console.ReadLine();

            switch (QuestionTree)
            {
                case "Tigranes II":
                    Console.WriteLine("Correctly answered. Along the way, you're not as stupid as I thought.");
                    break;

                default:
                    Console.WriteLine("You wrong.");
                    break;
            }

            Console.WriteLine("Which these Byzantine imperial dynasties is armenian?\n1.Comnenus 2.Macedonian 3.Angels 4.Justinians");
            string QuestionFore = Console.ReadLine();

            switch (QuestionFore)
            {
                case "Macedonian":
                    Console.WriteLine("Wow, I didn't think you knew about that.");
                    break;

                default:
                    Console.WriteLine("You wrong.");
                    break;
            }

            Console.WriteLine("I have no more questions. You are free.");
            Console.ReadKey();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Green;

            switch (MaleFemale)
            {
                case "male":
                Console.WriteLine($"Good morning mister {MaleFemale}. I am Anna, glad to meet you.");
                    break;

                case "female":
                    Console.WriteLine($"Good morning mis {MaleFemale}. I am Anna, glad to meet you.");
                    break;
            }

            Console.WriteLine("What kind of strange person was talking to you?");
            Console.ReadKey();
            Console.WriteLine("I have never seen him in our bank.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Well, okay, it's not that important.");
            Console.ReadKey();
            Console.WriteLine("I see that you have come to exchange your currency.");
            Console.ReadKey();
            Console.WriteLine("Please follow me, I will show you the current currency code.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Choose currency\n\nEUR USD RUB AMD");
            string Currency = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the amount");
            Console.WriteLine(Currency);
            double money = Convert.ToInt32(Console.ReadLine());


            switch (Currency)
            {
                case "EUR":
                    Console.WriteLine("USD - " + money * 1.19 + "\nRUB - " + money * 87.47 + "\nAMD - " + money * 578.16);
                    break;

                case "USD":
                    Console.WriteLine("EUR - " + money / 1.19 + "\nRUB - " + money * 73.23 + "\nAMD - " + money * 484.30);
                    break;

                case "RUB":
                    Console.WriteLine("EUR - " + money / 87.47 + "\nUSD - " + money / 73.23 + "\nAMD - " + money * 6.61);
                    break;

                case "AMD":
                    Console.WriteLine("EUR - " + money / 578.16 + "\nUSD - " + money / 484.30 + "\nRUB - " + money / 6.61);
                    break;
            }


            Console.ReadKey();
        }       
    }
}
