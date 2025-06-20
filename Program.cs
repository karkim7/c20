using System;

//simple calculator using +, -,/,*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter First Number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("\n Please, enter Second Number: ");
        double num2 = double.Parse(Console.ReadLine());


        Console.Write("\n Please, choose the operator +, -, / or *  ");
        string op = Console.ReadLine();

        double result = 0;

        if (op == "+")

            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Your request is invalid . Please, try again! ");
                return;
            }
        }
        else
        {
            Console.WriteLine(" \n Please, try again! ");
            return;
        }


        //output the result

        Console.WriteLine("RESULT: " + result);
    }
}

