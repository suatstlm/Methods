﻿using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add1();

            //var result = Add2(3,6); Console.WriteLine(result);
            //int number1 = 20;
            //int number2 = 100;
            //var result = Add3(ref number1,number2);
            //Console.WriteLine(result);

            //Console.WriteLine(Multiply(2, 5, 7));

            Console.WriteLine(Add4(2, 5, 7,9));

        }

        static void Add1()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1,int number2)
        {
           var result = number1 + number2;
            return result; 
        }

        static int Add3(ref int number1 , int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2*number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
