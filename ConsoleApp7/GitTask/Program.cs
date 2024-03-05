PlayGame();

void PlayGame()
{
    var RandNum = Random.Shared.NextInt64(1, 101);
    Console.Write("Введите имя: ");
    var name = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"Здравствуйте, {name}!");
    Console.WriteLine("Правила игры: угадать загаданное число за наименьшее количество попыток");
    Console.WriteLine();
    var Count = 0;

    while (true)
    {
        Count++;

        var input = Convert.ToInt32(Console.ReadLine());

        if (input == RandNum)
        {
            Console.WriteLine($"Поздравляю, вы угадали! Попыток потребовалось: {Count}");

            Console.WriteLine("Еще раз?");

            if (Console.ReadLine() == "да")
            {
                PlayGame();
            }

            break;
        }

        Console.WriteLine(
            input > RandNum
                ? "Слишком много"
                : "Слишком мало");
    }
}