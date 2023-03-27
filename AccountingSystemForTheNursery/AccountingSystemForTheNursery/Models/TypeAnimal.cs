using AccountingSystemForTheNursery.Models.Animals;

namespace AccountingSystemForTheNursery.Models
{
    public class TypeAnimal
    {
        public enum Type
        {
            Camel,
            Horse,
            Donkey,
            Cat,
            Dog,
            Hamster
        };

        public static string getType(Type item)
        {
            switch (item)
            {
                case Type.Camel: return "Camel";
                case Type.Horse: return "Horse";
                case Type.Donkey: return "Donkey";
                case Type.Cat: return "Cat";
                case Type.Dog: return "Dog";
                case Type.Hamster: return "Hamster";
                default: return null;
            }
        }
    }
}
