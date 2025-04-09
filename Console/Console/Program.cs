﻿using System;
using Npgsql;

class Program
{
    static void Main()
    {
        var connectionString = "Host=db.hwnllbmmkraninmpxjbv.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=MySecurePass123!";
        var connectionString2 = "Host=db.hwnllbmmkraninmpxjbv.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=MySecurePass123!";

        try
        {
            using var connection = new NpgsqlConnection(connectionString2);
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
