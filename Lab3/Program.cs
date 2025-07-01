using System;
using Lab3.Classes;

namespace Lab3
{

    //4.

    //interface Calculate
    //{
    //    public void Addition(int a, int b);
    //    public void Subtraction(int a, int b);
    //}

    //class Result : Calculate
    //{
    //    public void Addition(int a, int b)
    //    {
    //        Console.WriteLine(a+b);
    //    }

    //    public void Subtraction(int a, int b)
    //    {
    //        Console.WriteLine(a - b);

    //        //throw new NotImplementedException();
    //    }
    //}

    //7.
    //interface Shape
    //{
    //    void Circle(double radius);
    //    void Triangle(double b, double h);
    //    void Square(double side);
    //}

    //class AreaCalculator : Shape
    //{
    //    public void Circle(double radius)
    //    {
    //        double area = Math.PI * radius * radius;
    //        Console.WriteLine("Area of Circle: " + area);
    //    }

    //    public void Triangle(double b, double h)
    //    {
    //        double area = 0.5 * b * h;
    //        Console.WriteLine("Area of Triangle: " + area);
    //    }

    //    public void Square(double side)
    //    {
    //        double area = side * side;
    //        Console.WriteLine("Area of Square: " + area);
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {

            //1.

            //int b = 0;
            //try
            //{
            //    int a = 1 / b;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e);
            //}

            //2.

            //int[] arr = new int[5];

            //try
            //{
            //    Console.WriteLine("Enter the Numbers: ");
            //    for (int i = 0; i <= arr.Length; i++)
            //    {
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //3.

            //Sum s = new Calculate();
            //s.SumOfTwo(1, 2);
            //s.SumOfThree(2, 3, 4);

            //4.

            //Result r = new Result();
            //r.Addition(1, 2);
            //r.Subtraction(9, 2);

            //5. 
            //string str = "  Hello World this is Kunj in CSharp  ";

            //Console.WriteLine("Original String: '" + str + "'");
            //Console.WriteLine("Length: " + str.Length);

            //string trimmed = str.Trim();
            //Console.WriteLine("Trimmed: '" + trimmed + "'");

            //Console.WriteLine("Upper Case: " + trimmed.ToUpper());
            //Console.WriteLine("Lower Case: " + trimmed.ToLower());

            //Console.WriteLine("Substring(6, 5): " + trimmed.Substring(6, 5));

            //Console.WriteLine("Index of 'Kunj': " + trimmed.IndexOf("Kunj"));
            //Console.WriteLine("Last Index of 'o': " + trimmed.LastIndexOf('i'));

            //Console.WriteLine("Contains 'from': " + trimmed.Contains("from"));

            //Console.WriteLine("Replace: " + trimmed.Replace("CSharp", "C#"));

            //Console.WriteLine("Equals 'Hello World': " + trimmed.Equals("Hello World"));
            //Console.WriteLine("Equals (ignore case): " + trimmed.Equals("hello world thiS IS kunj in C#", StringComparison.OrdinalIgnoreCase));

            //string[] words = trimmed.Split(' ');
            //Console.WriteLine("Words in string:");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine("Starts with 'Hello': " + trimmed.StartsWith("Hello"));
            //Console.WriteLine("Ends with 'Class': " + trimmed.EndsWith("Csharp"));

            //6

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string result = "";

            //foreach (char ch in input)
            //{
            //    if (char.IsLower(ch))
            //    {
            //        result += char.ToUpper(ch);
            //    }
            //    else if (char.IsUpper(ch))
            //    {
            //        result += char.ToLower(ch);
            //    }
            //    else
            //    {
            //        result += ch;
            //    }
            //}
            //Console.WriteLine("Converted String: " + result);

            //7.

            //AreaCalculator calc = new AreaCalculator();
            //calc.Circle(5);
            //calc.Triangle(4, 6);
            //calc.Square(3);

            //8.

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number % 2 != 0)
            //    {
            //        throw new Exception("The number is not even.");
            //    }

            //    Console.WriteLine("You entered an even number: " + number);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            //9.

            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //string longest = "";

            //foreach (string word in words)
            //{
            //    if (word.Length > longest.Length)
            //    {
            //        longest = word;
            //    }
            //}

            //Console.WriteLine("Longest word: " + longest);

            //10.

            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (char.IsUpper(ch))
            {
                Console.WriteLine("Changed case: " + char.ToLower(ch));
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine("Changed case: " + char.ToUpper(ch));
            }
            else
            {
                Console.WriteLine("Not an alphabetic character.");
            }

        }
    }
}


