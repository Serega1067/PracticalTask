namespace AccountingSystemForTheNursery.Models.Requests
{
    public class UpdateAnimalRequest
    {
        public int AnimalId { get; set; }

        public string AnimalName { get; set; }

        public string AnimalClass { get; set; }

        public string ListOfAnimalCommands { get; set; }
    }
}
