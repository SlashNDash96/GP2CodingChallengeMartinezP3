using System;
using System.ComponentModel;
class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Coding Challenge program! There will be a variety of different functions you will \nhave to choose from. Please pick one by entering the corresponding number.");

        Console.WriteLine("1: SUM - Add two numbers");
        Console.WriteLine("2: Convert minutes to seconds");
        Console.WriteLine("3: Add one to a number");
        Console.WriteLine("4: Calculate power using voltage and current");
        Console.WriteLine("5: Calculate age in days");
        Console.WriteLine("6: Calculate the area of a triangle");
        Console.WriteLine("7: Check if a number is less than or equal to zero");
        Console.WriteLine("8: Check if the sum of two numbers is less than 100");
        Console.WriteLine("9: Check if two numbers are equal");
        Console.WriteLine("10: Give me something");
        Console.WriteLine("0: Exit");

        while (true)
        {
            Console.WriteLine("\nEnter your choice (0 to exit):");
            var choice = Console.ReadLine();

            if (choice == "0")
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    PerformSum();
                    break;
                case "2":
                    ConvertMinutesToSeconds();
                    break;
                case "3":
                    AddOne();
                    break;
                case "4":
                    CalculatePower();
                    break;
                case "5":
                    CalculateAge();
                    break;
                case "6":
                    CalculateTriangleArea();
                    break;
                case "7":
                    CheckLessThanOrEqualToZero();
                    break;
                case "8":
                    CheckLessThanOneHundred();
                    break;
                case "9":
                    CheckNumbersEqualTo();
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose a valid function.");
                    break;
            }
        }
    }

    static void PerformSum()
    {
        Console.WriteLine("Please put two numbers for us to add.");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The sum of {number1} and {number2} is: {Sum(number1, number2)}");
    }

    static void ConvertMinutesToSeconds()
    {
        Console.WriteLine("Give me a number to convert from minutes to seconds:");
        int minutes = int.Parse(Console.ReadLine());
        Console.WriteLine($"{minutes} minutes converted to seconds is: {Convert(minutes)} seconds");
    }

    static void AddOne()
    {
        Console.WriteLine("Please insert a number to add 1 to:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"{number} plus one is: {PlusOne(number)}");
    }

    static void CalculatePower()
    {
        Console.WriteLine("Please enter the voltage:");
        int voltage = int.Parse(Console.ReadLine());
        Console.WriteLine("Now insert the current:");
        int current = int.Parse(Console.ReadLine());
        Console.WriteLine($"The power of {voltage} and {current} is equal to: {CircuitPower(voltage, current)}");
    }

    static void CalculateAge()
    {
        Console.WriteLine("Please enter an age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"You are {CalcAge(age)} days old.");
    }

    static void CalculateTriangleArea()
    {
        Console.WriteLine("Enter the height of the triangle:");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the base of the triangle:");
        float baseLength = float.Parse(Console.ReadLine());
        Console.WriteLine($"The area of the triangle is: {TriAge(height, baseLength)}");
    }

    static void CheckLessThanOrEqualToZero()
    {
        Console.WriteLine("Please input a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"The number entered is less than or equal to zero: {LessThanOrEqualToZero(number)}");
    }

    static void CheckLessThanOneHundred()
    {
        Console.WriteLine("Please input the first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the second number:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The sum of the numbers entered is less than 100: {LessThanOneHundred(number1, number2)}");
    }

    static void CheckNumbersEqualTo()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Now insert the second number:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The numbers entered are equal: {NumbersEqualTo(number1, number2)}");
    }

    public static int Sum(int number1, int number2) => number1 + number2;
    public static int Convert(int number) => number * 60;
    public static int PlusOne(int number) => number + 1;
    public static int CircuitPower(int voltage, int current) => voltage * current;
    public static int CalcAge(int years) => years * 365;
    public static float TriAge(float height, float baseLength) => (height * baseLength) / 2;
    public static bool LessThanOrEqualToZero(int number) => number <= 0;
    public static bool LessThanOneHundred(int number1, int number2) => (number1 + number2) < 100;
    public static bool NumbersEqualTo(int number1, int number2) => number1 == number2;

}
