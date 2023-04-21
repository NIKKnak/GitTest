
namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();

            ferrari.ShowTechnicalPasport();
        }
    }



    class Car
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;

        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            if (horsePower < 0)
            {
                HorsePower = 1;
            }
            else
            {
                HorsePower = horsePower;
            }

            Name = name;
            Age = age;
            MaxSpeed = maxSpeed;
        }
        public Car()
        {
            Name = "Ford";
            HorsePower = 500;
            Age = 1;
            MaxSpeed = 300;

        }
        public void ShowTechnicalPasport()
        {
            System.Console.WriteLine($"Название авто: {Name}\nКоличество лошадиных сил: {HorsePower}" +
                                     $"\nВазраст авто: {Age}\nМаксимальная скорость: {MaxSpeed} км/ч");
        }
        public void BecomeOlder(int years, int runAwayHorses)
        {
            Age += years;
            HorsePower -= runAwayHorses;
        }

    }

}