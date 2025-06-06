using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace BeerCollection.Data
{
    public static class DatabaseInitializer
    {
        private static readonly string DbFilePath = Path.Combine(AppContext.BaseDirectory, "BeerCollection.db");

        
        private static readonly string SqlFilePath = Path.Combine(AppContext.BaseDirectory, "beers.sql");

        public static void Initialize()
        {
            if (File.Exists(DbFilePath))
            {
                Console.WriteLine("Baza danych już istnieje.");
                return;
            }

            Console.WriteLine("Tworzenie nowej bazy danych...");

            using var connection = new SqliteConnection($"Data Source={DbFilePath}");
            connection.Open();

            if (!File.Exists(SqlFilePath))
            {
                Console.WriteLine($"Nie znaleziono pliku SQL: {SqlFilePath}");
                return;
            }

            var sqlScript = File.ReadAllText(SqlFilePath);

           
            var commands = sqlScript.Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var cmdText in commands)
            {
                var trimmedCmd = cmdText.Trim();
                if (string.IsNullOrWhiteSpace(trimmedCmd))
                    continue;

                using var command = connection.CreateCommand();
                command.CommandText = trimmedCmd + ";";

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd podczas wykonywania SQL:\n{ex.Message}\nPolecenie:\n{trimmedCmd}");
                }
            }

            Console.WriteLine("Inicjalizacja bazy danych zakończona.");
        }
    }
}
