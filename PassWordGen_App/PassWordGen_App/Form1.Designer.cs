namespace PassWordGen_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.copyPictureBox = new System.Windows.Forms.PictureBox();
            this.copyPictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PassWord Generator 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthTextBox.Location = new System.Drawing.Point(46, 121);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(155, 35);
            this.lengthTextBox.TabIndex = 1;
            this.lengthTextBox.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина пароля от 8 до 50";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.generateButton.Location = new System.Drawing.Point(465, 81);
            this.generateButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(210, 75);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Генерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(66, 248);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(753, 62);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(35, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 34);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(35, 435);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(118, 34);
            this.saveAsButton.TabIndex = 6;
            this.saveAsButton.Text = "Сохранить как..";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Visible = false;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discriptionTextBox.Location = new System.Drawing.Point(259, 395);
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(529, 31);
            this.discriptionTextBox.TabIndex = 7;
            this.discriptionTextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(255, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Добавьте описание чтобы не забыть от чего пароль:)";
            this.label3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 77);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(255, 447);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сохранено в: ";
            this.label4.Visible = false;
            // 
            // copyPictureBox
            // 
            this.copyPictureBox.BackColor = System.Drawing.Color.White;
            this.copyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("copyPictureBox.Image")));
            this.copyPictureBox.InitialImage = null;
            this.copyPictureBox.Location = new System.Drawing.Point(18, 259);
            this.copyPictureBox.Name = "copyPictureBox";
            this.copyPictureBox.Size = new System.Drawing.Size(37, 36);
            this.copyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copyPictureBox.TabIndex = 11;
            this.copyPictureBox.TabStop = false;
            this.copyPictureBox.Visible = false;
            this.copyPictureBox.Click += new System.EventHandler(this.copyPictureBox_Click);
            // 
            // copyPictureBox2
            // 
            this.copyPictureBox2.BackColor = System.Drawing.Color.White;
            this.copyPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("copyPictureBox2.Image")));
            this.copyPictureBox2.InitialImage = null;
            this.copyPictureBox2.Location = new System.Drawing.Point(216, 447);
            this.copyPictureBox2.Name = "copyPictureBox2";
            this.copyPictureBox2.Size = new System.Drawing.Size(33, 36);
            this.copyPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copyPictureBox2.TabIndex = 12;
            this.copyPictureBox2.TabStop = false;
            this.copyPictureBox2.Visible = false;
            this.copyPictureBox2.Click += new System.EventHandler(this.copyPictureBox2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 573);
            this.Controls.Add(this.copyPictureBox2);
            this.Controls.Add(this.copyPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lengthTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox copyPictureBox;
        private System.Windows.Forms.PictureBox copyPictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

