using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region methods
            //void customerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayfer şahin");
            //    Console.WriteLine("can budak");
            //    Console.WriteLine("betül kılıç");
            //}
            //customerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion
            #region methods with parameters
            //void hello(string s)
            //{
            //    Console.WriteLine("hello "+s);
            //}
            //hello("ayfer");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("hoşgeldiniz "+name+" "+surname);
            //}
            //CustomerCard("ayfer", "şahin");

            //void Sum(int x, int y, int z)
            //{
            //    int result = x+ y + z;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 9, 8);
            #endregion

            #region methods returning value
            //string Name()
            //{
            //    return "ayşe";
            //}
            //Console.WriteLine(Name());

            //string CustomerCard()
            //{
            //    string name = "ayfer";
            //    string surname = "sahin";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(CustomerCard());

            //string CountryCard(string countryName, string capitalCity, string flag)
            //{
            //    return countryName + "-" + capitalCity + "-" + flag;
            //}
            //string x, y, z;
            //Console.Write("Ülke ismi giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkentini giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrağını giriniz: ");
            //z= Console.ReadLine();
            //Console.WriteLine(CountryCard(x,y,z));,

            //int Sum(int x, int y) {
            //    int result = x + y;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(18, 2));
            //Console.WriteLine(Sum(1, 22));
            //Console.WriteLine(Sum(15, 28));

            string ExamResult(string name, int ex1, int ex2, int ex3)
            {
                int result = (ex1 + ex2 + ex3) / 3;
                if(result > 50)
                {
                    return name + " isimli öğrenci " +result+" ortalama ile "+ "dersi geçti";
                }
                else
                {
                    return name + " isimli öğrenci " + result + " ortalama ile " + "dersten kaldı";
                }
            }
            Console.WriteLine(ExamResult("ali", 56, 18, 56));
            Console.WriteLine(ExamResult("ayşe", 76, 78, 56));
            #endregion
            Console.Read();
        }
    }
}
