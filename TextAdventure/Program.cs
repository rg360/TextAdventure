using System;
using System.Threading;

namespace TextAdventure
{
    class Program
    {
        static void Typewriter(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(30);
            }

        }

        static void Enjoying(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(300);
            }

        }
        static void Main(string[] args)
        {

            var person = new WhoYou();
            var heightLimit = 5;
            string val;

            Start:
            Console.Clear();

            Typewriter("Hello World and welcome to the park.\n");
            Typewriter("");
            Thread.Sleep(2000);
            Typewriter("We have a lot of available rides in the park.\n");
            Console.WriteLine();

            Typewriter("Let's start\n");
            Typewriter("What's your first name and your last name?\n");
            string fullName = Console.ReadLine();
            var names = fullName.Split(' ');
            person.FirstName = names[0];
            person.LastName = names[1];

            Console.WriteLine();
            Typewriter($"Hello {person.FirstName} {person.LastName}\n");

            Console.WriteLine();
            Typewriter("How old are you?\n");
            person.Age = Convert.ToInt32(Console.ReadLine());

            if (person.Age <= 8)
            {
                Typewriter("You have to be accompanied by an adult. Come back when with your birth certificate next time. ");
            }
            else
            {

                Instructions.Rides();
                Thread.Sleep(2000);

                Typewriter("Ready? press any key...\n");
                Console.ReadKey(true);
                Typewriter("\nType HELP to view the guide or type FUN or LEAVE\n");

                val = Console.ReadLine();

                switch (val.ToLower())
                {
                    case "help":
                        Typewriter("Sorry, I dont have any money to give...press any key\n");
                        Console.ReadKey(true);
                        Instructions.Rides();
                        Thread.Sleep(2000);
                        goto Start;

                    case "fun":

                        string val2;

                        //Ferris Wheel substring
                        string substr1 = "ferris";
                        string substr2 = "wheel";
                        string quit = "leave";

                        //Merry-Go-Round substring
                        string substr3 = "merry";
                        string substr4 = "go";
                        string substr5 = "round";

                        //Bumper Boats substring
                        string substr6 = "bumper";
                        string substr7 = "boat";

                        //Roller Coaster substring
                        string substr8 = "roller";
                        string substr9 = "coaster";

                        //Drop Tower substring
                        string substr10 = "drop";
                        string substr11 = "tower";

                        Typewriter("What ride would you like to try?\n");
                        Instructions.Rides();

                        val2 = Console.ReadLine();
                        string response = val2.ToLower();

                        //Teacup ride
                        if (response == "teacup")
                        {
                            Typewriter("Ahh... Teacup Ride\n");
                            Thread.Sleep(2000);
                            Enjoying("blop blop blop");

                            Console.Clear();
                            Thread.Sleep(1500);
                            Typewriter("Wanna try another ride?\n");
                            Typewriter("type YES or NO\n");
                            var again = Console.ReadLine();

                            if (again == "yes")
                            {
                                goto case "fun";
                            }
                            else break;
                        }
                        //Ferris Wheel ride condition
                        else if (response.Contains(substr1) || response.Contains(substr2))
                        {

                            Typewriter("Oooo.... dare devil\n");
                            Typewriter("Need to check your height first\n");
                            Typewriter("How tall are you in feet?\n");
                            double height = Convert.ToDouble(Console.ReadLine());

                            do
                            {

                                if (height >= heightLimit)
                                {
                                    Typewriter("That will be $2.\n");
                                    Typewriter("Show me the money");
                                    double fare = Convert.ToDouble(Console.ReadLine());

                                    if (fare >= 2)
                                    {
                                        Typewriter("You get to ride\n");

                                        Typewriter("Woohoo! Hop on and have fun!\n");
                                        Console.WriteLine();
                                        Enjoying("weeeeeee\n");
                                        break;
                                    }
                                    else
                                    {
                                        Typewriter("You don't have enough for 1 ride\n");
                                        goto case "fun";
                                    }
                                    
                                }
                                else
                                {
                                    Typewriter("Sorry little guy...\n");
                                    Typewriter("Lets try something else.\n");
                                    Console.WriteLine();
                                    break;
                                }
                            } while (true);
                            Console.Clear();
                            Thread.Sleep(1500);
                            Typewriter("Wanna try another ride?\n");
                            Typewriter("type YES or NO\n");
                            var again = Console.ReadLine();

                            if (again == "yes")
                            {
                                goto case "fun";
                            }
                            else break;
                        }
                        //Merry-Go-Round ride condition
                        else if (response.Contains(substr3) || response.Contains(substr4) || response.Contains(substr5))
                        {
                            Typewriter("Merry-Go-Round\n");
                            Typewriter("Afraid you will throw up?\n");
                            Enjoying("zzzzzzzzzzzzzz");
                            Console.Clear();
                            Thread.Sleep(1500);
                            Typewriter("Wanna try another ride?\n");
                            Typewriter("type YES or NO\n");
                            var again = Console.ReadLine();
                            Console.Clear();
                            if (again == "yes")
                            {
                                goto case "fun";
                            }
                            else break;

                        }
                        //Bumper Boats ride condition
                        else if (response.Contains(substr6) || response.Contains(substr7))
                        {
                            Typewriter("Bumper Boats?\n");
                            Typewriter("Need a life vest?\n");
                            Enjoying("mmmmmmmmmmmmmm");
                            Console.Clear();
                            Thread.Sleep(1500);
                            Typewriter("Wanna try another ride?\n");
                            Typewriter("type YES or NO\n");
                            var again = Console.ReadLine();

                            if (again == "yes")
                            {
                                goto case "fun";
                            }
                            else break;
                        }
                        //Roller Coaster ride condition
                        else if (response.Contains(substr8) || response.Contains(substr9))
                        {
                            Typewriter("Wow! Roller Coaster");
                            Typewriter("Need to check your height first");
                            Typewriter("How tall are you in feet?\n");
                            double height = Convert.ToDouble(Console.ReadLine());

                            do
                            {
                                if (height >= heightLimit)
                                {
                                    Typewriter("Woohoo! Hop on and have fun!\n");
                                    Console.WriteLine();
                                    Enjoying("weeeeeee");
                                    break;
                                }
                                else
                                {
                                    Typewriter("Sorry little guy...\n");
                                    Typewriter("Lets try something else.\n");
                                    Console.WriteLine();
                                    break;
                                }
                            } while (true);
                            Console.Clear();
                            Thread.Sleep(1500);
                            Typewriter("Wanna try another ride?\n");
                            Typewriter("type YES or NO\n");
                            var again = Console.ReadLine();

                            if (again == "yes")
                            {
                                goto case "fun";
                            }
                            else break;
                        }
                        //Drop Tower ride condition
                        else if (response.Contains(substr10) || response.Contains(substr11))
                        {
                            Typewriter("Drop tower... awesome!\n");
                            Typewriter("Need to check your height first\n");
                            Typewriter("How tall are you in feet?\n");
                            double height = Convert.ToDouble(Console.ReadLine());

                            do
                            {
                                if (height >= heightLimit)
                                {
                                    Typewriter("Fasten your seatbelt and hold on tight!\n");
                                    Console.WriteLine();
                                    Enjoying("waaaaahhhhhhhh");
                                    break;
                                }
                                else
                                {
                                    Typewriter("Sorry little guy...\n");
                                    Typewriter("Lets try something else.\n");
                                    Console.WriteLine();
                                    break;
                                }
                            } while (true);
                            Console.Clear();
                            Thread.Sleep(1500);
                            Typewriter("Wanna try another ride?\n");
                            Typewriter("type YES or NO\n");
                            var againDrop = Console.ReadLine();

                            if (againDrop == "yes")
                            {
                                goto case "fun";
                            }
                            else break;
                        }
                        else if (response == "help")
                        {
                            goto case "help";
                        }
                        else if (response == "leave")
                        {
                            Typewriter("Good idea, just leave and go home.");
                            break;
                        }
                        else
                        {
                            Typewriter("Sorry, I don't have that option\n");
                            Typewriter("Here's a list of available rides.\n");
                            Instructions.Rides();
                            Thread.Sleep(1500);
                            goto Start;
                        }

                    case "leave":

                        Typewriter("No money huh?!\n");

                        return;

                    default:
                        Typewriter("default");
                        goto Start;
                }
            }

        }

    }
}
