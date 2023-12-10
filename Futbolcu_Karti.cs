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
    public bool IsTurkish { get; set; }
    public double Salary { get; set; }

    public FootballPlayer(string name, string team, string position, int speed, int endurance, bool isTurkish, double salary)
    {
        Name = name;
        Team = team;
        Position = position;
        Speed = speed;
        Endurance = endurance;
        IsTurkish = isTurkish;
        Salary = salary;
    }

    public void PrintInfo()
    {
        string nationality = IsTurkish ? "Turkish" : "Foreign";

        Console.WriteLine("************************************");
        Console.WriteLine("********** Football Player Card **********");
        Console.WriteLine("************************************");
        Console.WriteLine($"Player Name: {Name}");
        Console.WriteLine($"Nationality: {nationality}");
        Console.WriteLine($"Team: {Team}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Endurance: {Endurance}");
        Console.WriteLine($"Salary: ${Salary:N2} million per year");
        Console.WriteLine("************************************\n");
    }
}

class FootballCardGame
{
    static void Main()
    {
        List<FootballPlayer> turkishPlayers = new List<FootballPlayer>
        {
            new FootballPlayer("Arda Turan", "Galatasaray", "Midfielder", 85, 75, true, 3.5),
            new FootballPlayer("Burak Yılmaz", "Beşiktaş", "Forward", 82, 77, true, 4.2),
            new FootballPlayer("Hakan Çalhanoğlu", "AC Milan", "Midfielder", 84, 78, true, 5.8),
            new FootballPlayer("Merih Demiral", "Atalanta", "Defender", 80, 85, true, 4.9),
            new FootballPlayer("Ozan Tufan", "Fenerbahçe", "Midfielder", 79, 81, true, 2.5),
            new FootballPlayer("Çağlar Söyüncü", "Leicester City", "Defender", 81, 83, true, 6.3)
        };

        List<FootballPlayer> foreignPlayers = new List<FootballPlayer>
        {
            new FootballPlayer("Lionel Messi", "Paris Saint-Germain", "Forward", 90, 80, false, 80),
            new FootballPlayer("Cristiano Ronaldo", "Manchester United", "Forward", 88, 85, false, 60),
            new FootballPlayer("Neymar", "Paris Saint-Germain", "Forward", 92, 75, false, 70),
            new FootballPlayer("Sergio Ramos", "Paris Saint-Germain", "Defender", 78, 88, false, 40),
            new FootballPlayer("Kevin De Bruyne", "Manchester City", "Midfielder", 86, 82, false, 65),
            new FootballPlayer("Mohamed Salah", "Liverpool", "Forward", 87, 79, false, 50)
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
                Console.Clear(); // Clear the screen

                if (choice % 2 == 1)
                {
                    PrintOneTurkishOneForeign(turkishPlayers, foreignPlayers);
                }
                else
                {
                    PrintOneTurkishOneForeign(foreignPlayers, turkishPlayers);
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 6 or press '0' to exit.");
            }
        }
    }

    static void PrintOneTurkishOneForeign(List<FootballPlayer> turkishPlayers, List<FootballPlayer> foreignPlayers)
    {
        Random random = new Random();

        FootballPlayer turkishPlayer = turkishPlayers[random.Next(turkishPlayers.Count)];
        FootballPlayer foreignPlayer = foreignPlayers[random.Next(foreignPlayers.Count)];

        turkishPlayer.PrintInfo();
        foreignPlayer.PrintInfo();
    }
}
