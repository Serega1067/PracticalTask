using AccountingSystemForTheNursery.Models.Animals;
using System.Data.SQLite;
using AccountingSystemForTheNursery.Models;

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
                command.CommandText = "INSERT INTO animals(" +
                    "Name, Type, Commands, Birthday) " +
                    "VALUES(@Name, @Type, @Commands, @Birthday)";
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Type", item.Type);
                command.Parameters.AddWithValue("@Commands", 
                                                 string.Join(", ", item.Commands));
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
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
                                      "WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", id);
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
            List<Animal> list = new List<Animal>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM animals";
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Animal animal = new Animal
                    Animal animal = CreateAnimal.create(reader.GetString(2));
                    animal.Id = reader.GetInt32(0);
                    animal.Name = reader.GetString(1);
                    // animal = CreateAnimal.create(reader.GetString(2)),
                    animal.Commands = reader.GetString(3).Split(", ").ToList();
                    animal.Birthday = new DateTime(reader.GetInt64(4));

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
            List<Animal> list = new List<Animal>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на получение данных
                // по конкретному клиенту
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM animals " +
                                      "WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", id);
                // Подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read()) // Если удалось что-то прочитать
                {
                    // возвращаем прочитанное
                    // return new Animal
                    Animal animal = CreateAnimal.create(reader.GetString(2));
                    animal.Id = reader.GetInt32(0);
                    animal.Name = reader.GetString(1);
                    animal.Commands = reader.GetString(3).Split(", ").ToList();
                    animal.Birthday = new DateTime(reader.GetInt64(4));
                    return animal;
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
                                      "Name = @Name, " +
                                      "Type = @Type, " +
                                      "Commands = @Commands, " +
                                      "Birthday = @Birthday " +
                                      "WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Type", item.Type);
                command.Parameters.AddWithValue("@Commands", 
                                                 string.Join(", ", item.Commands));
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
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
