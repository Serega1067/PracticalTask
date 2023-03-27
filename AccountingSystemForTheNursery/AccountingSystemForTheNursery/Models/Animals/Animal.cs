using System.Data.SQLite;
using AccountingSystemForTheNursery.Models.Commands;

namespace AccountingSystemForTheNursery.Models.Animals
{
    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // public string AnimalClass { get; set; }

        public List<string> Commands { get; set; }

        public DateTime Birthday { get; set; }

        public string Type { get; set; }

        public Animal()
        {
            Name = string.Empty;
            Commands = new List<string>();
        }

        public void Voise()
        {
        }

        public void Sleep()
        {
        }

        public void Eat()
        {
        }
    }
}
