// угадай число

int number;
int lower, higher;
int triesCount = 5;
int userInpt;
Random rand = new Random();

number = rand.Next(0, 101);
lower = rand.Next(number - 10, number);
higher = rand.Next(number + 1, number + 10);
System.Console.WriteLine($"От 0 до 100, оно больше чем {lower}, но меньше чем {higher} ");
System.Console.WriteLine($"Что это за число? у вас {triesCount} попыток");

while (triesCount-- > 0)
{
    System.Console.WriteLine("Ваш ответ: ");
    userInpt = Convert.ToInt32(Console.ReadLine());
    if (userInpt == number)
    {
        System.Console.WriteLine($"Вы правы, это число {number}");
        break;
    }
    else
    {
        System.Console.WriteLine("Не верно");
    }
}
if (triesCount < 0)
{
    System.Console.WriteLine($"Вы проиграли, это было число {number}");
}