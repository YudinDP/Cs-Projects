
using PasswordGenerator;  //используем пространство имен с классом пароля
Main();
void Main() {
    Console.WriteLine("Генератор паролей");
    Console.WriteLine("Введите желаемую длину пароля(>=8), Если это не важно, то нажмите ENTER:");
    string passLenStr = Console.ReadLine(); //запрашиваем длину пароля в виде строки и проверяем не пустая ли она
    int passwordLength;
    if (passLenStr != "") //если строка не пустая, то преобразуем в число(крайне рассчитываем на здравомыслие пользователя, защиты от НЕ чисел нет)
                          //todo: защита от НЕ чисел
    {
        passwordLength = int.Parse(passLenStr);
    }
    else {
        passwordLength = 10;  //иначе даем стандартную длину пароля
    }
    if (passwordLength < 8 || passwordLength > 50) {  //теперь проверяем не слишком ли большое/малое число
        Console.WriteLine("Длина была не указана или оказалась слишком длинной/короткой. Была выбрана стандартная длина - 10");
        passwordLength = 10;   //если что-то не так, то уведомляем об этом и даем стандартную длину пароля
    }
    ClassPassword Password = new ClassPassword(passwordLength);  //создаем объект класса пароля, передавая в конструктор длину пароля
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Ваш пароль - " + Password.Create_Password(passwordLength)); //выводим на экран готовый пароль, который должны принять большинство систем
    Console.ResetColor();

    Console.WriteLine("\nРекомендуем опробовать пароль для той системы, где вы хотели его использовать");

    Console.WriteLine("\nСохранить пароль в файл?(крайне рекомендуется убедиться в работоспособности перед этим!)");
    Console.WriteLine("Да(ENTER)\t\t\tНет(Другая кнопка)");
    if (Console.ReadKey().Key == ConsoleKey.Enter) //если пользователь соглашается с сохранением, то уходим в меиод сохранения
    {
        if (Password.SaveInFile() == true) //если все ок, то выводи сообщение
        {
            Console.WriteLine("\nУспешно сохранено в:  папка с программой/passwords.txt");
        }
        else {  //если не ок, то тоже
            Console.WriteLine("\nОшибка при сохранении!");
        }
     
    }

        return; //завершаем программу

}