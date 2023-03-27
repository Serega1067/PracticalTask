namespace AccountingSystemForTheNursery.Models.Commands
{
    public class Command
    {
        public string Name { get; set; }

        public Command(string item)
        {
            Name = item;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
