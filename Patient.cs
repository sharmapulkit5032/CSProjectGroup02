using System;

public class Patient
{
    // Public properties (PascalCase)
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; }  // kilograms
    public double Height { get; set; }  // centimetres

    // CheckBloodPressure: uses systolic and diastolic values and prints classification
    public void CheckBloodPressure(int systolic, int diastolic)
    {
        Console.WriteLine($"\nBlood Pressure Reading: {systolic}/{diastolic} mmHg");

        if (systolic < 120 && diastolic < 80)
            Console.WriteLine("Status: Normal");
        else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            Console.WriteLine("Status: Elevated");
        else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
            Console.WriteLine("Status: High Blood Pressure (Stage 1)");
        else if (systolic >= 140 || diastolic >= 90)
            Console.WriteLine("Status: High Blood Pressure (Stage 2)");
        else
            Console.WriteLine("Status: Hypertensive Crisis");
    }

    // CalculateBMI: uses Height (cm) and Weight (kg), prints BMI and status
    public void CalculateBMI()
    {
        if (Height <= 0)
        {
            Console.WriteLine("\nHeight must be greater than zero to calculate BMI.");
            return;
        }

        double heightInMeters = Height / 100.0; // convert cm to meters
        double bmi = Weight / (heightInMeters * heightInMeters);

        Console.WriteLine($"\nBMI = {bmi:F2} kg/m^2");

        if (bmi < 18.5)
            Console.WriteLine("BMI Status: Underweight");
        else if (bmi >= 18.5 && bmi < 24.9)
            Console.WriteLine("BMI Status: Normal Weight");
        else if (bmi >= 25 && bmi < 29.9)
            Console.WriteLine("BMI Status: Overweight");
        else
            Console.WriteLine("BMI Status: Obese");
    }
}
