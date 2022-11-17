// See https://aka.ms/new-console-template for more information
using export_mysql_csv;
using MySql.Data.MySqlClient;
using System.Data;


Console.WriteLine("Hello, World!");

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

Console.ReadLine();
