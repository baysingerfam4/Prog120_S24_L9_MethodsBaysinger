using System;
using System.Diagnostics.CodeAnalysis;
namespace Prog120_S24_L9_Methods
{
    class Program
    {
        // Carla Baysinger
        // Methods L9
        // 05/14/2024

        // First thing we will do is move all code from main to separate method
        static void Main(string[] args)
        {
            // !! Code for the Lecture.
            // You will need to deconstruct this.
            // to call a method, you call it inside of another method.
            // you need to use name of method followed by parentheses.
            double sum = Add(1, 2);
            Console.WriteLine(sum);
            Menu();

        }// Main

        // Rule 1:you cannot declare a method inside of another method.



        // 1. What is a method
        // A method is a block of code, given an identtifying name that is used to call it


        // 3. What is a call stack
        //  list of names of methods called at run time from the beginning of a program until the end

        // 4. What is the scope of variables inside of the method
        // inside the enclosing method code block

        // 5. Where can you declare a method
        // you can declare a method inside a class block and outside of another method

        // 6. Why do we use methods?
        //To organize our code into specific functionality
        //Reusability

        // 7. What is a return type?
        // Tells the computer what type is to be returned out of the method

        // 8. What does void mean?
        // void means that nothing is being returned from the method

        // 9. How do you call a method?
        // to call a method you call it inside another method
        // you need to use the name of your method followed by parentheses
        //Method
        // Refactoring
        // Refactoring is improving our code efficiency

        // 2. What is a method signature
        // A method signature defines the Nme, and parameters to the running application
        //Method Signature: Name and Parameters
        // Access Modifier - Static Keyword - Return Type - Name - Parameters
        //Method names should be in Upper Case in C#
        public static void Menu()
        {
                bool exit = false;

                while (!exit)  // Menu options
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Print from one number to another using loops");
                    Console.WriteLine("2. Perform an algebra level equation");
                    Console.WriteLine("3. Work with an array of names");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option (1-4): ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                    //---------------equation 1
                    PrintNumbers();
                    }
                    else if (choice == "2")
                    {
                    PerformAlgebra();
                    }
                    else if (choice == "3")
                    {
                    WorkwithNames();
                    }
                    else if (choice == "4")
                    {
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please choose again.");
                    }

                    Console.WriteLine(); // Blank line for readability

                }
        } // Main
         // Create a new method called PrinNumbers
         public static void PrintNumbers()
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            // when you pass in values to a method, they are called arguments
            // they have to be the proper type in the proper order
            //LoopThroughNumbers(int, int)
            LoopThroughNumbers(start, end);
       
        }//Print numbers

        // Parameters allow us to pass arguments into a method
        // parameters are declared inside the parantheses after the name
        public static void LoopThroughNumbers(int start, int end)
        {
            if (start <= end)  //list of numbers entered
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = start; i >= end; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //------Write our Equation Methods
        //For our return type, we are replacing void with the type we EXPECT to come out
        // We are adding two doubles, so we are changing void to double
        public static double Add(double number1, double number2)
        {
            double sum = number1 + number2;
            // in order to return something we use the keyword
            return sum;
        }
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
        public static void SolveEquation1()
        {
            //PEMDAS
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            double step1 = Multiply(2, x);
            double y = Add(step1, 3);

            Console.WriteLine($"The result of 2 * {x} + 3 is {y}");
        }// SolveEquation1()
        public static void SolveEquation2()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            //step1 = a * x
            double step1 = Multiply(a, x);

            // step 2 = step1 * x : (a * x * x)
            double step2 = Multiply(step1, x);

            // step 3 = b *x
            double step3 = Multiply(b, x);

            //y = step2 + step3
            double y = Add(step2, step3);
            Console.WriteLine($"The result of {a} * {x}^2 + {b} * {x} is {y}");
        }//SolveEquation1()
        public static void SolveEquation3()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());
            //a * (x - b) * (x + c)
            //parentheses 
            // step1 (x - b) 
            // step2 (x + c)

            // a * step1 * step2
            //step3 a * step1
            // y = step3 * step2

            double step1 = Subtract(x, b);
            double step2 = Add(x, c);

            double step3 = Multiply(a, step1);
            double y = Multiply(step3, step2);

            Console.WriteLine($"The result of {a} * ({x} - {b}) * ({x} + {c}) is {y}");
        }//SolveEquation1()
        public static void PerformAlgebra() // menu option to choose equation for the user to solve
        {
            Console.WriteLine("Choose an equation to solve:");
            Console.WriteLine("1. y = 2x + 3");
            Console.WriteLine("2. y = ax^2 + bx + c");
            Console.WriteLine("3. y = a(x - b)(x + c)");
            Console.Write("Choose an equation (1-3): ");
            string equationChoice = Console.ReadLine();

            if (equationChoice == "1")
            {
                SolveEquation1();
            }
            else if (equationChoice == "2")
            {
                SolveEquation2();
            }
            else if (equationChoice == "3")
            {
                SolveEquation3();
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to main menu.");
            }
        }
        public static void WorkwithNames()
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("You entered the following names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    } // class

} // namespace
