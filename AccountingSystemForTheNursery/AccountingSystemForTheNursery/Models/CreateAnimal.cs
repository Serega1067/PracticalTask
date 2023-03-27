using AccountingSystemForTheNursery.Models.Animals;
using AccountingSystemForTheNursery.Models.Animals.ImpPackAnimals;
using AccountingSystemForTheNursery.Models.Animals.ImpPets;

namespace AccountingSystemForTheNursery.Models
{
    public class CreateAnimal
    {
        public static Animal create(string item)
        {
            switch (item)
            {
                case "Camel": return new Camel();
                case "Donkey": return new Donkey();
                case "Horse": return new Horse();
                case "Dog": return new Dog();
                case "Cat": return new Cat();
                case "Hamster": return new Hamster();
                default: return new Animal();
            }
        }
    }
}
