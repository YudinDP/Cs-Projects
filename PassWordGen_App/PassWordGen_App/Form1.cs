using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWordGen_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        ClassPassword Password = new ClassPassword(10);  //создаем объект класса
        //Генерация пароля
        private void generateButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            string passLenStr = lengthTextBox.Text; //запрашиваем длину пароля в виде строки и проверяем не пустая ли она
            int passwordLength;
            if (passLenStr != "" && int.Parse(passLenStr) < 50 && int.Parse(passLenStr) > 8) //если строка не пустая, то преобразуем в число(крайне рассчитываем на здравомыслие пользователя, защиты от НЕ чисел нет)
            {
                passwordLength = int.Parse(passLenStr);
            }
            else
            {
                passwordLength = 10;  //иначе даем стандартную длину пароля
            }
            Password.SetLength(passwordLength);
            passwordTextBox.Text =  Password.Create_Password();

            passwordTextBox.Visible = true;
            discriptionTextBox.Visible = true;
            label3.Visible = true; 
            saveButton.Visible = true;  saveAsButton.Visible = true;
            copyPictureBox.Visible = true;
            copyPictureBox2.BackColor = Color.White;
            copyPictureBox.BackColor = Color.White;
            discriptionTextBox.Text = "";
            label4.Visible = false;
            copyPictureBox2.Visible = false;

        }

        //сохранение в тектовый файл с паролями в текущей папке по адресу программы
        private void saveButton_Click(object sender, EventArgs e)
        {
            string discription = discriptionTextBox.Text;
            Password.SaveInFile(discription);
            label4.Text += Password.GetPath();  
            label4.Visible = true;
            copyPictureBox2.Visible = true;
        }


        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            string filename = saveFileDialog1.FileName;
            System.IO.File.AppendAllText(filename, (passwordTextBox.Text + " - " + discriptionTextBox.Text + "\n"));

        }

        private void copyPictureBox_Click(object sender, EventArgs e)
        {
            copyPictureBox.BackColor = Color.Silver;
            Clipboard.SetText(Password.GetPath());
            
        }

        private void copyPictureBox2_Click(object sender, EventArgs e)
        {
            copyPictureBox2.BackColor = Color.Silver;
            Clipboard.SetText(passwordTextBox.Text);
        }
    }
}
