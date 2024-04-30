Here's what's changed:

We added the System.Data.Linq and System.Linq namespaces.
We created a DataContext object, which is the LINQ to SQL equivalent of a database connection.
We defined a Customer class, which represents a row in the Customers table. We decorated the class and its properties with Table and Column attributes to map them to the database table and columns.
We used the ExecuteQuery method to execute the SQL query and retrieve the results as a collection of Customer objects.
We looped through the results using a foreach loop and printed out the values of each column using string interpolation.
Note that in this example, I assumed that the Customers table has columns named CustomerID, CompanyName, ContactName, and Country. You may need to adjust the Customer class and the Console.WriteLine statement to match your actual table schema.


# System.Data.Linq && System.Data.Linq.Mapping

System.Data.Linq 和 System.Data.Linq.Mapping 是LINQ to SQL的一部分，它們在.NET框架中提供對關係數據庫的訪問和操作。以下是它們的主要區別和用途：

## System.Data.Linq
System.Data.Linq 命名空間包含了LINQ to SQL的核心功能，它允許你創建、修改、和管理關係數據庫的數據。這個命名空間中最重要的類別是 DataContext，它是所有LINQ to SQL操作的起點。DataContext 提供了映射到數據庫的連接和執行查詢的能力。

## System.Data.Linq.Mapping
System.Data.Linq.Mapping 命名空間包含了與數據庫表格映射相關的屬性和類別。這些屬性如 Table 和 Column 被用來標記實體類別和屬性，以定義它們與數據庫表格和欄位之間的映射關係。這樣，LINQ to SQL就可以知道如何將數據庫的數據轉換成對象，反之亦然2。

總的來說，System.Data.Linq 提供了與數據庫交互的基本工具，而 System.Data.Linq.Mapping 則提供了將C#類別與數據庫表格關聯起來的映射機制。這兩個命名空間共同工作，使得LINQ to SQL能夠有效地操作關係數據庫。如果你想了解更多關於LINQ to SQL的信息，可以參考Microsoft Learn上的官方文檔。希望這些信息對你有幫助！
