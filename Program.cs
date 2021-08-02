using System;

namespace learningString
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Enter a string to Reverse : "); 
        //    string r = Console.ReadLine();
        //    reverseString rs = new reverseString();
        //    string ans = rs.Reverse(r);
        //    Console.WriteLine("Reversed string is : " + ans);

            Console.WriteLine("Enter First Number :");
            string snum1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number :");
            string snum2 = Console.ReadLine();
            Console.WriteLine("Enter Operator : ");
            string op = Console.ReadLine();
            int num1 = int.Parse(snum1);
            int num2 = int.Parse(snum2);
            Calculator cal = new Calculator();
            if(op == "+")
            {
                Console.WriteLine("Result is : " + cal.add(num1, num2));
            }
            else if(op == "-")
            {
                Console.WriteLine("Result is : " + cal.sub(num1, num2));
            }
            else if(op == "*")
            {
                Console.WriteLine("Result is : " + cal.mul(num1, num2));
            }
            else if(op == "/")
            {
                Console.WriteLine("Result is : " + cal.div(num1, num2));
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }

    //write a class to reverse a atring
    public class reverseString
    {
        public string Reverse(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }

    //create a class of basic calculator
    public class Calculator 
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }

}
