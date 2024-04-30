using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

// 定義命名空間THM104_G2
namespace THM104_G2
{
    // 定義內部類別Program
    internal class Program
    {
        // 主要進入點
        static void Main(string[] args)
        {
            // 連接字串指向本地資料庫
            var connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Northwind;Integrated Security=True";
            // 建立資料上下文
            var ctx = new DataContext(connectionString);

            // 執行SQL查詢並將結果映射到Customer類別
            var customers = ctx.ExecuteQuery<Customer>("SELECT * FROM Customers");

            // 遍歷每個客戶並列印資訊
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID}\t{customer.CompanyName}\t{customer.ContactName}\t{customer.Country}");
            }

            // 輸出一條訊息
            Console.WriteLine("Esther好想睡覺");
        }
    }

    // 定義與資料庫表格對應的類別
    [Table(Name = "Customers")]
    public class Customer
    {
        // 定義與資料庫欄位對應的屬性
        [Column]
        public string CustomerID { get; set; }
        [Column]
        public string CompanyName { get; set; }
        [Column]
        public string ContactName { get; set; }
        [Column]
        public string Country { get; set; }
    }
}
