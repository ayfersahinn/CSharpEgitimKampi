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
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-5ANGUIR\\SQLEXPRESS02;Initial Catalog=egitimKampi;Integrated Security=True;Encrypt=False");
            #region adding category 
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("insert into categories (CategoryName) values (@p1)",sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@p1",categoryName);
            //sqlCommand.ExecuteNonQuery();
            //Console.WriteLine("Kategori başarıyla eklendi");
            //sqlConnection.Close();
            #endregion
            #region adding product
            string productName;
            decimal productPrice;
            bool productStatus;
            Console.Write("Ürün adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into products (ProductName, ProductPrice, ProductStatus) values (@p1, @p2, @p3)",sqlConnection);
            cmd.Parameters.AddWithValue("@p1", productName);
            cmd.Parameters.AddWithValue("@p2", productPrice);
            cmd.Parameters.AddWithValue("@p3", true);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Ürün başarıyla eklendi");
            sqlConnection.Close();
            #endregion
            Console.Read();
        }
    }
}
