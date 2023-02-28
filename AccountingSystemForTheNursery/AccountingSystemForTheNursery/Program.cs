using AccountingSystemForTheNursery.Services;
using AccountingSystemForTheNursery.Services.Impl;
using System.Data.SQLite;

namespace AccountingSystemForTheNursery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Запускаем связь с базой данных
            // ConfigureSqlLiteConnection();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Зарегистрируем новый сервис
            builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void ConfigureSqlLiteConnection()
        {
            const string connectionString = "Data Source = registry.db; " +
                                            "Version = 3; " +
                                            "Pooling = true; " +
                                            "Max Pool Size = 100;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            PrepareScheme(connection);
        }

        private static void PrepareScheme(SQLiteConnection connection)
        {
            SQLiteCommand command = new SQLiteCommand(connection);

            /*
            command.CommandText = "DROP TABLE IF EXISTS Animals";
            command.ExecuteNonQuery();
            */

            command.CommandText = @"CREATE TABLE Animals(
                                    AnimalId INTEGER PRIMARY KEY,
                                    AnimalName TEXT,
                                    AnimalClass TEXT,
                                    ListOfAnimalCommands TEXT)";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}