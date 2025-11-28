internal class Program
{
    private static void Main(string[] args)
    {
        // test/run progran by executing "dotnet run" in terminal
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I am learning C#");
        Console.WriteLine(3 + 3);
        Console.WriteLine("Remember to save, and execute 'dotnet run'");
        Console.Write("Hello world! ");
        Console.Write("This will go on the same line."); //This is a comment at the end of a line
                                                         // This is a full line comment
        /*This is a multi line comment
        These do look a bit like Javascript, don't they?*/
        int myNum = 15;
        Console.WriteLine(myNum);
        myNum = 20;
        Console.WriteLine(myNum);
        double myDoubleNum = 5.99D;
        char myLetter = 'D'; //Note that " and ' are different in C#. ' should be used for single character functions such as char, " for 0 or more. Nested \" / \' must be escaped
        bool myBool = true;
        string myText = "Hello"; // string stores sequences of characters, surrounded by " double quotes.
                                 // const int myNum = 15; error
                                 // myNum = 20; // error
        string firstName = "Alexander ";
        string lastName = "Jansen";
        string fullName = firstName + lastName;
        Console.WriteLine(fullName);
        int x = 5;
        int y = 6;
        Console.WriteLine(x + y);
        Console.WriteLine(x > y);
        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }
        Console.WriteLine(x == 5);
        int z = 50;
        Console.WriteLine(x + y + z);
        int a, b, c;
        a = b = c = 50;
        Console.WriteLine(a + b + c);
        // Names must be unique, ideally descriptive for readability
        int minutesPerHour = 60; //good
        int m = 60; //ok
        /*
        int     4 byte whole numbers
        long    8 byte whole numbers
        float   4 byte fractions
        double  8 byte fractions
        bool    1 byte true/false
        char    2 byte single character, surrounded by single quotes
        string  2 byte/char, sequences surrounded by double quotes
        */
        int myNumber = 100000;
        Console.WriteLine(myNumber);
        long myLNum = 15000000000L;
        Console.WriteLine(myLNum);
        float myfNum = 5.75F;
        Console.WriteLine(myfNum);
        double mydNum = 19.99D;
        Console.WriteLine(mydNum);
        bool isCSharpFun = true;
        bool isFishTasty = false;
        Console.WriteLine(isCSharpFun);
        Console.WriteLine(isFishTasty);
        char myGrade = 'B';
        Console.WriteLine(myGrade);

        // Typecasting
        // implicit convert smaller to larger   char → int → long → float → double

        int myInt = 9;
        double myDouble = myInt; // auto cast int
        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);

        // explicit convert larger to smaller   double → float → long → int → char
        double myEDouble = 9.78;
        int myEInt = (int)myEDouble;
        Console.WriteLine(myEDouble);
        Console.WriteLine(myEInt);

        // Type username and press enter
        Console.WriteLine("Enter username:");
        // Create a string variable, get user input from keyboard and store in variable
        string userName = Console.ReadLine();
        // Print the value of the variable
        Console.WriteLine("Username is: " + userName);
        // User input and numbers
        // Console.ReadLine() returns a string, and cannot get information from another data type, such as int. Ints must be explicitly converted
        Console.WriteLine("Enter your age:");
        // int age = Console.ReadLine(); //This explicitly gives a cannot implicitly convert error, even before running
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);

        // Operators
        int sum1 = 100 + 50;
        int sum2 = sum1 + 250;
        int sum3 = sum1 + sum2;
        Console.WriteLine(sum2 > sum1);
        Console.WriteLine(sum1 < 150 && sum2 < 150); // checks both sums and returns false (logical and)
        Console.WriteLine(sum1 < 150 || sum2 > 150); // true if one statement is true (or)
        Console.WriteLine(!(sum1 < 150 && sum2 < 150)); // ! logical not

        // maths
        // Find the highetst value
        Math.Max(5, 10);
        // Find the lowest value
        Math.Min(5, 10);
        Math.Sqrt(64);
        Math.Abs(-4.7);
        Math.Round(9.99);

        // Strings
        // Strings can be manipulated
        string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine("The alphabet has " + abc.Length + " letters");
        string name = string.Concat(firstName, lastName);
        Console.WriteLine(name); //Using variables declared earlier
        int w = x + y;
        string d = "10";
        string e = "20";
        string f = d + e;
        Console.WriteLine(f);
        // Access strings
        string myString = "Hello";
        Console.WriteLine(myString[0]); //Return first letter of the string
        Console.WriteLine(myString[1]);
        Console.WriteLine(myString.IndexOf("e")); //index of the letter
                                                  // Special characters
        string txt = "We are the so-called \"Vikings\" from the north.";
        string text = "It\'s alright";
        string tekst = "The character \\ is a backslash";
        int myAge = 28;
        int votingAge = 18;
        if (myAge >= votingAge)
        {
            Console.WriteLine("Old enough to vote!");
        }
        else
        { Console.WriteLine("Not old enough to vote!");}

        Console.WriteLine(myAge >= votingAge);
        int time = 20;
        if (time < 18)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
        string result = (time < 18) ? "Good day." : "Good evening"; //should do the same
        Console.WriteLine(result);
        time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good morning");
        }
        else if (time < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        int j = 0;
        do
        {
            Console.WriteLine(j);
            j++;
        }
        while (j < 5);
        for (int k = 0; k < 5; k++)
        {
            Console.WriteLine(k);
        }
        for (int l = 0; l <= 10; l = l + 2)
        {
            Console.WriteLine(l);
        }
        for (int o = 1; o <= 2; ++o)
        {
            Console.WriteLine("Outer: " + o);
            for (int n = 1; n <= 3; n++)
            {
                Console.WriteLine(" Inner: " + n);
            }
        }
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Array.Sort(cars); //sort string alphabetically or numerically
        foreach (string p in cars)
        {
            Console.WriteLine(p);
        }
        int[] myNums = {10, 20, 30, 40};
        Console.WriteLine(cars[0]);
        cars[0] = "Opel";
        Console.WriteLine(cars.Length);
        Array.Sort(myNums);
        foreach (int q in myNums)
        {
            Console.WriteLine(q);
        }

        // Other ways to make arrays
        // Create an array of four elements, and add values later
        // string[] cars = new string[4];

        // Create an array of four elements and add values right away 
        // string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements without specifying the size 
        // string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        // Declare an array
        // string[] cars;

        // Add values, using new
        // cars = new string[] {"Volvo", "BMW", "Ford"};

        // Add values without using new (this will cause an error)
        // cars = {"Volvo", "BMW", "Ford"};

//         using System;
// using System.Linq;

// namespace MyApplication
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       int[] myNumbers = {5, 1, 8, 9};
//       Console.WriteLine(myNumbers.Max());  // returns the largest value
//       Console.WriteLine(myNumbers.Min());  // returns the smallest value
//       Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
//     }
//   }
// }

// Multidimensional arrays
int[,] numbers = {{1, 4, 2}, {3, 6, 8}};
Console.WriteLine(numbers[0, 2]);
foreach (int r in numbers)
        {
            Console.WriteLine(r);
        }
    }
//     int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

// for (int i = 0; i < numbers.GetLength(0); i++) 
// { 
//   for (int j = 0; j < numbers.GetLength(1); j++) 
//   { 
//     Console.WriteLine(numbers[i, j]); 
//   } 
// }  
}