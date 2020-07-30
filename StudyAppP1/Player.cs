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
                WriteLine("Please tell me your name:");
                PlayerName = ReadLine();
                File.WriteAllText(PlayerData, PlayerName);
            }
            ReadKey();
            Clear();
            

        }
    }
}
    