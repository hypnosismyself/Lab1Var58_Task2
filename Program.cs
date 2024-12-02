using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Var58_Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("X начальное - ");
            double start_X = Convert.ToDouble(Console.ReadLine());
            Console.Write("X конечное - ");
            double start_Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Шаг - ");
            double step = Convert.ToDouble(Console.ReadLine());
            Console.Write("Точность - ");
            double accuracy = Convert.ToDouble(Console.ReadLine());

            List<string> RowList = Calculation(start_X, start_Y, step, accuracy);


            Console.WriteLine($"X\tСум о.\tСум ш.\tШаг\n");
            foreach (string row in RowList)
                Console.WriteLine(row);
        }

        static List<string> Calculation(double start_X, double start_Y, double step, double accuracy)
        {
            List<string> RowsList = new List<string> ();

            double current_sum = 0;
            int num = 0;

            for (double x = start_X; x <= start_Y; x += step)
            {
                double curY = (Math.Pow(-1, step) * Math.Pow((x - 1), step + 1)) / (step + 1);
                current_sum += curY;

                RowsList.Add($"{x}\t{current_sum}\t{curY}\t{num}");
                num++;
            }

            return RowsList;
        }
    }
}
