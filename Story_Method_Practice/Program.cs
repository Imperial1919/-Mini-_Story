using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Story_Method_Practice
{
    class Program
    {

        public static void MyStory()
        {
            bool conditional = true;

            if (conditional) {

                Console.WriteLine("Hello there! I am the Mystory method,I am to ask YOU, the user a few questions\n and then You fill them in, got Me?");
                Console.WriteLine("Let's begin.\n What is your favorite candy Hum- user?");

                string FavoriteCandy = Console.ReadLine();

                Console.WriteLine($"Ah, so you fancy {FavoriteCandy} what a interesting choice indeed.");

                Console.WriteLine("If I may, what is Your Name? Yes I know I perhaps should have asked that in the first place\n But " +
                    "I'm merely curious. So, what is it?");
                string name = Console.ReadLine();

                Console.WriteLine($"Ah, it is a pleasure to meet your aquaintence {name} ! :3");

                Console.WriteLine($"So {name} , Do you happen to have a favorite color?");

                string favcolorquestion = Console.ReadLine().ToLower();

                if (favcolorquestion == "yes")
                {

                    Console.WriteLine($"Oh, I see. Well what is it {name} ?");
                    string favcolor = Console.ReadLine().ToLower();
                    if (favcolor == "red")
                    {
                        Console.WriteLine($"Huh, Small world! Red is My personal favorite color too {name} !");


                    }
                    else if (favcolor == "yellow")
                    {
                        Console.WriteLine($"I mean.. I guess there's some pretty shades of {favcolor}, but I normally just imagine mustard to be honest with ya mate.");
                    }

                    else
                    {
                        Console.WriteLine("Huh, I see.");
                    }





                }

                else
                {
                    Console.WriteLine($"I see. I must say, You must be quite the dull sport {name}");
                }


                Console.WriteLine("Would You Like to continue?");
                string answer = Console.ReadLine().ToLower();

                switch (answer) {
                    case "yes":
                        Console.WriteLine("Wonderful! Let's continue!");
                        break;
                    case "no":
                        Console.WriteLine($"Oh, I see.. well, It was nice talking to You {name} !");
                        conditional = false;
                        break;
                    default:
                        Console.WriteLine(".. Please type in something valid.");
                        break;
                        

                
                }

                Console.WriteLine($"What is your favorite animal {name}?");
                string favanimal = Console.ReadLine().ToLower();
                switch (favanimal)
                {
                    case "animal":
                        Console.WriteLine(".............. You aren't exactly as fast as a jack rabbit are You kid?");
                        break;
                    case "wolf":
                        Console.WriteLine($"Huh, a very interesting choice indeed {name}.");
                        break;
                    case "snake":
                        Console.WriteLine("Ok, just don't expect Me to ever want to meet Your pets, unless it's a ball python or garter snake.");
                        break;

                    default:
                        Console.WriteLine("Ok then.");
                        break;


                }

                Console.WriteLine("One last question, what is Your Favorite genre of music?");
                string reply = Console.ReadLine().ToLower();

                switch (reply)
                {
                    case "idk":
                    Console.WriteLine("Come on! You've gotta have something!");
                        break;

                    case "classical":
                        Console.WriteLine("Ah yes, quite a cultured genre of music {name}, a grand choice!");
                        break;
                    case "rap":
                        Console.WriteLine("... Ew.");
                        break;
                    default:
                        Console.WriteLine("Huh, I see..");
                        break;
                }


                Console.WriteLine($"OH, Look at the time! I must be off, see Ya {name}!");
                conditional = false;



                


        }


        }

        static void Main(string[] args)
        {
            MyStory();

        }
    }
}
