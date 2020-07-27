using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;
namespace StudyAppP1
{
    public class Game
    {
            Player player = new Player();

            List<Question> Questions = new List<Question>
            {
            new Question("Byte", " A whole number value between 0 and 255"),
            new Question("Boolean", "A true or false value") ,
            new Question("String", "A array of char values"),
            new Question("Concatenation"," using pluse opperator to combine strings and values") ,
            new Question("Void", "Return value of nothing")

            };
            public Game()
            {
                Console.WriteLine("Hello,\nI guess its time to study!");
                player.NamePlayer();
                foreach (Question term in Questions)
                {
                    ForegroundColor = ConsoleColor.DarkCyan;
                    Write(term.QuestionTerm + ": ");
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    Write(term.QuestionAnswer + " \n");
                    ResetColor();
                    WriteLine("Did I get the definition right? Please enter Y or N ");
                    string input = ReadLine();
                    if (input.ToUpper() == "Y")
                    {
                        player.PlayerScore++;
                        ForegroundColor = ConsoleColor.Green;
                    WriteLine("Correct!");
                    ResetColor();
                    WriteLine("Your score is now " + player.PlayerScore);
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("Opps. Try Again");

                    }
                    ResetColor();
                    WriteLine("Press Enter to recive your next question");
                    ReadKey();
                    Clear();

                }

                WriteLine("Congratulations " + player.PlayerName + "! You have compleated this study session. \nYour score is " + player.PlayerScore);
                ReadKey();
            }

        }

    }

