using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for loops
            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine("hello world!");
            //}

            //for(int i=0; i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Kaç kez yazdırmak istiyorsunuz: ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}
            #endregion

            #region for loops with if scopes
            //for (int i = 0; i <100;  i++)
            //{
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue = 0;
            //for (int i = 0; i <=10;  i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int evenNumbers = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        evenNumbers += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------------------");
            //Console.WriteLine(evenNumbers);

            //int numbers = 0;
            //for(int i = 0; i < 50; i++)
            //{
            //    if(i%7 == 0)
            //    {
            //        numbers++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(numbers);

            //int bacterium = 1;
            //for (int i = 0;i<24;i++)
            //{
            //    bacterium*=2;
            //    Console.WriteLine(i + ". saat sonunda "+bacterium +" adet bakteri oluştu");
            //}
            //Console.WriteLine("toplam " + bacterium);
            #endregion

            #region while loops
            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //while(i<10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i < 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region ex1
            //Console.WriteLine("3 basamaklı sayı giriniz...");
            //int num = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //ones = num % 10;
            //tens = (num % 100) / 10;
            //hundreds = num / 100;
            //Console.WriteLine(ones + " - " + tens + " - " + hundreds);
            //Console.WriteLine(ones + tens + hundreds);

            //Console.WriteLine("bir sayı giriniz...");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (num != 0)
            //{
            //    sum += num%10;
            //    num = num/10;
            //}
            //Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
