namespace ChangeFileName
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.MakeChanges = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton5 = new System.Windows.Forms.RadioButton();
            this.RadioButton6 = new System.Windows.Forms.RadioButton();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeSymbol = new System.Windows.Forms.Button();
            this.ChangePlace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.RadioButton2);
            this.groupBox1.Controls.Add(this.RadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(22, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заменить что";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "заменить \" \"";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Checked = true;
            this.RadioButton2.Location = new System.Drawing.Point(7, 44);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(90, 17);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "заменить \"-\"";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(7, 20);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(93, 17);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.Text = "заменить \"_\"";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(12, 12);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(95, 23);
            this.ChooseFolder.TabIndex = 2;
            this.ChooseFolder.Text = "выбрать папку";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // MakeChanges
            // 
            this.MakeChanges.Enabled = false;
            this.MakeChanges.Location = new System.Drawing.Point(45, 229);
            this.MakeChanges.Name = "MakeChanges";
            this.MakeChanges.Size = new System.Drawing.Size(173, 26);
            this.MakeChanges.TabIndex = 3;
            this.MakeChanges.Text = "Заменить разделители";
            this.MakeChanges.UseVisualStyleBackColor = true;
            this.MakeChanges.Click += new System.EventHandler(this.MakeChanges_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButton5);
            this.groupBox2.Controls.Add(this.RadioButton6);
            this.groupBox2.Controls.Add(this.RadioButton4);
            this.groupBox2.Location = new System.Drawing.Point(138, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заменить на";
            // 
            // RadioButton5
            // 
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.Location = new System.Drawing.Point(6, 44);
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.Size = new System.Drawing.Size(105, 17);
            this.RadioButton5.TabIndex = 3;
            this.RadioButton5.Text = "заменить на \"-\"";
            this.RadioButton5.UseVisualStyleBackColor = true;
            // 
            // RadioButton6
            // 
            this.RadioButton6.AutoSize = true;
            this.RadioButton6.Location = new System.Drawing.Point(6, 67);
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.Size = new System.Drawing.Size(105, 17);
            this.RadioButton6.TabIndex = 2;
            this.RadioButton6.Text = "заменить на \" \"";
            this.RadioButton6.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Checked = true;
            this.RadioButton4.Location = new System.Drawing.Point(6, 20);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(108, 17);
            this.RadioButton4.TabIndex = 1;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "заменить на \"_\"";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton17);
            this.groupBox5.Controls.Add(this.radioButton16);
            this.groupBox5.Controls.Add(this.radioButton15);
            this.groupBox5.Controls.Add(this.radioButton14);
            this.groupBox5.Controls.Add(this.radioButton13);
            this.groupBox5.Location = new System.Drawing.Point(270, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 192);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "номер разделителя с конца";
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(4, 147);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(31, 17);
            this.radioButton17.TabIndex = 4;
            this.radioButton17.Text = "5";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(4, 124);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(31, 17);
            this.radioButton16.TabIndex = 3;
            this.radioButton16.Text = "4";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(4, 101);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(31, 17);
            this.radioButton15.TabIndex = 2;
            this.radioButton15.Text = "3";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(4, 78);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(31, 17);
            this.radioButton14.TabIndex = 1;
            this.radioButton14.Text = "2";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Checked = true;
            this.radioButton13.Location = new System.Drawing.Point(4, 55);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(31, 17);
            this.radioButton13.TabIndex = 0;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "1";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "заменить все указаные разделители в имени файла";
            // 
            // ChangeSymbol
            // 
            this.ChangeSymbol.Enabled = false;
            this.ChangeSymbol.Location = new System.Drawing.Point(45, 291);
            this.ChangeSymbol.Name = "ChangeSymbol";
            this.ChangeSymbol.Size = new System.Drawing.Size(173, 23);
            this.ChangeSymbol.TabIndex = 10;
            this.ChangeSymbol.Text = "Заменить разделитель";
            this.ChangeSymbol.UseVisualStyleBackColor = true;
            this.ChangeSymbol.Click += new System.EventHandler(this.ChangeSymbol_Click);
            // 
            // ChangePlace
            // 
            this.ChangePlace.Enabled = false;
            this.ChangePlace.Location = new System.Drawing.Point(45, 262);
            this.ChangePlace.Name = "ChangePlace";
            this.ChangePlace.Size = new System.Drawing.Size(173, 23);
            this.ChangePlace.TabIndex = 11;
            this.ChangePlace.Text = "Поменять друг на друга";
            this.ChangePlace.UseVisualStyleBackColor = true;
            this.ChangePlace.Click += new System.EventHandler(this.ChangePlace_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(382, 34);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChangePlace);
            this.Controls.Add(this.ChangeSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MakeChanges);
            this.Controls.Add(this.ChooseFolder);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.Button MakeChanges;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioButton5;
        private System.Windows.Forms.RadioButton RadioButton6;
        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeSymbol;
        private System.Windows.Forms.Button ChangePlace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

