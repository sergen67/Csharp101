using System;
using System.Collections.Generic;
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
            Console.Write("Eklemek istediğiniz kategori adı:");
            string categoryName = Console.ReadLine();


            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-OBIK10F;initial catalog = EgitimKampidb;integrated security = true ");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into Table_1(CategoryName) values (@p1)",connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori Başarı ile Eklendi!");
            
            
            
            Console.Read();

        }
    }
}
