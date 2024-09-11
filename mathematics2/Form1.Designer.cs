namespace mathematics2
{
    partial class MaximumLevelLabel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeroNameLabel = new Label();
            HeroName = new TextBox();
            HeroMass = new TextBox();
            HeroMassLabel = new Label();
            EatableMass = new TextBox();
            EatableMassLabel = new Label();
            FuelType = new TextBox();
            FuelTypeLabel = new Label();
            UpdateButton = new Button();
            label2 = new Label();
            MinimumLevelLabel = new Label();
            label5 = new Label();
            AverageLevelLabel = new Label();
            FirstNumberLabel = new Label();
            MinimumLevel = new Label();
            MaximumLevel = new Label();
            AverageLevel = new Label();
            FirstNumber = new Label();
            FilePath = new Label();
            FilePathLabel = new Label();
            SuspendLayout();
            // 
            // HeroNameLabel
            // 
            HeroNameLabel.AutoSize = true;
            HeroNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            HeroNameLabel.Location = new Point(30, 30);
            HeroNameLabel.Name = "HeroNameLabel";
            HeroNameLabel.Size = new Size(128, 20);
            HeroNameLabel.TabIndex = 0;
            HeroNameLabel.Text = "Имя существа";
            // 
            // HeroName
            // 
            HeroName.Location = new Point(237, 27);
            HeroName.Name = "HeroName";
            HeroName.Size = new Size(255, 23);
            HeroName.TabIndex = 1;
            // 
            // HeroMass
            // 
            HeroMass.Location = new Point(237, 70);
            HeroMass.Name = "HeroMass";
            HeroMass.Size = new Size(255, 23);
            HeroMass.TabIndex = 3;
            // 
            // HeroMassLabel
            // 
            HeroMassLabel.AutoSize = true;
            HeroMassLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            HeroMassLabel.Location = new Point(30, 73);
            HeroMassLabel.Name = "HeroMassLabel";
            HeroMassLabel.Size = new Size(146, 20);
            HeroMassLabel.TabIndex = 2;
            HeroMassLabel.Text = "Масса существа";
            // 
            // EatableMass
            // 
            EatableMass.Location = new Point(237, 114);
            EatableMass.Name = "EatableMass";
            EatableMass.Size = new Size(255, 23);
            EatableMass.TabIndex = 5;
            // 
            // EatableMassLabel
            // 
            EatableMassLabel.AutoSize = true;
            EatableMassLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            EatableMassLabel.Location = new Point(30, 117);
            EatableMassLabel.Name = "EatableMassLabel";
            EatableMassLabel.Size = new Size(182, 20);
            EatableMassLabel.TabIndex = 4;
            EatableMassLabel.Text = "Поглащаемая масса";
            // 
            // FuelType
            // 
            FuelType.Location = new Point(237, 159);
            FuelType.Name = "FuelType";
            FuelType.Size = new Size(255, 23);
            FuelType.TabIndex = 7;
            // 
            // FuelTypeLabel
            // 
            FuelTypeLabel.AutoSize = true;
            FuelTypeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            FuelTypeLabel.Location = new Point(30, 162);
            FuelTypeLabel.Name = "FuelTypeLabel";
            FuelTypeLabel.Size = new Size(88, 20);
            FuelTypeLabel.TabIndex = 6;
            FuelTypeLabel.Text = "Тип пищи";
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UpdateButton.Location = new Point(30, 219);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(462, 61);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "НАЖАТЬ КНОПКА (ЗАФИКСИРОВАТЬ СУЩНОСТЬ)";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.Location = new Point(30, 311);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "Сводка:";
            // 
            // MinimumLevelLabel
            // 
            MinimumLevelLabel.AutoSize = true;
            MinimumLevelLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            MinimumLevelLabel.Location = new Point(30, 349);
            MinimumLevelLabel.Name = "MinimumLevelLabel";
            MinimumLevelLabel.Size = new Size(169, 20);
            MinimumLevelLabel.TabIndex = 10;
            MinimumLevelLabel.Text = "Мин. потребление:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(30, 388);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 11;
            label5.Text = "Макс. потребление:";
            // 
            // AverageLevelLabel
            // 
            AverageLevelLabel.AutoSize = true;
            AverageLevelLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            AverageLevelLabel.Location = new Point(30, 430);
            AverageLevelLabel.Name = "AverageLevelLabel";
            AverageLevelLabel.Size = new Size(179, 20);
            AverageLevelLabel.TabIndex = 12;
            AverageLevelLabel.Text = "Сред. потребление:";
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            FirstNumberLabel.Location = new Point(30, 473);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(132, 20);
            FirstNumberLabel.TabIndex = 13;
            FirstNumberLabel.Text = "Самый крутой:";
            // 
            // MinimumLevel
            // 
            MinimumLevel.AutoSize = true;
            MinimumLevel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            MinimumLevel.Location = new Point(237, 349);
            MinimumLevel.Name = "MinimumLevel";
            MinimumLevel.Size = new Size(15, 20);
            MinimumLevel.TabIndex = 14;
            MinimumLevel.Text = "-";
            // 
            // MaximumLevel
            // 
            MaximumLevel.AutoSize = true;
            MaximumLevel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            MaximumLevel.Location = new Point(237, 388);
            MaximumLevel.Name = "MaximumLevel";
            MaximumLevel.Size = new Size(15, 20);
            MaximumLevel.TabIndex = 15;
            MaximumLevel.Text = "-";
            // 
            // AverageLevel
            // 
            AverageLevel.AutoSize = true;
            AverageLevel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            AverageLevel.Location = new Point(237, 430);
            AverageLevel.Name = "AverageLevel";
            AverageLevel.Size = new Size(15, 20);
            AverageLevel.TabIndex = 16;
            AverageLevel.Text = "-";
            // 
            // FirstNumber
            // 
            FirstNumber.AutoSize = true;
            FirstNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            FirstNumber.Location = new Point(237, 473);
            FirstNumber.Name = "FirstNumber";
            FirstNumber.Size = new Size(15, 20);
            FirstNumber.TabIndex = 17;
            FirstNumber.Text = "-";
            // 
            // FilePath
            // 
            FilePath.AutoSize = true;
            FilePath.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            FilePath.Location = new Point(237, 518);
            FilePath.Name = "FilePath";
            FilePath.Size = new Size(15, 20);
            FilePath.TabIndex = 19;
            FilePath.Text = "-";
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            FilePathLabel.Location = new Point(30, 518);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(159, 20);
            FilePathLabel.TabIndex = 18;
            FilePathLabel.Text = "Данные взяты из:";
            // 
            // MaximumLevelLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 556);
            Controls.Add(FilePath);
            Controls.Add(FilePathLabel);
            Controls.Add(FirstNumber);
            Controls.Add(AverageLevel);
            Controls.Add(MaximumLevel);
            Controls.Add(MinimumLevel);
            Controls.Add(FirstNumberLabel);
            Controls.Add(AverageLevelLabel);
            Controls.Add(label5);
            Controls.Add(MinimumLevelLabel);
            Controls.Add(label2);
            Controls.Add(UpdateButton);
            Controls.Add(FuelType);
            Controls.Add(FuelTypeLabel);
            Controls.Add(EatableMass);
            Controls.Add(EatableMassLabel);
            Controls.Add(HeroMass);
            Controls.Add(HeroMassLabel);
            Controls.Add(HeroName);
            Controls.Add(HeroNameLabel);
            Name = "MaximumLevelLabel";
            Text = "Зоопарк (ПИ-231)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeroNameLabel;
        private TextBox HeroName;
        private TextBox HeroMass;
        private Label HeroMassLabel;
        private TextBox EatableMass;
        private Label EatableMassLabel;
        private TextBox FuelType;
        private Label FuelTypeLabel;
        private Button UpdateButton;
        private Label label2;
        private Label MinimumLevelLabel;
        private Label label5;
        private Label AverageLevelLabel;
        private Label FirstNumberLabel;
        private Label MinimumLevel;
        private Label MaximumLevel;
        private Label AverageLevel;
        private Label FirstNumber;
        private Label FilePath;
        private Label FilePathLabel;
    }
}
