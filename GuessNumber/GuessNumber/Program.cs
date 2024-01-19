//by Danila Yudin
Restart:
Console.Clear();
Console.WriteLine("Игра: Угадай число\nПравила: вы указываете минимаьный и максимальный диапазон случайного числа(диапазон должен быть >= 5)");
Console.WriteLine("После этого вы начнете угадывать число загаданное компьютером. Указывайте число, которое вы хотите предложить как: \"15?\"");
Console.WriteLine("После этого компьютер сообщит вам, угадали вы или нет. В случае если нет, вам предложат продолжить угадывать");
Console.WriteLine("Чем меньше попыток для угадывания - тем круче. Удачи!");
Console.WriteLine("Ну что, поиграем?)");

int min = 0;  //минимальная граница числа для отгадывания
int max = 0;    //макс граница числа
int num = 0;    //само число

Console.WriteLine("\nВведите минимальную границу числа:");
    min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальную границу числа(>= 5 от минимальной):");
    max = int.Parse(Console.ReadLine());

//проверка корректности ввода чисел-границ
if (max < min + 5) { Console.WriteLine("Неверные параметры границ! Попробуйте еще раз:"); Console.ReadKey(); goto Restart; }

int counter = (max - min)/2;// создание счетчика кол-ва попыток/оставшихся попыток
int oldCounter = counter;
Random rnd = new Random();
int rndnum = rnd.Next(min, max);//генерируем случайное число, которое и будут угадывать

Console.WriteLine($"У вас {counter} попыток");

Console.WriteLine($"Введите число от {min} до {max} включительно");
while (counter > 0)             //пока попытки не закончились
{
    num = int.Parse(Console.ReadLine());//вводим число и проверяем совпадение
    if (num == rndnum)
    {
        Console.WriteLine($"Вы угадали!!! Количество попыток - {oldCounter - counter + 1}");
        Console.WriteLine("Хотите продолжить игру?");
        Console.WriteLine("\t\tДа(Enter)\t\tНет(Esc)"); //если совпадение имеется, то указываем кол-во попыток,
                                                        //предлагаем продолжить игру или окончить
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            goto Restart;       //если продолжаем, то возвращаемся к началу
        }
        else if (Console.ReadKey().Key == ConsoleKey.Escape) {
            System.Environment.Exit(0);     //если нет, то выходим из программы
        }
    }
    else { 
        Console.WriteLine("Пока неверно"); //а иначе уменьшаем счетчик
    }
    counter--;
    if (counter == 0) {
        Console.WriteLine("Попытки закончились");
        Console.WriteLine("Хотите продолжить игру?");
        Console.WriteLine("\t\tДа(Enter)\t\tНет(Escape)");  //те же действия после окончания игры, что и ранее
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            goto Restart;
        }
        else if (Console.ReadKey().Key == ConsoleKey.Escape)
        {
            System.Environment.Exit(-1);
        }
    }
}