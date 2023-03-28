namespace AccountingSystemForTheNurseryDesctop
{
    partial class FormAddCommands
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

            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCommands = new System.Windows.Forms.Label();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(304, 58);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(92, 13);
            this.labelBirthday.TabIndex = 19;
            this.labelBirthday.Text = "Дата рождениия";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(68, 58);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(83, 13);
            this.labelType.TabIndex = 18;
            this.labelType.Text = "Вид животного";
            // 
            // labelCommands
            // 
            this.labelCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCommands.AutoSize = true;
            this.labelCommands.Location = new System.Drawing.Point(323, 12);
            this.labelCommands.Name = "labelCommands";
            this.labelCommands.Size = new System.Drawing.Size(54, 13);
            this.labelCommands.TabIndex = 17;
            this.labelCommands.Text = "Команды";
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Location = new System.Drawing.Point(207, 28);
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(277, 20);
            this.textBoxCommands.TabIndex = 16;
            this.textBoxCommands.Text = "Лаять, Спать";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Имя";
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
            this.comboBoxType.Location = new System.Drawing.Point(12, 74);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(178, 21);
            this.comboBoxType.TabIndex = 14;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(207, 74);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(277, 20);
            this.dateTimePickerBirthday.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(151, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.Text = "Шарик";
            // 
            // FormAddCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 151);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCommands);
            this.Controls.Add(this.textBoxCommands);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddCommands";
            this.Text = "Добавление команды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCommands;
        protected System.Windows.Forms.TextBox textBoxCommands;
        private System.Windows.Forms.Label labelName;
        protected System.Windows.Forms.ComboBox comboBoxType;
        protected System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Button buttonAdd;
        protected System.Windows.Forms.TextBox textBoxName;
    }
}