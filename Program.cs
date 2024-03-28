using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\tTask 1.");

            Console.WriteLine("\tEnter number from 1 to 1000 :");
            int numTask1 = int.Parse(Console.ReadLine());

            if (numTask1 > 100 && numTask1 < 1)
            {
                Console.WriteLine("\tYou entered is not correct number");
            }
            else if (numTask1 % 3 == 0 && numTask1 % 5 == 0)
            {
                Console.WriteLine("\tFIZZ BUZZ");
            }
            else if (numTask1 % 3 == 0)
            {
                Console.WriteLine("\tFIZZ");
            }
            else if (numTask1 % 5 == 0)
            {
                Console.WriteLine("\tBUZZ");
            }
            else
            {
                Console.WriteLine(numTask1);
            }

            Console.WriteLine();

            Console.WriteLine("\t Task 2.");

            Console.WriteLine("\t Enter the number : ");
            int numTask2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\t Enter the enter the percentage : ");
            int numPrecentage = int.Parse(Console.ReadLine());

            double resultTask2 = (numTask2 / 100.0) * numPrecentage;
            Console.WriteLine($"\t{numPrecentage} precentag from  {numTask2} : {resultTask2}");

            Console.WriteLine();
            Console.WriteLine("Task 3.");
            Console.WriteLine();

            int newNum = 0;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"\tEnter number {i}:");
                int numTask3 = int.Parse(Console.ReadLine());
                newNum += numTask3;
                newNum *= 10;
            }

            Console.WriteLine(newNum / 10);

            Console.WriteLine();
            Console.WriteLine("Task 4.");
            Console.WriteLine();

            Console.WriteLine("\tEnter a 6-digit number");
            int numTask4 = int.Parse(Console.ReadLine());

            Console.WriteLine("\tWhich number should be changed");
            int numberChangeOne = int.Parse(Console.ReadLine());

            Console.WriteLine("\tThat number should be changed to");
            int numberChangeTwo = int.Parse(Console.ReadLine());

            int[] array = new int[6]; 
           
            for (int i = 5; i >= 1; i--) 
            {
                int num = numTask4 % 10;
                array[i] = num;
                numTask4 /= 10;
            }
            array[0] = numTask4;

            int temp = array[numberChangeOne - 1];
            array[numberChangeOne - 1] = array[numberChangeTwo - 1];
            array[numberChangeTwo - 1] = temp;

            int resultTask4 = 0;
            for (int i = 0; i < 6; i++) 
            {
                resultTask4 = resultTask4 * 10 + array[i];
            }

            Console.WriteLine(resultTask4);

            Console.WriteLine();
            Console.WriteLine("Task 6.");
            Console.WriteLine();

            Console.WriteLine("\tEnter temperature:");
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("\t Enter units of measurement f or c:");
            string units = Console.ReadLine();

            int temperatureConvert;

            if (units == "f")
            {
                temperatureConvert = (temperature - 32) * 5 / 9;

                Console.WriteLine($"The temperature is {temperatureConvert} C");
            }
            else if (units == "c") 
            {
                temperatureConvert = (temperature * 9 / 5) + 32;

                Console.WriteLine($"The temperature is {temperatureConvert} F");
            }
            else
            {
                Console.WriteLine("Invalid units of measurement. Please enter 'f' for Fahrenheit or 'c' for Celsius.");
            }

            Console.WriteLine();
            Console.WriteLine("Task 7.");
            Console.WriteLine();

            Console.WriteLine("\nEnter begin of the diapason:");
            int beginDiapason = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter end diapason:");
            int endDiapason = int.Parse( Console.ReadLine());

            if (beginDiapason >endDiapason)
            { 
                int tmp = beginDiapason;
                beginDiapason = endDiapason;
                endDiapason = tmp;
            }

            for(int i = beginDiapason; i<= endDiapason; i++)
            {
                Console.Write(i % 2 == 0 ? $"{i} " : "");
            }



            Console.ReadLine();
        }

        
    }
}
