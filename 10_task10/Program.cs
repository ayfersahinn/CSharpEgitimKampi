using System;
using System.Collections.Generic;
using System.Data;
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
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            #region adding category 

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
            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("insert into products (ProductName, ProductPrice, ProductStatus) values (@p1, @p2, @p3)",sqlConnection);
            //cmd.Parameters.AddWithValue("@p1", productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", true);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Ürün başarıyla eklendi");
            //sqlConnection.Close();
            #endregion

            #region listing products
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("select *from products", sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach(var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //sqlConnection.Close();
            #endregion

            #region deleting product
            int delID;
            Console.Write("Silinecek ürünün id sini giriniz: ");
            delID = int.Parse(Console.ReadLine());
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("delete from products where ProductID = @pID", sqlConnection);
            cmd.Parameters.AddWithValue("@pID",delID);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Silme işlemi başarılı");
            sqlConnection.Close();
            #endregion
            Console.Read();
        }
    }
}
