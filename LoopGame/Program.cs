using System;

namespace LoopGame
{
    class Program
    {


        public static bool GameScreen(int lives)
        {
            if(lives == 0)
            {
                Console.WriteLine("GameOver");
            }
            else
            {
                Console.WriteLine("You won!");
            }
            Console.WriteLine("Would you like to play again? \n" +
                "yes \n" +
                "no");
            var answer = Console.ReadLine();

            if(answer.ToLower() == "yes")
            {
                return true;
            }
                return false;
            

            
        }

        public static bool livesCheck(int lives)
        {
            if (lives == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Level complete!");
                Console.WriteLine($"You have {lives} many lives left");

                return true;
            }
        }


        static void Main(string[] args)
        {
            bool startGame = true;

            while (startGame)
            {
                var lives = 5;

                while (lives > 0)
                {
                    Console.WriteLine("Hello welcome to my game!");
                    do
                    {
                        Console.WriteLine("Guess my favorite color?");

                        var answer = Console.ReadLine();

                        if (answer.ToLower() != "green")
                        {
                            Console.WriteLine("Wrong!");
                            lives -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            break;
                        }

                    } while (lives > 0);


                    if (livesCheck(lives) == false)
                    {
                        break;
                    }


                    Console.WriteLine("Would you like to open the left door or the right?");
                    string doorChoice;
                    do
                    {
                        doorChoice = Console.ReadLine();
                        if (doorChoice.ToLower() == "left")
                        {
                            Console.WriteLine("Ok");
                        }
                        else if (doorChoice.ToLower() == "right")
                        {
                            Console.WriteLine("Ok");
                        }
                        else
                        {
                            Console.WriteLine("Ooops. You lost a life. please enter left or right");
                            lives -= 1;
                        }
                    } while (lives > 0);

                    if (livesCheck(lives) == false)
                    {
                        break;
                    }
                }

                startGame = GameScreen(lives);
            }
           


        }
    }
    
}
