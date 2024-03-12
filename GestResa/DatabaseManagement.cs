using MySql.Data.MySqlClient;
using System;

public static class DatabaseManager
{
    private static string connectionString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";

    public static MySqlConnection GetConnection()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erreur de connexion à la base de données: " + ex.Message);
        }
        return connection;
    }
}
