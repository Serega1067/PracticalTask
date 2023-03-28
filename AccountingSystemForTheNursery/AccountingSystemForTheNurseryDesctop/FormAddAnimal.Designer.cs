namespace AccountingSystemForTheNurseryDesctop
{
    partial class FormAddAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCommands = new System.Windows.Forms.Label();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelType = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Шарик";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(166, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(207, 71);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(277, 20);
            this.dateTimePickerBirthday.TabIndex = 3;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AccessibleDescription = "";
            this.comboBoxType.AccessibleName = "";
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Кошка",
            "Собака",
            "Хомяк",
            "Осёл",
            "Лошадь",
            "Верблюд"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 71);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(178, 21);
            this.comboBoxType.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            // 
            // labelCommands
            // 
            this.labelCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCommands.AutoSize = true;
            this.labelCommands.Location = new System.Drawing.Point(323, 9);
            this.labelCommands.Name = "labelCommands";
            this.labelCommands.Size = new System.Drawing.Size(54, 13);
            this.labelCommands.TabIndex = 8;
            this.labelCommands.Text = "Команды";
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Location = new System.Drawing.Point(207, 25);
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(277, 20);
            this.textBoxCommands.TabIndex = 7;
            this.textBoxCommands.Text = "Лаять, Спать";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "222";
            this.toolTip1.ToolTipTitle = "В";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(68, 55);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(83, 13);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Вид животного";
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(304, 55);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(92, 13);
            this.labelBirthday.TabIndex = 10;
            this.labelBirthday.Text = "Дата рождениия";
            // 
            // FormAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 143);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCommands);
            this.Controls.Add(this.textBoxCommands);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddAnimal";
            this.Text = "Добавление нового животного";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCommands;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelBirthday;
        protected System.Windows.Forms.TextBox textBoxName;
        protected System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        protected System.Windows.Forms.ComboBox comboBoxType;
        protected System.Windows.Forms.TextBox textBoxCommands;
        private System.Windows.Forms.Button buttonAdd;
    }
}