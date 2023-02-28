namespace AccountingSystemForTheNursery.Models.Requests
{
    public class CreateAnimalRequest
    {
        public string AnimalName { get; set; }

        public string AnimalClass { get; set; }

        public string ListOfAnimalCommands { get; set; }
    }
}
