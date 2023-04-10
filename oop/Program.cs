
namespace CSharp
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Car ferrari = new Car();
            
            ferrari.Name = "F40";
            ferrari.HorsePower = 471;
            ferrari.Age = 30;
            ferrari.MaxSpeed = 317.0f;


            Car maseratti;

            maseratti = ferrari;
            maseratti.HorsePower = 1000;

            System.Console.WriteLine(ferrari.HorsePower);


        }
    }

    class Car
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;


    }

}