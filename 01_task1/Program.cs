using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hellooo");
            //Console.Write("Hello World!");
            #region printing commands
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar ");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Başlangıçlar");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6 - İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            #endregion

            #region string variables
            //string name;
            //name = "ayfer";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district, city;
            //customerName = "Ayfer";
            //customerSurname = "Şahin";
            //customerEmail = "test@gmail.com";
            //customerPhone = "11111111111";
            //district = "Şahinbey";
            //city = "Gaziantep";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Eposta: "+ customerEmail);
            //Console.WriteLine("Adres: "+ district + "/" +  city);
            //Console.WriteLine("------------------------------------------------");

            //customerName = "Can";
            //customerSurname = "Şahin";
            //customerEmail = "test@gmail.com";
            //customerPhone = "11111155511";
            //district = "Oğuzeli";
            //city = "Gaziantep";


            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Eposta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            #endregion

            #region
            //int number = 28;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 40;
            int waterPrice = 10;
            int pizzaPrice = 100;
            int lemonadePrice = 75;
            Console.WriteLine("***** Restoran Menü *****");
            Console.WriteLine();
            Console.WriteLine("-- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-- Kola: " + cokePrice + "TL");
            Console.WriteLine("-- Su: " + waterPrice + "TL");
            Console.WriteLine("-- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("***************************************");

            int hamburgerCount, cokeCount, waterCount, pizzaCount, lemonadeCount;

            hamburgerCount = 1;
            cokeCount = 4;
            pizzaCount = 3;
            waterCount = 5;
            lemonadeCount = 1;

            int totalHamburgerPrice=0;
            int totalCokePrice=0;
            int totalWaterPrice=0;
            int totalPizzaPrice=0;
            int totalLemonadePrice=0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;


            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("-- Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("-- Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("-- Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("-- Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("-- Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("***************************************");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalPizzaPrice+ totalLemonadePrice;
            Console.WriteLine() ;
            Console.WriteLine("-- Toplam Tutar: " + totalPrice + "TL");


            #endregion

            Console.Read();
        }
    }
}
