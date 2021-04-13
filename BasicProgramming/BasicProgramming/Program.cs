using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
        Menu:
            Console.WriteLine("Input Number From 1-4");
            Console.WriteLine("1. Body Mas Index \n" + "2. Reprint Name \n" + "3. Print Even's Character \n" + "4. Sum the Inputted Array \n");
            int option = Convert.ToInt32(Console.ReadLine());
            int bb, tb, bil;
            double bmi;
            string name;


            switch (option)
            {
                case 1:
                    Console.WriteLine($"Input Your Weight (kg)");
                    bb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Input Your Height (Cm)");
                    tb = Convert.ToInt32(Console.ReadLine());

                    double tinggiMeter = (double)(tb / 100.0);
                    bmi = (double)bb / (tinggiMeter * tinggiMeter);
                    double ubah = Math.Round(bmi, 1);
                    Console.WriteLine();
                    Console.Write("Your BMI's " + ubah + " You're");
                    if (bmi < 18.1)
                    {
                        Console.Write(" Underwight \n");
                    }
                    else if (bmi >= 18.1 && bmi <= 23.1)
                    {
                        Console.Write(" Normal \n");
                    }
                    else if (bmi >= 23.1 && bmi <= 28.1)
                    {
                        Console.Write(" OverWeight \n");
                    }
                    else
                    {
                        Console.Write(" Obesitas \n");
                    }
                    break;

                case 2:
                    Console.WriteLine($"Please Input Your Name");
                    name = Console.ReadLine();
                    for (int i = 0; i < name.Length; i++)
                    {
                        Console.WriteLine("Huruf Ke " + (i + 1) + " adalah " + name[i]);
                    }
                    break;

                case 3:

                    Console.WriteLine($"Please Input Your Name");
                    name = Console.ReadLine();
                    String[] nama = new String[100];
                    for (int i = 0; i < name.Length; i++)
                    {
                        nama[i] = name.Substring(i, 1);

                    }
                    for (int i = 1; i <= name.Length; i++)
                    {
                        Console.WriteLine(nama[i]);
                        i += 1;
                    }
                    break;

                case 4:
                    Console.WriteLine($"Please Input Jumlah Array");
                    bil = Convert.ToInt32(Console.ReadLine());
                    int[] jumlah = new int[100];
                    int total = 0;
                    for (int i = 0; i < bil; i++)
                    {

                        Console.WriteLine("Input Array ke " + (i + 1));
                        String input = Console.ReadLine();
                        jumlah[i] = Convert.ToInt32(input);
                    }
                    for (int i = 0; i < bil; i++)
                    {
                        total += jumlah[i];

                    }
                    Console.WriteLine("Total = " + total);
                    break;
            }

            Console.WriteLine("Type Yes for Restart Program");
            String masuk = Console.ReadLine();
            if (masuk.ToLower() != "Yes")
            {
                Console.Clear();
                goto Menu;
            }

        }
    }
}
