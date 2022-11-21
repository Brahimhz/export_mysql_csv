// See https://aka.ms/new-console-template for more information
using export_mysql_csv;
using MySql.Data.MySqlClient;
using System.Data;


Console.WriteLine("Hello, World!");
/*
DataTable dataTable = new DataTable();

string connString = @"server=localhost;uid=root;pwd=1234;database=world";
string query = "select * from country";

MySqlConnection conn = new MySqlConnection(connString);
MySqlCommand cmd = new MySqlCommand(query, conn);
conn.Open();

// create data adapter
MySqlDataAdapter da = new MySqlDataAdapter(cmd);
// this will query your database and return the result to your datatable
da.Fill(dataTable);
conn.Close();
da.Dispose();

CSVUtlity.ToCSV(dataTable, @"C:\Temp\test.csv");
*/

List<Product> products = new List<Product>();
products.Add(new Product { Name = "Name1", Country = "Country1", Description = "Description1", Price = 1, LaunchDate = DateTime.Now });
products.Add(new Product { Name = "Name2", Country = "Country2", Description = "Description2", Price = 2, LaunchDate = DateTime.Now });
products.Add(new Product { Name = "Name3", Country = "Country3", Description = "Description3", Price = 3, LaunchDate = DateTime.Now });
products.Add(new Product { Name = "Name4", Country = "Country4", Description = "Description4", Price = 4, LaunchDate = DateTime.Now });
products.Add(new Product { Name = "Name5", Country = "Country5", Description = "Description5", Price = 5, LaunchDate = DateTime.Now });

CSVUtlity.ObjectToCSV<Product>(products);

Console.ReadLine();
