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
            MenuKhanza();
            MenuAnindya();
        }
        static void MenuAnindya()
        {
           Menu:
            Console.WriteLine("Input Number From 1-4");
            Console.WriteLine("1. Body Mas Index \n" + "2. Reprint Name \n" + "3. Print Even's Character \n" + "4. Sum the Inputted Array \n");
            int option = Convert.ToInt32(Console.ReadLine());
            int bb, tb, bil;
            double bmi;
            string name;
ait  

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
        static void MenuKhanza()
        {
            Console.WriteLine("Input Your Number From 1-4");
            Console.WriteLine("1. Body Mass Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Print Even's Character");
            Console.WriteLine("4. Sum the Inputted Array");
            Console.WriteLine("5. Print Odd's Character");
            Console.WriteLine("");
            String option = Console.ReadLine();
            int menu = Convert.ToInt32(option);

            switch (menu)
            {
                case 1:
                    bmi();
                    break;
                case 2:
                    reprintName();
                    break;
                case 3:
                    printEvenChar();
                    break;
                case 4:
                    sumInputed();
                    break;
                case 5:
                    printOddChar();
                    break;
                default:
                    Console.WriteLine("Please Input Number 1-5");
                    break;
            }

            //if (menu == "1")
            //{
            //    bmi();
            //}
            //else if (menu == "2")
            //{
            //    reprintName();
            //}
            //else if (menu == "3")
            //{
            //    printEvenChar();
            //}
            //else if (menu == "4")
            //{
            //    sumInputed();
            //}
            //else
            //{
            //    Console.WriteLine("Please Input Number 1-4");
            //}
            Console.WriteLine("");
            Console.WriteLine("Type yes to restart program");
            String restart = Console.ReadLine();
            if (restart.ToLower() == "yes")
            {
                Menu();
            }
        }
        static void bmi()
        {
            Console.WriteLine("Body Mass Index");
            Console.Write("Input Your Weigth(Kg) : ");
            String berat = Console.ReadLine();
            Console.Write("Input Your Height(Cm) : ");
            String tinggi = Console.ReadLine();

            float weight = Convert.ToInt32(berat);
            float height = Convert.ToInt32(tinggi);
            float bmi = (weight * weight) / height;

            String kategori;

            if (bmi < 18.1)
                kategori = "Underweight";
            else if (bmi > 18.1 && bmi < 23.1)
                kategori = "Normal";
            else if (bmi > 23.1 && bmi < 28.1)
                kategori = "Overweight";
            else
                kategori = "Obesitas";
            Console.WriteLine("Your BMI's " + Math.Round(bmi, 1) + "," + "you're " + kategori);
        }

        static void reprintName()
        {
            Console.Write("Please Input Your Name : ");
            String name = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < name.Length; i++)
            {
                num = i + 1;
                Console.WriteLine("Huruf ke " + num + " adalah " + name[i]);
            }
        }

        static void printEvenChar()
        {
            Console.Write("Please Input Your Name : ");
            String even = Console.ReadLine();
            for (int i = 1; i < even.Length; i = i + 2)
            {
                Console.WriteLine(even[i]);
            }
        }

        static void sumInputed()
        {
            Console.WriteLine("Please Input the Array Size : ");
            String inputed = Console.ReadLine();
            int size = Convert.ToInt32(inputed);
            int[] sum = new int[size];

            //    int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = sum.Sum();
            Console.WriteLine("Result : " + total);
        }

        static void printOddChar()
        {
            Console.Write("Please Input Your Name : ");
            String odd = Console.ReadLine();
            for (int i = 0; i < odd.Length; i = i + 2)
            {
                Console.WriteLine(odd[i]);
            }
        }
    }
}
