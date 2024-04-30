Here's what's changed:

We added the System.Data.Linq and System.Linq namespaces.
We created a DataContext object, which is the LINQ to SQL equivalent of a database connection.
We defined a Customer class, which represents a row in the Customers table. We decorated the class and its properties with Table and Column attributes to map them to the database table and columns.
We used the ExecuteQuery method to execute the SQL query and retrieve the results as a collection of Customer objects.
We looped through the results using a foreach loop and printed out the values of each column using string interpolation.
Note that in this example, I assumed that the Customers table has columns named CustomerID, CompanyName, ContactName, and Country. You may need to adjust the Customer class and the Console.WriteLine statement to match your actual table schema.
