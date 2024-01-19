using System.IO;
namespace PasswordGenerator //пространство имен с классом пароля
{
    public class ClassPassword  //класс пароля
    {
        //поля
        private string password = ""; //сам пароль
        private int passwordLength;  //длина пароля
        private string simbols = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_"; //используемые символы
        public string path = Directory.GetCurrentDirectory() + "/passwords.txt";
        public string description;


        ///Конструктор
        public ClassPassword(int passLength) { 
            passwordLength = passLength;
        }


        ///Генерация пароля и его вывод
         public string Create_Password(int passwordLength) {
            int Num;
            //создание рандомного числа
            Random rnd = new Random();
            Restart:
            for (int i = 0; i < passwordLength; i++) //пока не заполнили всю длину пароля будем геренировать случайные числа из диапазона доступных
                                                        //и выбирать в пароль символы из заданной строки всех подходящих
            {
                Num = rnd.Next(0, simbols.Length - 1);
                password += simbols[Num];  //записываем символы в строку пароля
            }
            if (!(password.Contains("-") || password.Contains("_"))) { //если пароль не содержит хотя бы 1 спецсимвол, то обнуляем его и пробуем создать еще раз
                password = "";
                goto Restart; //возвращаемся для повторного заполнения 
            }
            return password;  //возвращаем готовый пароль в место вызова
        }


        ///Сохранение пароля в файл
        public bool SaveInFile() {
            if (password.Length != passwordLength) { //проверяем все-ли так с нашим паролем
                return false;  //если нет, то уходим из метода с false
            }
            Console.WriteLine("(По желанию) Укажите комментарий к этому паролю, чтобы не забыть от чего он:)");
            description = Console.ReadLine();  //указываем комменатрий
            StreamWriter file = new StreamWriter(path, true);  //создаем поток для записи в наш файл(создаем файл) path - путь к файлу(+имя)  true - то, что запись первичная, это почему-то позволяет дозаписывать в файл
            file.WriteLineAsync(password + " - " + description);  //дописываем в файл данные
            file.Close();  //закрываем файл
            return true;  //возвращаемся с успехом
        }
    }
}
