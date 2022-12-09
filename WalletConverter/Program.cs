double balanceRub, balanceDollar, balanceEuro;
double tempBalance;
double courseDollar = 64.32;
double courseEuro = 65.32;
int actionConvert;
string exit = " ";

Console.Write("Cколько у вас рублей? - ");
balanceRub = Convert.ToDouble(Console.ReadLine());
Console.Write("Cколько у вас долларов? - ");
balanceDollar = Convert.ToDouble(Console.ReadLine());
Console.Write("Cколько у вас евро? - ");
balanceEuro = Convert.ToDouble(Console.ReadLine());
Console.Clear();
while (true)
{
    Console.WriteLine($"Ваш баланс: {balanceRub} рублей. {balanceDollar} долларов. {balanceEuro} евро.");
    Console.WriteLine();
    Console.WriteLine("Выберите какую операцию вы хотите произвести " +
        "\n 1. Рубли в Доллары " +
        "\n 2. Рубли в Евро " +
        "\n 3. Доллары в Рубли " +
        "\n 4. Евро в Рубли " +
        "\n 5. Доллары в Евро " +
        "\n 6. Евро в Долары");
    Console.WriteLine("Введите номер операции: ");
    actionConvert = Convert.ToInt32(Console.ReadLine());

    switch (actionConvert)
    {
        case 1:
            Console.WriteLine("Сколько рублей вы хотите поменять на доллары?");
            Console.WriteLine("Введите сумму для обмена: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            balanceDollar += tempBalance / courseDollar;
            balanceRub -= tempBalance;
            break;
        case 2:
            Console.WriteLine("Сколько рублей вы хотите поменять на евро?");
            Console.WriteLine("Введите сумму для обмена: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            balanceEuro += tempBalance / courseEuro;
            balanceRub -= tempBalance;
            break;
        case 3:
            Console.WriteLine("Сколько долларов вы хотите поменять на рубли?");
            Console.WriteLine("Введите сумму для обмена: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            balanceRub += tempBalance * courseDollar;
            balanceDollar -= tempBalance;
            break;
        case 4:
            Console.WriteLine("Сколько евро вы хотите поменять на рубли?");
            Console.WriteLine("Введите сумму для обмена: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            balanceRub += tempBalance * courseEuro;
            balanceEuro -= tempBalance;
            break;
        case 5:
            Console.WriteLine("Сколько долларов вы хотите поменять на евро?");
            Console.WriteLine("Введите сумму для обмена: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            balanceEuro += courseDollar / courseEuro * tempBalance;
            balanceDollar -= tempBalance;
            break;
        case 6:
            Console.WriteLine("Сколько евро вы хотите поменять на доллары?");
            Console.WriteLine("Введите сумму для обмена: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            balanceDollar += courseEuro / courseDollar * tempBalance;
            balanceEuro -= tempBalance;
            break;
        default:
            break;
    }

    Console.WriteLine($"Ваш баланс: {balanceRub} рублей. {balanceDollar} долларов. {balanceEuro} евро.");
    if (balanceDollar < 0 || balanceEuro < 0 || balanceRub < 0)
    {
        Console.WriteLine("У вас имеется задолжность, погасите задолжность во избежание проблем");
    }

    Console.WriteLine("Напишите 'Exit' если хотите выйти из программы \nдля продолжения нажмите Enter");
    exit = Console.ReadLine();
    if (exit == "Exit" || exit == "exit")
    {
        break;
    }

    Console.Clear();
}
