using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTasks
{
    public partial class mainForm : Form
    {

        int pageCounter = 1; //счетчик для номера страницы
        string path = Directory.GetCurrentDirectory() + "/ProgramWorkFiles/Pages"; //адрес файла для сохранения
        string pathtoLastOpenPage = Directory.GetCurrentDirectory() + "/ProgramWorkFiles/LastOpen.txt"; //путь к файлу для сохранения последней открытой страницы
        private string[] SubjectsArr = new string[7];  //предметы
        private string[] TasksArr = new string[7];  //задания
        ClassStudyTasks[] Page = new ClassStudyTasks[7]; //массив объектов данных из таблиц
        ClassStudyTasks[] Page2 = new ClassStudyTasks[7]; //2-й массив такого же типа для автозаполнения
        DateTime DateInside = new DateTime(2024, 2, 5); //начальная дата на основе которой формируются все другие
        public mainForm()
        {
            InitializeComponent();

            //инициализация каждого объекта из массива объектов для дней недели
            for (int i = 0; i < 7; i++)
            {
                Page[i] = new ClassStudyTasks();
                Page2[i] = new ClassStudyTasks();
            }

           
            //настройка таблицы понедельника
            dataGridViewMonday.ColumnHeadersVisible = false; //отключаем видимость заголовка
            dataGridViewMonday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; //настойка авторазмера
            dataGridViewMonday.AllowUserToResizeRows = false; //запрещаем менять размер таблиц
            dataGridViewMonday.DefaultCellStyle.WrapMode = DataGridViewTriState.True; //настройка стиля ячеек
            dataGridViewMonday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //авторазмер ячеек(для больших текстов)
            dataGridViewMonday.AllowUserToAddRows = false; //запрещаем добавлять строки


            dataGridViewMonday.Rows.Add("1", "", ""); //заполнение номеров уроков/пар
            dataGridViewMonday.Rows.Add("2", "", "");
            dataGridViewMonday.Rows.Add("3", "", " ");
            dataGridViewMonday.Rows.Add("4", "", "");
            dataGridViewMonday.Rows.Add("5", "", "");
            dataGridViewMonday.Rows.Add("6", "", "");
            dataGridViewMonday.Rows.Add("7", "", "");


            //настройка таблицы вторника
            dataGridViewTuesday.ColumnHeadersVisible = false;
            dataGridViewTuesday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewTuesday.AllowUserToResizeRows = false;
            dataGridViewTuesday.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewTuesday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTuesday.AllowUserToAddRows = false;

            dataGridViewTuesday.Rows.Add("1", "", "");
            dataGridViewTuesday.Rows.Add("2", "", "");
            dataGridViewTuesday.Rows.Add("3", "", " ");
            dataGridViewTuesday.Rows.Add("4", "", "");
            dataGridViewTuesday.Rows.Add("5", "", "");
            dataGridViewTuesday.Rows.Add("6", "", "");
            dataGridViewTuesday.Rows.Add("7", "", "");


            //настройка таблицы среды
            dataGridViewWednesday.ColumnHeadersVisible = false;
            dataGridViewWednesday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewWednesday.AllowUserToResizeRows = false;
            dataGridViewWednesday.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewWednesday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWednesday.AllowUserToAddRows = false;

            dataGridViewWednesday.Rows.Add("1", "", "");
            dataGridViewWednesday.Rows.Add("2", "", "");
            dataGridViewWednesday.Rows.Add("3", "", " ");
            dataGridViewWednesday.Rows.Add("4", "", "");
            dataGridViewWednesday.Rows.Add("5", "", "");
            dataGridViewWednesday.Rows.Add("6", "", "");
            dataGridViewWednesday.Rows.Add("7", "", "");


            //настройка таблицы четверга
            dataGridViewThursday.ColumnHeadersVisible = false;
            dataGridViewThursday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewThursday.AllowUserToResizeRows = false;
            dataGridViewThursday.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewThursday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewThursday.AllowUserToAddRows = false;

            dataGridViewThursday.Rows.Add("1", "", "");
            dataGridViewThursday.Rows.Add("2", "", "");
            dataGridViewThursday.Rows.Add("3", "", " ");
            dataGridViewThursday.Rows.Add("4", "", "");
            dataGridViewThursday.Rows.Add("5", "", "");
            dataGridViewThursday.Rows.Add("6", "", "");
            dataGridViewThursday.Rows.Add("7", "", "");


            //настройка таблицы пятницы
            dataGridViewFriday.ColumnHeadersVisible = false;
            dataGridViewFriday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewFriday.AllowUserToResizeRows = false;
            dataGridViewFriday.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewFriday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFriday.AllowUserToAddRows = false;

            dataGridViewFriday.Rows.Add("1", "", "");
            dataGridViewFriday.Rows.Add("2", "", "");
            dataGridViewFriday.Rows.Add("3", "", " ");
            dataGridViewFriday.Rows.Add("4", "", "");
            dataGridViewFriday.Rows.Add("5", "", "");
            dataGridViewFriday.Rows.Add("6", "", "");
            dataGridViewFriday.Rows.Add("7", "", "");


            //настройка таблицы субботы
            dataGridViewSaturday.ColumnHeadersVisible = false;
            dataGridViewSaturday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewSaturday.AllowUserToResizeRows = false;
            dataGridViewSaturday.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewSaturday.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSaturday.AllowUserToAddRows = false;

            dataGridViewSaturday.Rows.Add("1", "", "");
            dataGridViewSaturday.Rows.Add("2", "", "");
            dataGridViewSaturday.Rows.Add("3", "", " ");
            dataGridViewSaturday.Rows.Add("4", "", "");
            dataGridViewSaturday.Rows.Add("5", "", "");
            dataGridViewSaturday.Rows.Add("6", "", "");
            dataGridViewSaturday.Rows.Add("7", "", "");


            System.IO.Directory.CreateDirectory("ProgramWorkFiles");//создаем директорию для рабочих файлов(если ее нет)

            if (File.Exists(pathtoLastOpenPage)) {  //если программа ранее открывалась и последняя открытая страница сохранена
                StreamReader readLast = new StreamReader(pathtoLastOpenPage); //открываем файл для чтения
                pageCounter = int.Parse((readLast.ReadLineAsync().Result).ToString());  //считываем последнюю открытую страницу
                readLast.Close(); //закрываем файл
                labelNumPage.Text = pageCounter.ToString(); //выводим на экран  
            }

            LoadPage(pageCounter);//загружаем страницу на форму из файла по ее номеру

            //блок с дизайном кнопок
            //(скругление)
            SetRoundedShape(buttonEdit, 50);
            SetRoundedShape(buttonSave, 50);
            SetRoundedShape(buttonPrevious, 50);
            SetRoundedShape(buttonNext, 50);
            SetRoundedShape(buttonAutoFill, 50);


            buttonSave.Enabled = false; //изначально блокируем кнопку сохранения

            DateSetWeek(); //заносим на страницу даты
        }


        //Доступ к изменению расписания
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (pageCounter == 2 && !File.Exists(path+"2.txt")) { //если пользователь впервые заполняем вторую страницу
                labeledit2.Visible = true;
                timerDisappearance2.Start(); //запускаем таймер на удаление уведомления
            }
            //включаем всем таблицам редактирование в нужных столбцах 
            dataGridViewMonday.Columns[1].ReadOnly = false;
            dataGridViewMonday.Columns[2].ReadOnly = false;

            dataGridViewTuesday.Columns[1].ReadOnly = false;
            dataGridViewTuesday.Columns[2].ReadOnly = false;

            dataGridViewWednesday.Columns[1].ReadOnly = false;
            dataGridViewWednesday.Columns[2].ReadOnly = false;

            dataGridViewThursday.Columns[1].ReadOnly = false;
            dataGridViewThursday.Columns[2].ReadOnly = false;
            
            dataGridViewFriday.Columns[1].ReadOnly = false;
            dataGridViewFriday.Columns[2].ReadOnly = false;
            
            dataGridViewSaturday.Columns[1].ReadOnly = false;
            dataGridViewSaturday.Columns[2].ReadOnly = false;

            buttonSave.Enabled = true; //даем доступ к кнопке
        }


        //Сохранение всей текущей страницы в текстовый файл
        private void button1_Click(object sender, EventArgs e)
        {
            if (pageCounter == 2 && !File.Exists(path + "2.txt") && !File.Exists(path + "3.txt")) //если пользователь впервые сохраняем вторую страницу
            {
                buttonAutoFill.Visible = true;  //предлагаем автозаполнение
            }

            buttonSave.Enabled = false; //запрещаем доступ к кнопке
            labelSave.Visible = true; //выкидываем сообщение о сохранении
            //записываем в массив данные понедельника
            for (int i = 0; i < this.SubjectsArr.Length; i++) {
                if (dataGridViewMonday[1, i].Value == null)  //если в ячейке null то запишем пустую строку

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewMonday[1, i].Value.ToString();  //а иначе очевидно само значение

                if (dataGridViewMonday[2, i].Value == null) //и то же для заданий
                    TasksArr[i] = "";
                else
                    TasksArr[i] = dataGridViewMonday[2, i].Value.ToString();
            }
            Page[0].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные вторника
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewTuesday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewTuesday[1, i].Value.ToString();

                if (dataGridViewTuesday[2, i].Value == null)
                    TasksArr[i] = "";
                else
                    TasksArr[i] = dataGridViewTuesday[2, i].Value.ToString();
            }
            Page[1].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные среды
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewWednesday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewWednesday[1, i].Value.ToString();

                if (dataGridViewWednesday[2, i].Value == null) 
                    TasksArr[i] = "";
                else
                TasksArr[i] = dataGridViewWednesday[2, i].Value.ToString();
            }
            Page[2].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные четверга
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewThursday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewThursday[1, i].Value.ToString();

                if (dataGridViewThursday[2, i].Value == null)
                    TasksArr[i] = "";
                else
                    TasksArr[i] = dataGridViewThursday[2, i].Value.ToString();
            }
            Page[3].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные пятницы
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewFriday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewFriday[1, i].Value.ToString();

                if (dataGridViewFriday[2, i].Value == null)
                    TasksArr[i] = "";
                else
                    TasksArr[i] = dataGridViewFriday[2, i].Value.ToString();
            }
            Page[4].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные субботы
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewSaturday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewSaturday[1, i].Value.ToString();

                if (dataGridViewSaturday[2, i].Value == null)
                    TasksArr[i] = "";
                else
                    TasksArr[i] = dataGridViewSaturday[2, i].Value.ToString();
            }
            Page[5].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект
            File.WriteAllText(path + (pageCounter).ToString() + ".txt", "");  //очищаем наш файл перед записью на всякий случай


            //сохраняем все 6 дней недели в файл через метод объектов
            for (int i = 0; i < 6; i++)
            {
                Page[i].SaveInFile(path + pageCounter.ToString() + ".txt");
            }


            //для всех ячеек откуда брали данные снова выключаем возможность редактирования
            dataGridViewMonday.Columns[1].ReadOnly = true;
            dataGridViewMonday.Columns[2].ReadOnly = true;


            dataGridViewTuesday.Columns[1].ReadOnly = true;
            dataGridViewTuesday.Columns[2].ReadOnly = true;

            dataGridViewWednesday.Columns[1].ReadOnly = true;
            dataGridViewWednesday.Columns[2].ReadOnly = true;

            dataGridViewThursday.Columns[1].ReadOnly = true;
            dataGridViewThursday.Columns[2].ReadOnly = true;

            dataGridViewFriday.Columns[1].ReadOnly = true;
            dataGridViewFriday.Columns[2].ReadOnly = true;

            dataGridViewSaturday.Columns[1].ReadOnly = true;
            dataGridViewSaturday.Columns[2].ReadOnly = true;

            timerDisappearance.Start();
        }


        //переход к слудующей странице + Запоминаем ее номер в файл, как последней открытой
        private void buttonNext_Click(object sender, EventArgs e)
        {
            pageCounter++;  //прибавляем счетчик номера страницы
            labelNumPage.Text = pageCounter.ToString(); //выносим на форму
            File.WriteAllText(pathtoLastOpenPage, pageCounter.ToString());//перезаписываем в файл последнюю открытую страницу

            LoadPage(pageCounter);//загружаем страницу на форму из файла
            DateSetWeek(); //заносим даты на страницу
        }

        //переход к предыдущей странице + Запоминаем ее номер в файл, как последней открытой
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pageCounter == 1) //если страница первая, то двигаться некуда и мы остаемся на месте
            {
                return;
            }
            else {
                pageCounter--;   //уменьшаем счетчик и выврдим на форму
                labelNumPage.Text = pageCounter.ToString();
            }
            File.WriteAllText(pathtoLastOpenPage, pageCounter.ToString()); //перезаписываем в файл последнюю открытую страницу

            LoadPage(pageCounter); //загружаем страницу на форму из файла
            DateSetWeek(); //заносим даты на страницу
        }


        //загрузка страницы(по текущему pageCounter и сущестованию файла)
        private void LoadPage(int numpage) {
            if (File.Exists(path + numpage.ToString() + ".txt")) //проверили существование файла с страницей
            {
                //загрузка данных страницы из файла
                StreamReader readFile = new StreamReader(path + numpage.ToString() + ".txt"); //открываем файл для чтения


                //Записываем понедельник
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewMonday[1, i].Value = readFile.ReadLineAsync().Result;
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewMonday[2, i].Value = readFile.ReadLineAsync().Result;
                }
                //Записываем вторник
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewTuesday[1, i].Value = readFile.ReadLineAsync().Result;
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewTuesday[2, i].Value = readFile.ReadLineAsync().Result;
                }
                //Записываем среду
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewWednesday[1, i].Value = readFile.ReadLineAsync().Result;
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewWednesday[2, i].Value = readFile.ReadLineAsync().Result;
                }
                //Записываем четверг
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewThursday[1, i].Value = readFile.ReadLineAsync().Result;
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewThursday[2, i].Value = readFile.ReadLineAsync().Result;
                }
                //Записываем пятницу
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewFriday[1, i].Value = readFile.ReadLineAsync().Result;
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewFriday[2, i].Value = readFile.ReadLineAsync().Result;
                }
                //Записываем субботу
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewSaturday[1, i].Value = readFile.ReadLineAsync().Result;
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewSaturday[2, i].Value = readFile.ReadLineAsync().Result;
                }
                readFile.Close(); //закрываем файл
            }
            //если его нет, то загружаем пустую страницу
            else 
            {
                //Записываем понедельник
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewMonday[1, i].Value = "";
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewMonday[2, i].Value = "";
                }
                //Записываем вторник
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewTuesday[1, i].Value = "";
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewTuesday[2, i].Value = "";
                }
                //Записываем среду
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewWednesday[1, i].Value = "";
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewWednesday[2, i].Value = "";
                }
                //Записываем четверг
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewThursday[1, i].Value = "";
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewThursday[2, i].Value = "";
                }
                //Записываем пятницу
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewFriday[1, i].Value = "";
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewFriday[2, i].Value = "";
                }
                //Записываем субботу
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewSaturday[1, i].Value = "";
                }
                for (int i = 0; i < this.SubjectsArr.Length; i++)
                {
                    dataGridViewSaturday[2, i].Value = "";
                }
            }
        }


        //настройка скругления углов объектов
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }



        //Автоматическое заполнение расписания на 20 недель
        private void buttonAutoFill_Click(object sender, EventArgs e)
        {
            buttonAutoFill.Visible = false;
            string[] SubjectsArr2 = new string[7];
            //загрузка данных страниц
            //2 страница
            //записываем в массив данные понедельника
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewMonday[1, i].Value == null)

                    SubjectsArr2[i] = "";
                else
                    SubjectsArr2[i] = dataGridViewMonday[1, i].Value.ToString();

            }
            Page2[0].CreateObject(SubjectsArr2, TasksArr);//загружаем массивы в объект

            //записываем в массив данные вторника
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewTuesday[1, i].Value == null)

                    SubjectsArr2[i] = "";
                else
                    SubjectsArr2[i] = dataGridViewTuesday[1, i].Value.ToString();

            }
            Page2[1].CreateObject(SubjectsArr2, TasksArr);//загружаем массивы в объект

            //записываем в массив данные среды
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewWednesday[1, i].Value == null)

                    SubjectsArr2[i] = "";
                else
                    SubjectsArr2[i] = dataGridViewWednesday[1, i].Value.ToString();

            }
            Page2[2].CreateObject(SubjectsArr2, TasksArr);//загружаем массивы в объект

            //записываем в массив данные четверга
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewThursday[1, i].Value == null)

                    SubjectsArr2[i] = "";
                else
                    SubjectsArr2[i] = dataGridViewThursday[1, i].Value.ToString();
            }
            Page2[3].CreateObject(SubjectsArr2, TasksArr);//загружаем массивы в объект

            //записываем в массив данные пятницы
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewFriday[1, i].Value == null)

                    SubjectsArr2[i] = "";
                else
                    SubjectsArr2[i] = dataGridViewFriday[1, i].Value.ToString();

            }
            Page2[4].CreateObject(SubjectsArr2, TasksArr);//загружаем массивы в объект

            //записываем в массив данные субботы
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewSaturday[1, i].Value == null)

                    SubjectsArr2[i] = "";
                else
                    SubjectsArr2[i] = dataGridViewSaturday[1, i].Value.ToString();

            }
            Page2[5].CreateObject(SubjectsArr2, TasksArr);//загружаем массивы в объект


            LoadPage(1);
            //1 страница
            //записываем в массив данные понедельника
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewMonday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewMonday[1, i].Value.ToString();

            }
            Page[0].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные вторника
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewTuesday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewTuesday[1, i].Value.ToString();

            }
            Page[1].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные среды
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewWednesday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewWednesday[1, i].Value.ToString();

            }
            Page[2].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные четверга
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewThursday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewThursday[1, i].Value.ToString();
            }
            Page[3].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные пятницы
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewFriday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewFriday[1, i].Value.ToString();

            }
            Page[4].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //записываем в массив данные субботы
            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                if (dataGridViewSaturday[1, i].Value == null)

                    SubjectsArr[i] = "";
                else
                    SubjectsArr[i] = dataGridViewSaturday[1, i].Value.ToString();

            }
            Page[5].CreateObject(SubjectsArr, TasksArr);//загружаем массивы в объект

            //начиная с третьего номера по 20-й создаем файлы и записываем туда по очереди наши массивы объектов с расписанием
            //j - номер файла
            int j = 3;  
            while (j <= 20)
            {
                if (j % 2 == 0)
                {
                    //сохраняем все 6 дней недели в файл через метод объектов
                    for (int i = 0; i < 6; i++)
                    {
                        Page2[i].SaveInFile(path + j.ToString() + ".txt");
                    }
                }
                else
                {
                    //сохраняем все 6 дней недели в файл через метод объектов
                    for (int i = 0; i < 6; i++)
                    {
                        Page[i].SaveInFile(path + j.ToString() + ".txt");
                    }
                }
                j++;
            }
        }


        //установка даты к каждому дню недели на странице
        private void DateSetWeek(){
            //создаем начальную дату на основе даты для первой страницы
             DateTime Date = DateInside.AddDays((pageCounter - 1) * 7);
            //и уже на ее основе просто выводим даты на неделю
            labelMonday.Text = "Понедельник, " + Date.ToLongDateString().Remove(Date.ToLongDateString().Length - 8);
            labelTuesday.Text = "Вторник, " + Date.AddDays(1).ToLongDateString().Remove(Date.AddDays(1).ToLongDateString().Length - 8);
            labelWednesday.Text = "Среда, " + Date.AddDays(2).ToLongDateString().Remove(Date.AddDays(2).ToLongDateString().Length - 8);
            labelThursday.Text = "Четверг, " + Date.AddDays(3).ToLongDateString().Remove(Date.AddDays(3).ToLongDateString().Length - 8);
            labelFriday.Text = "Пятница, " + Date.AddDays(4).ToLongDateString().Remove(Date.AddDays(4).ToLongDateString().Length - 8);
            labelSaturday.Text = "Суббота, " + Date.AddDays(5).ToLongDateString().Remove(Date.AddDays(5).ToLongDateString().Length - 8);
        }

        //таймер для исчезновения уведомления о сохранении
        private void timerDisappearance_Tick(object sender, EventArgs e)
        {
            labelSave.Visible = false;
        }

        //таймер для исчезновения уведомления о возможности автозаполнения
        private void timerDisappearance2_Tick(object sender, EventArgs e)
        {
            labeledit2.Visible = false;
        }
    }
}

