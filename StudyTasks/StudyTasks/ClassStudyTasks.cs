using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTasks
{

    public class ClassStudyTasks
    {
        //поля
        private string[] SubjectsArr = new string[7];  //предметы
        private string[] TasksArr = new string[7];  //задания


        public ClassStudyTasks() {
            for (int i = 0; i < this.TasksArr.Length; i++)
            {
                this.SubjectsArr[i] = "-";
                this.TasksArr[i] = "-";
            }
        }

        //Создает объект по передаваемым массивам с названиями предметов и заданиями по ним
        public void CreateObject(string[] subarr, string[] taskarr)
        {
            for (int i = 0; i < this.TasksArr.Length; i++)
            {
                this.SubjectsArr[i] = subarr[i];
                this.TasksArr[i] = taskarr[i];
            }
        }

        //сохранение объекта(дня недели) в файл
        public void SaveInFile(string path)
        {
            StreamWriter file = new StreamWriter(path, true);  //создаем поток для записи в наш файл(создаем файл) path - путь к файлу(+имя)  true - то, что запись первичная, это почему-то позволяет дозаписывать в файл


            for (int i = 0; i < this.SubjectsArr.Length; i++)
            {
                file.WriteLineAsync(this.SubjectsArr[i]);  //дописываем в файл данные
            }
            for (int i = 0; i < this.TasksArr.Length; i++)
            {
                file.WriteLineAsync(this.TasksArr[i]);  //дописываем в файл данные
            }

            file.Close();  //закрываем файл
        }
    }
}
