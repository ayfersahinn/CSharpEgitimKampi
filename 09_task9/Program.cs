using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region database basics
            Console.WriteLine("Ürün Kategori Bilgi Sistemi");
            Console.WriteLine();
            string tableNo;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNo = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-5ANGUIR\\SQLEXPRESS02;Initial Catalog=egitimKampi;Integrated Security=True;Encrypt=False");

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select *from categories",sqlConnection); 
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            sqlConnection.Close();
            #endregion
            Console.Read();
        }
    }
}
