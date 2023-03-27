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

namespace AccountingSystemForTheNurseryDesctop
{
    public partial class FormUpdateAnimal : Form
    {
        Animal _animal = new Animal();
        public FormUpdateAnimal(Animal item)
        {
            InitializeComponent();
            _animal = item;
            fillForm();
        }

        public FormUpdateAnimal(ListViewItem item)
        {
            InitializeComponent();
            _animal.Id = int.Parse(item.SubItems[0].Text);
            _animal.Name = item.SubItems[1].Text;
            switch (item.SubItems[2].Text)
            {
                case "Кошка":
                    _animal.Type = "Cat";
                    break;
                case "Собака":
                    _animal.Type = "Dog";
                    break;
                case "Хомяк":
                    _animal.Type = "Hamster";
                    break;
                case "Осёл":
                    _animal.Type = "Donkey";
                    break;
                case "Лошадь":
                    _animal.Type = "Horse";
                    break;
                case "Верблюд":
                    _animal.Type = "Camel";
                    break;
            }
            _animal.Commands = item.SubItems[3].Text.Trim(' ')
                                                    .Split(',')
                                                    .ToList();
            _animal.Birthday = DateTime.Parse(item.SubItems[4].Text);
            fillForm();
        }

        private void fillForm()
        {
            textBoxName.Text = _animal.Name;
            textBoxName.ReadOnly = true;

            //comboBoxType.Text = _animal.Type;

            switch (_animal.Type)
            {
                case "Cat":
                    comboBoxType.SelectedIndex = 0;
                    break;
                case "Dog":
                    comboBoxType.SelectedIndex = 1;
                    break;
                case "Hamster":
                    comboBoxType.SelectedIndex = 2;
                    break;
                case "Donkey":
                    comboBoxType.SelectedIndex = 3;
                    break;
                case "Horse":
                    comboBoxType.SelectedIndex = 4;
                    break;
                case "Camel":
                    comboBoxType.SelectedIndex = 5;
                    break;
            }

            dateTimePickerBirthday.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthday.Value = _animal.Birthday.Date;
            dateTimePickerBirthday.Enabled = false;

            textBoxCommands.Text = string.Join(", ", _animal.Commands);

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateAnimalRequest animal = new UpdateAnimalRequest();
            animal.Id = _animal.Id;
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

            AnimalServicesClient animalServicesClient = new AnimalServicesClient("http://localhost:5294/",
            new System.Net.Http.HttpClient());

            animalServicesClient.UpdateAsync(animal);

            Close();
        }
    }
}
