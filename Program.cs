using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Patient Clinical Details Project ===");

        // Create a patient and set properties
        Patient p = new Patient();
        p.FirstName = "John";
        p.LastName = "Doe";
        p.Weight = 72.0;   // kg
        p.Height = 180.0;  // cm

        Console.WriteLine($"\nPatient: {p.FirstName} {p.LastName}");

        // Sample blood pressure - change values to test different outputs
        p.CheckBloodPressure(135, 88);

        // Calculate and show BMI
        p.CalculateBMI();

        Console.WriteLine("\nProgram finished. Press Enter to exit.");
        Console.ReadLine();
    }
}
