using System;

namespace learningString
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.ReadLine();
        }
    }

    //write a class to reverse a atring
    public class reverseString
    {
        public string reverse(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }

}
