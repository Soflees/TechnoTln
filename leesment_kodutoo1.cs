Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Tere tulemast arvumängu!");
Console.WriteLine("Arva ära number vahemikus 1-100!");

Random random = new Random();
int targetNumber = random.Next(1, 101);

while (true)
{
    Console.Write("Sisesta oma arv: ");
    string input = Console.ReadLine();

    // Проверяем, ввел ли пользователь число
    if (int.TryParse(input, out int userGuess))
    {
        if (userGuess < 1 || userGuess > 100)
        {
            Console.WriteLine("Palun sisesta number vahemikus 1-100.");
            continue;
        }

        if (userGuess == targetNumber)
        {
            Console.WriteLine("Õnnitleme! Arvasid õigesti!");
            break;
        }
        else if (userGuess > targetNumber)
        {
            Console.WriteLine("Arv on väiksem (väiksem number)");
        }
        else
        {
            Console.WriteLine("Arv on suurem (suurem number)");
        }
    }
    else
    {
        Console.WriteLine("Palun sisesta kehtiv täisarv!");
    }
}ˇˇ
