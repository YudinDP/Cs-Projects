namespace InvestCalculator_App
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
            this.firstSumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.timeReinvestTextBox = new System.Windows.Forms.TextBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sumReinvestTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstSumTextBox
            // 
            this.firstSumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSumTextBox.Location = new System.Drawing.Point(51, 104);
            this.firstSumTextBox.Name = "firstSumTextBox";
            this.firstSumTextBox.Size = new System.Drawing.Size(255, 31);
            this.firstSumTextBox.TabIndex = 0;
            this.firstSumTextBox.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Процентная ставка %/год";
            // 
            // percentTextBox
            // 
            this.percentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentTextBox.Location = new System.Drawing.Point(51, 218);
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(255, 31);
            this.percentTextBox.TabIndex = 2;
            this.percentTextBox.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Срок инвестирования";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBox.Location = new System.Drawing.Point(17, 91);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(255, 31);
            this.timeTextBox.TabIndex = 4;
            this.timeTextBox.Text = "12";
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Checked = true;
            this.monthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthRadioButton.Location = new System.Drawing.Point(24, 52);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(93, 24);
            this.monthRadioButton.TabIndex = 6;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Месяцев";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearRadioButton.Location = new System.Drawing.Point(183, 52);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(57, 24);
            this.yearRadioButton.TabIndex = 7;
            this.yearRadioButton.Text = "Лет";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            this.yearRadioButton.CheckedChanged += new System.EventHandler(this.yearRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(393, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Будут ли реинвестиции?";
            // 
            // timeReinvestTextBox
            // 
            this.timeReinvestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeReinvestTextBox.Location = new System.Drawing.Point(455, 301);
            this.timeReinvestTextBox.Name = "timeReinvestTextBox";
            this.timeReinvestTextBox.Size = new System.Drawing.Size(116, 31);
            this.timeReinvestTextBox.TabIndex = 8;
            this.timeReinvestTextBox.Text = "2";
            this.timeReinvestTextBox.Visible = false;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noRadioButton.Location = new System.Drawing.Point(552, 225);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(57, 24);
            this.noRadioButton.TabIndex = 11;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "Нет";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesRadioButton.Location = new System.Drawing.Point(393, 225);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(48, 24);
            this.yesRadioButton.TabIndex = 10;
            this.yesRadioButton.Text = "Да";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(51, 19);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(130, 34);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(83, 278);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(175, 54);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Считать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(400, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Частота реинвестиций";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(389, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Сумма реинвестиций";
            this.label6.Visible = false;
            // 
            // sumReinvestTextBox
            // 
            this.sumReinvestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumReinvestTextBox.Location = new System.Drawing.Point(386, 388);
            this.sumReinvestTextBox.Name = "sumReinvestTextBox";
            this.sumReinvestTextBox.Size = new System.Drawing.Size(255, 31);
            this.sumReinvestTextBox.TabIndex = 15;
            this.sumReinvestTextBox.Text = "2000";
            this.sumReinvestTextBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(389, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Раз в ";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(577, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Месяцев";
            this.label11.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yearRadioButton);
            this.groupBox1.Controls.Add(this.monthRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(369, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 142);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(683, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sumReinvestTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeReinvestTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.percentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstSumTextBox);
            this.Name = "Form1";
            this.Text = "Инвестиционный калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstSumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox percentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeReinvestTextBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sumReinvestTextBox;
        private System.Windows.Forms.Label FinalSumLabel;
        private System.Windows.Forms.Label ReinvestFinalSumLabel;
        private System.Windows.Forms.Label ProfitSumLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

