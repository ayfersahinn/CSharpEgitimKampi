using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach loop
            //string[] cities = { "istanbul", "ankara", "van", "bolu" };

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 1, 2,10,20 ,59};
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] numbers = { 1, 2, 10, 20, 44,26,33, 59 };
            //foreach (int i in numbers)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 1, 2, 10, 20, 44, 26, 33, 59 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);


            //List<int> list = new List<int>()
            //{
            //    1,2,34,2,3,4,5,6
            //};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string name = "ayşe";
            //foreach(char i in name)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region ornek uygulama
            Console.WriteLine("C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
           
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.Write("Sınıfınızda kaç öğrenci var? ");
            int stdCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            string[] stdNames = new string[stdCount];
            double[] stdExamAvg = new double[stdCount];
            for (int i = 0; i < stdCount; i++)
            {
                Console.Write($"{i + 1}. öğrenci adını giriniz: ");
                stdNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                for(int j=0; j < 3; j++)
                {
                    Console.Write($"{stdNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                stdExamAvg[i] = totalExamResult/3;
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            
            for (int i = 0;i < stdCount;i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{stdNames[i]} isimli öğrencinin ortalaması: {stdExamAvg[i]}");
                Console.WriteLine();

                if (stdExamAvg[i] > 50)
                {
                    Console.WriteLine($"{stdNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{stdNames[i]} isimli öğrenci dersten kaldı");

                }
                Console.WriteLine() ;
                Console.WriteLine("------------------------------------------");

            }
            #endregion
            Console.Read();
        }
    }
}
