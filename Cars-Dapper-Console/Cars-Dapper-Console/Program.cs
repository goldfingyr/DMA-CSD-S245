// See https://aka.ms/new-console-template for more information
using Cars_Dapper_Console;
using Dapper;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");


string connectionString = "Data Source=localhost;Initial Catalog=Cars;User ID=sa;Password=@12tf56so;Trust Server Certificate=True";

SqlConnection db = new SqlConnection(connectionString);
db.Open();

List<Car> Cars=db.Query<Car>("SELECT * FROM Cars").ToList();
Console.WriteLine("");