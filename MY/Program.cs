

namespace CS
{
    

internal class Start {

    public static void main(String[] args) {
        
        Menu.homePage();

    }
    

}

}










public partial class Menu
{

    public static void homePage()
    {
        
        Console.Clear();

        System.Console.WriteLine($"Добро пожаловать в лотерею игрушек!!!\n");
        System.Console.WriteLine("Выберите Действие:");

        System.Console.WriteLine($"1 - добавить игрушку в автомат\n2 - посмотреть список игрушек в автомате\n3 - выход");

        int num = Convert.ToUInt16(Console.ReadLine());

        switch (num)
        {
            case 1:

                break;

            case 2:

                break;

            case 3:

                break;


            // default:

        }

    }

}










public partial class Funktions
{

    public static void plusToy()
    {


    }

}


