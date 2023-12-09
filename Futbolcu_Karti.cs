/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Futbolcu_Karti.cs                                                        */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;
using System.Collections.Generic;

class FootballPlayer
{
    public string Name { get; set; }
    public string Team { get; set; }
    public string Position { get; set; }
    public int Speed { get; set; }
    public int Endurance { get; set; }

    public FootballPlayer(string name, string team, string position, int speed, int endurance)
    {
        Name = name;
        Team = team;
        Position = position;
        Speed = speed;
        Endurance = endurance;
    }

    public void PrintInfo()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("********** Football Player Card **********");
        Console.WriteLine("************************************");
        Console.WriteLine($"Player Name: {Name}");
        Console.WriteLine($"Team: {Team}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Endurance: {Endurance}");
        Console.WriteLine("************************************\n");
    }
}

class FootballCardGame
{
    static void Main()
    {
        List<FootballPlayer> players = new List<FootballPlayer>
        {
            new FootballPlayer("Lionel Messi", "Paris Saint-Germain", "Forward", 90, 80),
            new FootballPlayer("Cristiano Ronaldo", "Manchester United", "Forward", 88, 85),
            new FootballPlayer("Neymar", "Paris Saint-Germain", "Forward", 92, 75),
            new FootballPlayer("Sergio Ramos", "Paris Saint-Germain", "Defender", 78, 88),
            new FootballPlayer("Kevin De Bruyne", "Manchester City", "Midfielder", 86, 82),
            new FootballPlayer("Mohamed Salah", "Liverpool", "Forward", 87, 79),
            new FootballPlayer("Arda Turan", "Galatasaray", "Midfielder", 85, 75),
            new FootballPlayer("Burak Yılmaz", "Beşiktaş", "Forward", 82, 77),
            new FootballPlayer("Hakan Çalhanoğlu", "AC Milan", "Midfielder", 84, 78),
            new FootballPlayer("Merih Demiral", "Atalanta", "Defender", 80, 85),
            new FootballPlayer("Ozan Tufan", "Fenerbahçe", "Midfielder", 79, 81),
            new FootballPlayer("Çağlar Söyüncü", "Leicester City", "Defender", 81, 83)
        };

        Console.WriteLine("Welcome to the Football Card Game!");

        while (true)
        {
            Console.WriteLine("\nPlease choose a card (1-6) or press '0' to exit:");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("You have ended the game. Have a nice day!");
                break;
            }

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 6)
            {
                Random random = new Random();
                FootballPlayer selectedPlayer = players[random.Next(players.Count)];

                Console.Clear(); // Clear the screen
                selectedPlayer.PrintInfo();
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 6 or press '0' to exit.");
            }
        }
    }
}
