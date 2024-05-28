namespace TP_WF
{
    partial class Form1
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
            listBox = new ListBox();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            button1 = new Button();
            save_button = new Button();
            loadButton = new Button();
            findAgeButton = new Button();
            findAgeNumericUpDown = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findAgeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(252, 304);
            listBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(302, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Имя";
            nameTextBox.Size = new Size(120, 23);
            nameTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(302, 41);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.PlaceholderText = "Фамилия";
            surnameTextBox.Size = new Size(120, 23);
            surnameTextBox.TabIndex = 2;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(302, 70);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(120, 23);
            ageNumericUpDown.TabIndex = 3;
            ageNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(302, 99);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // save_button
            // 
            save_button.Location = new Point(302, 128);
            save_button.Name = "save_button";
            save_button.Size = new Size(120, 23);
            save_button.TabIndex = 5;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(302, 157);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(120, 23);
            loadButton.TabIndex = 6;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // findAgeButton
            // 
            findAgeButton.Location = new Point(302, 236);
            findAgeButton.Name = "findAgeButton";
            findAgeButton.Size = new Size(120, 23);
            findAgeButton.TabIndex = 7;
            findAgeButton.Text = "Найти";
            findAgeButton.UseVisualStyleBackColor = true;
            findAgeButton.Click += findAgeButton_Click;
            // 
            // findAgeNumericUpDown
            // 
            findAgeNumericUpDown.Location = new Point(302, 207);
            findAgeNumericUpDown.Name = "findAgeNumericUpDown";
            findAgeNumericUpDown.Size = new Size(120, 23);
            findAgeNumericUpDown.TabIndex = 8;
            findAgeNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(302, 265);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 9;
            button2.Text = "Сортировать";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 343);
            Controls.Add(button2);
            Controls.Add(findAgeNumericUpDown);
            Controls.Add(findAgeButton);
            Controls.Add(loadButton);
            Controls.Add(save_button);
            Controls.Add(button1);
            Controls.Add(ageNumericUpDown);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)findAgeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private NumericUpDown ageNumericUpDown;
        private Button button1;
        private Button save_button;
        private Button loadButton;
        private Button findAgeButton;
        private NumericUpDown findAgeNumericUpDown;
        private Button button2;
    }
}
