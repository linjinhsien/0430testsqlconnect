using System;
using System.Data.SqlClient;

namespace THM104_G2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            string query = "select * from customers";
            SqlCommand cmd = new SqlCommand(query, cn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Print out the values of each column
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetValue(i) + "\t");
                }
                Console.WriteLine(); // Move to the next line
            }

            Console.WriteLine("左輔掀洞庭");
        }
    }
}
