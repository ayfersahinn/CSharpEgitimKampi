using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if
            //Console.WriteLine("Şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış.");
            //}

            //string city, country;
            //Console.Write("Şehir giriniz: ");
            //city = Console.ReadLine();
            //Console.Write("ülke giriniz: ");
            //country = Console.ReadLine();
            //if(city=="ankara" && country=="türkiye")
            //{
            //    Console.WriteLine("bilgiler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.Write("sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}

            //int exam1, exam2, exam3, avg;
            //string result;
            //Console.Write("sınav 1 giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav 2 giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav 3 giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avg = (exam1 + exam2 + exam3)/3;

            //Console.WriteLine("ortalama: " + avg);

            //if(avg>0 && avg <= 50)
            //{
            //    Console.WriteLine("zayıf");
            //}
            //else if(avg>50 && avg <= 70)
            //{
            //    Console.WriteLine("orta");
            //}
            //else if(avg>70 && avg <= 84)
            //{
            //    Console.WriteLine("iyi");
            //}
            //else if(avg>84 && avg <= 100)
            //{
            //    Console.WriteLine("çok iyi");
            //}
            //else
            //{
            //    Console.WriteLine("lütfen belirtilen aralıkta değer giriniz");
            //}

            //Console.Write("Lütfen şehir giriniz: ");
            //string city;
            //city = Console.ReadLine();
            //if (city == "ankara" || city== "bursa" || city== "samsun" || city== "istanbul") 
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //string userName;
            //Console.Write("kullanıcı adı giriniz: ");
            //userName = Console.ReadLine();
            //if(userName != "admin")
            //{
            //    Console.WriteLine("kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("kullanıcı girişi başarılı");
            //}



            #endregion


            #region mod
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //int num1, num2;

            //Console.Write("birinci sayıyı giriniz: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayıyı giriniz: ");
            //num2 = int.Parse(Console.ReadLine());

            //int result = num1 % num2;
            //Console.WriteLine("sonuç: " + result);



            #endregion

            #region even - odd
            //int num1;
            //Console.Write("sayı giriniz: ");
            //num1 = int.Parse(Console.ReadLine());
            //if(num1 % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}



            #endregion

            #region char
            //char team;
            //Console.Write("takım harfi giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team == 'b' | team== 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Belirtilen harf ile eşleşen takım bulunamadı");
            //}
            #endregion

            #region if project
            //Console.WriteLine("***** Restoran *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("1- Ana yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Menü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------- Ana yemekler -----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Patates Kızartması");
            //    Console.WriteLine("2- Köri soslu tavuk");
            //    Console.WriteLine("3- İskender");
            //    Console.WriteLine("4- Tavuk döner");
            //    Console.WriteLine("5- Köfte ekmek");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------- Çorbalar -----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek çorbası");
            //    Console.WriteLine("2- Ezogelin çorbası");
            //    Console.WriteLine("3- Tarhana çorbası");
            //    Console.WriteLine("4- Tavuk çorbası");
            //    Console.WriteLine("5- Ayran çorbası");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------- Pizzalar -----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Sucuklu kaşarlı pizza");
            //    Console.WriteLine("2- Mantarlı pizza");
            //    Console.WriteLine("3- Ananaslı pizza");
            //    Console.WriteLine("4- Meksika pizza");
            //    Console.WriteLine("5- Karışık pizza");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------- İçecekler -----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Soda");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("4- Ayran");
            //    Console.WriteLine("5- Çay");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------------- Tatlılar -----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Cheesecake");
            //    Console.WriteLine("4- Ekler");
            //    Console.WriteLine("5- Kıbrıs tatlısı");
            //    Console.WriteLine();
            //}
            #endregion

            #region switch case
            //int month;
            //Console.Write("kaçıncı ay giriniz: ");
            //month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1: Console.Write("ocak"); break;
            //    case 2: Console.Write("şubat"); break;
            //    case 3: Console.Write("mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralık"); break;
            //    default: Console.WriteLine("belirtilen ay bulunamadı");break;
            //}
            #endregion

            #region switch calculator
            char symbol;
            int num1, num2, result;
            Console.Write("birinci sayıyı giriniz: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("bir işlem giriniz: ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("toplam: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("çıkarma sonucu: " + result);

                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("çarpım: " + result);

                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("bölüm: " + result);

                    break;
                default:
                    Console.WriteLine("geçerli işlem girmediniz..");
                    break;
            }
            #endregion
            Console.Read();
        }
    }
}
