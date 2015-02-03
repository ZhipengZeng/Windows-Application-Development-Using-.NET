using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Enter values: ";
            int number = 5;
            Calculate(ReadDoubles(input, number));
            Console.ReadKey();
        }
        static double[] ReadDoubles(string prompt, int n)
        {
            Console.WriteLine(prompt + "(" + n + ")");
            double[] temp = new double[n];

            for (int i = 0; i < temp.Length; i++)
            {
                string num = Console.ReadLine();
                temp[i] = Convert.ToDouble(num);
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + temp[i]);
            }
            return temp;
        }
        static void Calculate(double[] a)
        {
            double sum = 0;
            double pro = 1;
            double avg = 0;
            double max = 0;
            double min = 0;
            for (int i = 0; i < a.Length; i++)
			{
                sum += a[i];
                pro *= a[i];
                avg = sum / a.Length;
                if (a[0] > a[i])
                {
                    max = a[0];
                    min = a[i];
                }
                else
                {
                    max = a[i];
                    min = a[0];
                }
			}
            Console.WriteLine("Sum: " + sum + "\nProduct: " + pro + "\nAverage: " + avg 
                + "\nMax: " + max + "\nMin: " + min);
            
        }
    }
}
