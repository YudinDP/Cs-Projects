using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWordGen_App
{
    public class ClassPassword
    {
        //поля
        private string password = ""; //сам пароль
        private int passwordLength;  //длина пароля
        private string simbols = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_"; //используемые символы
        private string path = Directory.GetCurrentDirectory() + "/passwords.txt";
        private string description;


        ///Конструктор
        public ClassPassword(int passLength)
        {
            this.passwordLength = passLength;
        }

        public void SetLength(int length) {
            passwordLength = length;
        }

        public string GetPath() {
            return path;
        }
        ///Генерация пароля и его вывод
        public string Create_Password()
        {
            this.password = "";
            int Num;
            //создание рандомного числа
            Random rnd = new Random();
        Restart:
            for (int i = 0; i < this.passwordLength; i++) //пока не заполнили всю длину пароля будем геренировать случайные числа из диапазона доступных
                                                     //и выбирать в пароль символы из заданной строки всех подходящих
            {
                Num = rnd.Next(0, simbols.Length - 1);
                this.password += simbols[Num];  //записываем символы в строку пароля
            }
            if (!(this.password.Contains("-") || this.password.Contains("_")))
            { //если пароль не содержит хотя бы 1 спецсимвол, то обнуляем его и пробуем создать еще раз
                this.password = "";
                goto Restart; //возвращаемся для повторного заполнения 
            }
            return this.password;  //возвращаем готовый пароль в место вызова
        }


        ///Сохранение пароля в файл
        public bool SaveInFile(string discript)
        {
            if (this.password.Length != this.passwordLength)
            { //проверяем все-ли так с нашим паролем
                return false;  //если нет, то уходим из метода с false
            }
            
            this.description = discript;  //указываем комменатрий
            StreamWriter file = new StreamWriter(path, true);  //создаем поток для записи в наш файл(создаем файл) path - путь к файлу(+имя)  true - то, что запись первичная, это почему-то позволяет дозаписывать в файл
            file.WriteLineAsync(this.password + " - " + this.description);  //дописываем в файл данные
            file.Close();  //закрываем файл
            return true;  //возвращаемся с успехом
        }
    }
}
