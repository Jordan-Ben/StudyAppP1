using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;

namespace StudyAppP1
{
    public class Player
    {
        public string PlayerName = " ";
        public int PlayerScore = 0;
        string PlayerData = "PlayerData.txt";
    

        public void NamePlayer()
        {
            if (File.Exists(PlayerData))
            {
                PlayerName = File.ReadAllText(PlayerData);
                WriteLine("Welcome Back!" + PlayerName);
            }
            else
            {
                Console.WriteLine("Please tell me your name:");
                PlayerName = Console.ReadLine();
                File.WriteAllText(PlayerData, PlayerName);
            }

            Console.WriteLine("Lets get ready to learn " + PlayerName + " ! ");

        }
    }
}
    