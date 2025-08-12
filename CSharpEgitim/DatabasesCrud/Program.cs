using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud->Create-Read-Update-Delete
            Console.WriteLine("***** Menü Sipariş İşlem *****");
            Console.WriteLine();

            Console.WriteLine("----------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı:");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-OBIK10F;initial catalog = EgitimKampidb;integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Table_1(CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarı ile Eklendi!");
            #endregion
            #region Ürün ekleme işlemi
            //string ProductName;
            //decimal ProductPrice;
            //bool ProductStatus;

            //Console.Write("Eklemek İstediğiniz Ürünün ADı: ");
            //ProductName = Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz Ürünün Fiyatı: ");
            //ProductPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source = DESKTOP-OBIK10F;initial catalog = EgitimKampidb;integrated security = true ");
            //conn.Open();
            //SqlCommand comm = new SqlCommand("insert into Table_2(ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", conn);
            //comm.Parameters.AddWithValue("@p1", ProductName);
            //comm.Parameters.AddWithValue("@p2", ProductPrice);
            //comm.Parameters.AddWithValue("@p3", true);
            //comm.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Ürün Başarı ile Eklendi!");
            #endregion
            #region Ürün listeleme işlemi

            //SqlConnection conn = new SqlConnection("Data Source = DESKTOP-OBIK10F;initial catalog = EgitimKampidb;integrated security = true ");
            //conn.Open();
            //SqlCommand comm = new SqlCommand("select * from Table_2", conn);
            //SqlDataAdapter adp = new SqlDataAdapter(comm);
            //DataTable dT = new DataTable();
            //adp.Fill(dT);
            //foreach (DataRow row in dT.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //conn.Close();


            #endregion
            #region ÜrünSilme İşlemi

            //Console.Write("Silmek istediğiniz ürünün Id'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source = DESKTOP-OBIK10F;initial catalog = EgitimKampidb;integrated security = true ");
            //conn.Open();

            //SqlCommand comn = new SqlCommand("Delete from Table_2 Where ProductId = @productId",conn);
            //comn.Parameters.AddWithValue("@productId", productId);
            //comn.ExecuteNonQuery();

            //conn.Close();

            //Console.WriteLine("Ürün Başarı ile Silindi!");

            #endregion
            #region Ürün Güncelleme İşlemi

            //Console.WriteLine("Güncellemek istediğiniz ürünün Id giriniz.");
            //int productId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Güncellemek istediğiniz ürünün adını giriniz.");
            //string productName = Console.ReadLine();    
            //Console.WriteLine("Güncellemek istediğiniz ürünün fiyatını giriniz.");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection conn = new SqlConnection("Data Source = DESKTOP-OBIK10F;initial catalog = EgitimKampidb;integrated security = true ");
            //conn.Open();

            //SqlCommand comn = new SqlCommand("Update Table_2 set ProductName = @productName ,ProductPrice = @productPrice where ProductId = @productId",conn);
            //comn.Parameters.AddWithValue("@productId", productId);
            //comn.Parameters.AddWithValue("@productName", productName);
            //comn.Parameters.AddWithValue("@productPrice", productPrice);
            //comn.ExecuteNonQuery();


            //conn.Close();

            //Console.WriteLine("Ürün Başarı ile Güncellendi!");

            #endregion

            Console.Read();

        }
    }
}
