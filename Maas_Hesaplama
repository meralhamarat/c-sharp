/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Maas_Hesaplama.cs                                                        */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("╔══════════════════════════════════════════════════╗");
        Console.WriteLine("║              Employee Salary Calculator          ║");
        Console.WriteLine("╚══════════════════════════════════════════════════╝");
        Console.ResetColor();

        // Get basic information
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your surname: ");
        string surname = Console.ReadLine();

        // Get position hourly wage
        Console.Write("Enter your position's hourly wage: ");
        double hourlyWage = Convert.ToDouble(Console.ReadLine());

        // Get total overtime hours for the month
        Console.Write("Enter the total overtime hours for the month: ");
        double totalOvertimeHours = Convert.ToDouble(Console.ReadLine());

        // Calculate total salary
        double totalSalary = CalculateTotalSalary(hourlyWage, totalOvertimeHours);

        // Display the results
        Console.WriteLine("\nCalculated Information:");
        Console.WriteLine($"Name Surname: {name} {surname}");
        Console.WriteLine($"Hourly Wage: {hourlyWage:C}");
        Console.WriteLine($"Total Overtime Hours: {totalOvertimeHours}");
        Console.WriteLine($"Total Salary: {totalSalary:C}");
    }

    static double CalculateTotalSalary(double hourlyWage, double totalOvertimeHours)
    {
        const double OVERTIME_MULTIPLIER = 1.5; // Overtime pay multiplier
        const double STANDARD_WEEKLY_HOURS = 40; // Standard weekly working hours
        const double WEEKS_IN_A_MONTH = 4.33; // Average number of weeks in a month

        double overtimePay = totalOvertimeHours * hourlyWage * OVERTIME_MULTIPLIER;
        double totalSalary = (hourlyWage * STANDARD_WEEKLY_HOURS + overtimePay) * WEEKS_IN_A_MONTH;

        return totalSalary;
    }
}
