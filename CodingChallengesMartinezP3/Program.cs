using System;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Coding Challenge program! There will be a variety of different functions you will \nhave to choose from. Please pick one by entering the corresponding number.");
        Console.WriteLine("1: Sum - Add two numbers");
        Console.WriteLine("2: Convert minutes to seconds");
        Console.WriteLine("3: Add one to a number");
        Console.WriteLine("4: Calculate power using voltage and current");
        Console.WriteLine("5: Calculate age in days");
        Console.WriteLine("6: Calculate the area of a triangle");
        Console.WriteLine("7: Check if a number is less than or equal to zero");
        Console.WriteLine("8: Check if the sum of two numbers is less than 100");
        Console.WriteLine("9: Check if two numbers are equal");
        Console.WriteLine("10: Give me something");
        Console.WriteLine("11: Reverse a boolean value");
        Console.WriteLine("12: Convert hours to seconds");
        Console.WriteLine("13: Return the sum of a polygon");
        Console.WriteLine("14: Return a phrase with Edabit");
        Console.WriteLine("15: Logical AND of two booleans");
        Console.WriteLine("16: Calculate and Return basketball points");
        Console.WriteLine("17: Calculate perimeter of a rectangle");
        Console.WriteLine("18: Greet with a name");
        Console.WriteLine("19: Count animal legs");
        Console.WriteLine("20: Calculate football team points");
        Console.WriteLine("21: Input a number to receive the corresponding month");
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
                case "10":
                    GiveMeSomething();
                    break;
                case "11":
                    ReverseBooleanExample();
                    break;
                case "12":
                    ConvertHoursToSeconds();
                    break;
                case "13":
                    SumPolygon();
                    break;
                case "14":
                    ConcatenateNameWithEdabit();
                    break;
                case "15":
                    LogicalAndExample();
                    break;
                case "16":
                    CalculateBasketballPoints();
                    break;
                case "17":
                    CalculateRectanglePerimeter();
                    break;
                case "18":
                    GreetWithName();
                    break;
                case "19":
                    CountAnimalLegs();
                    break;
                case "20":
                    CalculateFootballPoints(); 
                    break;
                case "21":
                    NumberstoMonths();
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose a valid function.");
                    break;
            }
        }
    }

    static void NumberstoMonths()
    {
        Console.WriteLine("Please enter a number between 1 and 12:");
        int num = int.Parse(Console.ReadLine());

        if (num < 1 || num > 12)
        {
            Console.WriteLine("Invalid number. Please enter a number between 1 and 12.");
        }
        else
        {
            string monthName = GetMonthName(num);
            Console.WriteLine($"The month corresponding to number {num} is: {monthName}");
        }
    }

    static string GetMonthName(int num)
    {
        // Array of month names where index 0 = January, 1 = February, etc.
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[num - 1];  // Adjust for 0-based index
    }

    static void CalculateFootballPoints()
    {
        Console.WriteLine("Please enter the number of wins:");
        int wins = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of draws:");
        int draws = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of losses:");
        int losses = int.Parse(Console.ReadLine());

        int totalPoints = FootballPoints(wins, draws, losses);
        Console.WriteLine($"The total points for the team is: {totalPoints}");
    }

  
    static int FootballPoints(int wins, int draws, int losses)
    {
        return (wins * 3) + (draws * 1) + (losses * 0);
    }

    static void CountAnimalLegs()
    {
        Console.WriteLine("Please enter the number of chickens:");
        int chickens = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of cows:");
        int cows = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of pigs:");
        int pigs = int.Parse(Console.ReadLine());

        int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
        Console.WriteLine($"The total number of legs is: {totalLegs}");
    }


    
    static void GreetWithName()
    {
        Console.WriteLine("Please enter a name to greet:");
        string name = Console.ReadLine();
        Console.WriteLine(HelloName(name));
    }

    static string HelloName(string name)
    {
        return $"Hello {name}!";
    }

    static void CalculateRectanglePerimeter()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        int width = int.Parse(Console.ReadLine());

        int perimeter = 2 * (length + width);
        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
    }

    static void CalculateBasketballPoints()
    {
        Console.WriteLine("Please enter the number of 2-pointers scored:");
        int twoPointers = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of 3-pointers scored:");
        int threePointers = int.Parse(Console.ReadLine());

        Console.WriteLine($"The total points scored is: {Points(twoPointers, threePointers)}");
    }

    static int Points(int twoPointers, int threePointers)
    {
        return (twoPointers * 2) + (threePointers * 3);
    }

    static void LogicalAndExample()
    {
        Console.WriteLine("Testing Logical AND (&&) with true and false:");
        Console.WriteLine("Enter the first boolean value (true/false):");
        bool firstInput = ConvertToBool(Console.ReadLine());

        Console.WriteLine("Enter the second boolean value (true/false):");
        bool secondInput = ConvertToBool(Console.ReadLine());

        Console.WriteLine($"And({firstInput}, {secondInput}) ➞ {And(firstInput, secondInput)}");
    }

    static bool ConvertToBool(string input)
    {
        return input.ToLower() == "true";
    }

    static bool And(bool a, bool b)
    {
        return a && b;
    }

    static void ConcatenateNameWithEdabit()
    {
        Console.WriteLine("Please enter a name to concatenate with 'Edabit':");
        string name = Console.ReadLine();
        string result = nameString(name);
        Console.WriteLine($"Result: {result}");
    }

    static string nameString(string name)
    {
        return name + "Edabit";
    }

    static void GiveMeSomething()
    {
        Console.WriteLine("Please provide a string to join with 'something':");
        string input = Console.ReadLine();
        Console.WriteLine($"something {input}");
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

    static bool Reverse(bool value)
    {
        return !value;
    }

    static void ReverseBooleanExample()
    {
        Console.WriteLine("Reverse(true) ➞ " + Reverse(true));
        Console.WriteLine("Reverse(false) ➞ " + Reverse(false));
    }

    static int HowManySeconds(int hours)
    {
        return hours * 3600;
    }

    static void ConvertHoursToSeconds()
    {
        Console.WriteLine("Please enter the number of hours to convert into seconds:");
        int hours = int.Parse(Console.ReadLine());
        int seconds = HowManySeconds(hours);
        Console.WriteLine($"{hours} hour(s) is equal to {seconds} seconds.");
    }

    static void SumPolygon()
    {
        Console.WriteLine("Enter the number of sides of the polygon (n > 2):");
        int n = int.Parse(Console.ReadLine());
        if (n > 2)
        {
            int sumOfAngles = (n - 2) * 180;
            Console.WriteLine($"The sum of internal angles of a {n}-sided polygon is: {sumOfAngles} degrees.");
        }
        else
        {
            Console.WriteLine("The number of sides must be greater than 2.");
        }
    }

    static int Sum(int number1, int number2) => number1 + number2;
    static int Convert(int number) => number * 60;
    static int PlusOne(int number) => number + 1;
    static int CircuitPower(int voltage, int current) => voltage * current;
    static int CalcAge(int years) => years * 365;
    static float TriAge(float height, float baseLength) => (height * baseLength) / 2;
    static bool LessThanOrEqualToZero(int number) => number <= 0;
    static bool LessThanOneHundred(int number1, int number2) => (number1 + number2) < 100;
    static bool NumbersEqualTo(int number1, int number2) => number1 == number2;
}
