using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.Write("Eklemek istediğiniz kategori adı: ");
            string categoryName = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-5ANGUIR\\SQLEXPRESS02;Initial Catalog=egitimKampi;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into categories (CategoryName) values (@p1)",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",categoryName);
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Kategori başarıyla eklendi");
            sqlConnection.Close();

            Console.Read();
        }
    }
}
