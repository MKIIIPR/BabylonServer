using System;
using Npgsql;

class Program
{
    static void Main()
    {
        var connectionString = "Host=db.hwnllbmmkraninmpxjbv.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=Test123§\"!#TEst!";

        try
        {
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("✅ Verbindung erfolgreich!");

            using var command = new NpgsqlCommand("SELECT NOW();", connection);
            var result = command.ExecuteScalar();
            Console.WriteLine($"📅 Serverzeit: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Verbindung fehlgeschlagen:");
            Console.WriteLine(ex.Message);
        }
    }
}
