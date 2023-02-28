using AccountingSystemForTheNursery.Models;
using System.Data.SQLite;

namespace AccountingSystemForTheNursery.Services.Impl
{
    public class AnimalRepository : IAnimalRepository
    {
        private const string connectionString = "Data Source = registry.db; " +
            "Version = 3; Pooling = true; Max Pool Size = 100;";
        public int Create(Animal item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO animals(AnimalName, AnimalClass, ListOfAnimalCommands) VALUES(@AnimalName, @AnimalClass, @ListOfAnimalCommands)";
                command.Parameters.AddWithValue("@AnimalName", item.AnimalName);
                command.Parameters.AddWithValue("@AnimalClass", item.AnimalClass);
                command.Parameters.AddWithValue("@ListOfAnimalCommands", item.ListOfAnimalCommands);
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Delete(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на удаление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM animals " +
                                      "WHERE AnimalId = @AnimalId";
                command.Parameters.AddWithValue("@AnimalId", id);
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public IList<Animal> GetAll()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            List<Animal> list = new List<Animal>();
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM animals ";
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Animal animal = new Animal
                    {
                        AnimalId = reader.GetInt32(0),
                        AnimalName = reader.GetString(1),
                        AnimalClass = reader.GetString(2),
                        ListOfAnimalCommands = reader.GetString(3)
                    };

                    list.Add(animal);
                }
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public Animal GetById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных
                // по конкретному клиенту
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM animals " +
                                      "WHERE AnimalId = @AnimalId";
                command.Parameters.AddWithValue("@AnimalId", id);
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read()) // Если удалось что-то прочитать
                {
                    // возвращаем прочитанное
                    return new Animal
                    {
                        AnimalId = reader.GetInt32(0),
                        AnimalName = reader.GetString(1),
                        AnimalClass = reader.GetString(2),
                        ListOfAnimalCommands = reader.GetString(3)
                    };
                }
                else
                {
                    // Не нашлась запись по идентификатору
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public int Update(Animal item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "UPDATE animals SET " +
                    "AnimalName = @AnimalName, " +
                    "AnimalClass = @AnimalClass, " +
                    "ListOfAnimalCommands = @ListOfAnimalCommands, " +
                    "WHERE AnimalId = @AnimalId";
                command.Parameters.AddWithValue("@AnimalId", item.AnimalId);
                command.Parameters.AddWithValue("@AnimalName", item.AnimalName);
                command.Parameters.AddWithValue("@AnimalClass", item.AnimalClass);
                command.Parameters.AddWithValue("@ListOfAnimalCommands", item.ListOfAnimalCommands);
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
