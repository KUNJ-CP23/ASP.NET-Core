// See https://aka.ms/new-console-template for more information
using System;

class Program
{
   static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Print Name, Address, Contact Number, City");
            Console.WriteLine("2. Get two numbers and print them");
            Console.WriteLine("3. Input name and country, print 'Hello from <country>'");
            Console.WriteLine("4. Calculate area in square feet");
            Console.WriteLine("5. Area of Square, Rectangle, Circle");
            Console.WriteLine("6. Celsius <-> Fahrenheit Conversion");
            Console.WriteLine("7. Calculate Simple Interest");
            Console.WriteLine("8. Simple Calculator");
            Console.WriteLine("9. Swap two numbers without third variable");
            Console.WriteLine("10. Find Maximum of 3 numbers using ternary operator");
            Console.WriteLine("-1. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Name: Kunj Ramoliya");
                    Console.WriteLine("Address: Example Street");
                    Console.WriteLine("Contact Number: 9876543210");
                    Console.WriteLine("City: Rajkot");
                    break;

                case 2:
                    Console.Write("Enter first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Two numbers are: {num1} and {num2}");
                    break;

                case 3:
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your country: ");
                    string country = Console.ReadLine();
                    Console.WriteLine($"Hello from {country}");
                    break;

                case 4:
                    Console.Write("Enter length in feet: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter width in feet: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double area = length * width;
                    Console.WriteLine($"Area: {area:F2} square feet");
                    break;

                case 5:
                    Console.Write("Enter side of square: ");
                    double squareSide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Square: {squareSide * squareSide}");

                    Console.Write("Enter length of rectangle: ");
                    double rectLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter width of rectangle: ");
                    double rectWidth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Rectangle: {rectLength * rectWidth}");

                    Console.Write("Enter radius of circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of Circle: {Math.PI * radius * radius}");
                    break;

                case 6:
                    Console.Write("Enter temperature in Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Fahrenheit: {(celsius * 9 / 5) + 32:F2}");

                    Console.Write("Enter temperature in Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Celsius: {(fahrenheit - 32) * 5 / 9:F2}");
                    break;

                case 7:
                    Console.Write("Enter Principal: ");
                    double principal = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Rate: ");
                    double rate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Time: ");
                    double time = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Simple Interest: {(principal * rate * time) / 100:F2}");
                    break;

                case 8:
                    Console.Write("Enter first number: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter operation (+, -, *, /): ");
                    string op = Console.ReadLine();

                    if (op == "+")
                        Console.WriteLine($"Result: {a + b}");
                    else if (op == "-")
                        Console.WriteLine($"Result: {a - b}");
                    else if (op == "*")
                        Console.WriteLine($"Result: {a * b}");
                    else if (op == "/")
                        Console.WriteLine(b != 0 ? $"Result: {a / b}" : "Cannot divide by zero");
                    else
                        Console.WriteLine("Invalid operation");

                    switch (op)
                    {
                        case "+":
                            Console.WriteLine($"[Switch] Result: {a + b}");
                            break;
                        case "-":
                            Console.WriteLine($"[Switch] Result: {a - b}");
                            break;
                        case "*":
                            Console.WriteLine($"[Switch] Result: {a * b}");
                            break;
                        case "/":
                            Console.WriteLine(b != 0 ? $"[Switch] Result: {a / b}" : "Cannot divide by zero");
                            break;
                        default:
                            Console.WriteLine("[Switch] Invalid operation");
                            break;
                    }
                    break;

                case 9:
                    Console.Write("Enter first number to swap: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number to swap: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    x = x + y;
                    y = x - y;
                    x = x - y;
                    Console.WriteLine($"After swapping: x = {x}, y = {y}");
                    break;

                case 10:
                    Console.Write("Enter first number: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter third number: ");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    int max = (n1 > n2) ? (n1 > n3 ? n1 : n3) : (n2 > n3 ? n2 : n3);
                    Console.WriteLine($"Maximum is: {max}");
                    break;

                case -1:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != -1);
    }
}


