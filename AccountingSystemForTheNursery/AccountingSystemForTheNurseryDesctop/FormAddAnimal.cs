using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalServicesClientNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace AccountingSystemForTheNurseryDesctop
{
    public partial class FormAddAnimal : Form
    {
        public FormAddAnimal()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.buttonAdd, "Добавить животное");
            toolTip1.SetToolTip(this.textBoxCommands, "Ввод по очерди через пробел");
            comboBoxType.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAnimalRequest animal = new CreateAnimalRequest();
            if (textBoxName.Text == string.Empty || textBoxCommands.Text == string.Empty)
            {
                throw new NotImplementedException("Введено пустое поле!");

            }
            animal.Name = textBoxName.Text;
            animal.Commands = textBoxCommands.Text;
            switch (comboBoxType.Text)
            {
                case "Кошка":
                    animal.Type = "Cat";
                    break;
                case "Собака":
                    animal.Type = "Dog";
                    break;
                case "Хомяк":
                    animal.Type = "Hamster";
                    break;
                case "Осёл":
                    animal.Type = "Donkey";
                    break;
                case "Лошадь":
                    animal.Type = "Horse";
                    break;
                case "Верблюд":
                    animal.Type = "Camel";
                    break;
            }
            animal.Birthday = dateTimePickerBirthday.Value;


            AnimalServicesClient animalNurseryClient = new AnimalServicesClient("http://localhost:5294/",
            new System.Net.Http.HttpClient());

            animalNurseryClient.CreateAsync(animal);

            Close();
        }
    }
}
