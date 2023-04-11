
namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Table[] tables = {new Table(1,4), new Table(2,8), new Table(3,10)};
            

            while (isOpen)
            {
                
                System.Console.WriteLine("Администрирование кафе\n");

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\nВведите номер стола: ");
                int withTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("\nВведи количество мест для брони: ");
                int desiredPlaces = Convert.ToInt32(Console.ReadLine());

                bool isResevationCompleted = tables[withTable].Reserv(desiredPlaces);

                if (isResevationCompleted)
                {
                    System.Console.WriteLine("Бронь прошла успешно!");
                }
                else
                {
                    System.Console.WriteLine("Бронь не прошла. Недостаточно мест.");
                }



                Console.ReadKey();
                Console.Clear();
            }


        }




class Table
{
    public int Number;
    public int MaxPlaces;
    public int FreePlaces;


    public Table(int number, int maxPlaces)
    {
        Number = number;
        MaxPlaces = maxPlaces;
        FreePlaces = maxPlaces;
    }

    public void ShowInfo()
    {
        System.Console.WriteLine($"Стол {Number}, свободных мест {FreePlaces} из {MaxPlaces}.");
    }


    public bool Reserv(int places)
    {
        if (FreePlaces >= places)
        {
            FreePlaces -=places;
            return true;
        }
        else
        {
            return false;
        }



    }















}

























    }
}