using System;
using System.ComponentModel;
class Challenges
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to my Coding Challenge program! There will be a variety of different functions you will \nhave to choose from. Please pick one.");
        Console.WriteLine("Today we are going to use the number adder called SUM. PLease put two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a second number!");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number" + number1 + " and the number: " + number2 + "is equal to:" + Sum(number1int, number2int));
        Sum(number1int, number2int);

        Console.WriteLine("Let's try converting minutes to seconds. \nGive me a number to convert from minutes to seconds");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);
      
        Console.WriteLine(number3 + "minutes converted to seconds is" + Convert(number3int) + "seconds");

        Console.WriteLine("Let's try adding a number by 1. \nPlease insert a number to add 1 to.");
        var number4 = Console.ReadLine();
        int numberint = int.Parse(number4);

        Console.WriteLine(number4 + "plus one is" + PlusOne(numberint));

        Console.WriteLine("Let's try to calculate power using volatge and current. \nPLease enter the voltage.");
        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        Console.WriteLine("Perfect! Now insert the current");
        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);    
        Console.WriteLine("The power of" + number5 + "and" + number6 + "are equal to:" + CircuitPower(number5int, number6int));

        Console.WriteLine("Let's calculate someone's age in days. \nPlease enter an age");
        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);

        Console.WriteLine("You are" + CalcAge(number7int) + "days old");

        Console.WriteLine("Let's calculate the area of a triangle using the base and height. \nEnter the height of the triangle.");
        var number8 = Console.ReadLine();
        float number8int = int.Parse(number8);

        Console.WriteLine("Nice! Now enter the base of the triangle.");
        var number9 = Console.ReadLine();
        float number9int = int.Parse(number9);

        Console.WriteLine("The area of the triangle is" + TriAge(number8int, number9int));

        Console.WriteLine("Now let's see if a number is less than or equal to zero. \nPLease input a number");
        var number10 = Console.ReadLine();
        int number10int = int.Parse(number10);

        Console.WriteLine("The number entered is" + LessThanOrEqualToZero(number10int));

        Console.WriteLine("Let's add two numbers, and see if they're less than 100. \nPlease input the first number");
        var number11 = Console.ReadLine();
        int number11int = int.Parse(number11);

        Console.WriteLine("Cool! Now enter the second number.");
        var number12 = Console.ReadLine();
        int number12int = int.Parse(number12);

        Console.WriteLine("The sum of the numbers entered is" + LessThanOneHundred(number11int, number12int));

        Console.WriteLine("Now let's enter two numbers to see if they are equal. \n Enter the first number.");
        var number13 = Console.ReadLine();
        int number13int = int.Parse(number13);

        Console.WriteLine("Fantastic! Now insert the second number.");
        var number14 = Console.ReadLine();
        int number14int = int.Parse(number14);

        Console.WriteLine("The numbers entered are" + NumbersEqualTo(number13int, number14int));
    }


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number3)
    {
        return number3 * 60;

    }

    public static int PlusOne(int number4)
    {
        return number4 + 1;
    }

    public static int CircuitPower(int number5, int number6)
    {
        return number5 * number6;
    }

    public static int CalcAge(int number7)
    {
        return number7 * 356;
    }

    public static float TriAge(float number8, float number9)
    {
        return (number8 * number9) / 2;
    }

    public static bool LessThanOrEqualToZero(int number10)
    {
        return number10 <= 0;
    }

    public static bool LessThanOneHundred(int number11, int number12)
    {
        return number11 + number12 < 100;
    }

    public static bool NumbersEqualTo(int number13, int number14)
    {
        return number13 == number14;
    }
}
