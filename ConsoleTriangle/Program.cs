using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;

namespace ConsoleTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Triangle Printer, please enter number of lines you wish to be in the triangles");
                Console.Write(">");
                string input = Console.ReadLine();
                if (input == "exit" || input == "q" || input == "quit")
                    break;
                int n;
                if (!Int32.TryParse(input, out n))
                    continue;

                TrianglePrinter.RightTriangle(n);
                TrianglePrinter.InverseRightTriangle(n);
                TrianglePrinter.IsoscelesTriangle(n);
            }


            Console.WriteLine("Exiting...");
            Console.ReadKey();

        }
    }

    public static class TrianglePrinter
    {
        public static void RightTriangle(int n)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendLine();
            myStringBuilder.AppendLine($"Right triangle of height {n}");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    myStringBuilder.Append("*");

                myStringBuilder.AppendLine();
            }

            Console.Write(myStringBuilder.ToString());
        }

        public static void InverseRightTriangle(int n)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendLine();
            myStringBuilder.AppendLine($"Right triangle of height {n}");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= (n - i); j++)
                    myStringBuilder.Append("*");

                myStringBuilder.AppendLine();
            }

            Console.Write(myStringBuilder.ToString());
        }

        public static void IsoscelesTriangle(int n)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendLine();
            myStringBuilder.AppendLine($"Isosceles Triangle of height {n}");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    myStringBuilder.Append(" ");
                for (int k = 0; k < (2 * i - 1); k++)
                    myStringBuilder.Append("*");
                myStringBuilder.AppendLine();
            }

            Console.Write(myStringBuilder.ToString());
        }
    }
}
