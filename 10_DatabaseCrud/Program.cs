using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD --> Crate-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Eklemek istediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=EgitimKampiDb;integrated security=true");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)" , connection);
            command.Parameters.AddWithValue("@p1", categoryName);

            Console.Read();
        }
    }
}
