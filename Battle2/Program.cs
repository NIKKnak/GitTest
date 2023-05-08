
namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fighter[] fighters =
            {
                new Fighter("Джон", 500, 50,0),
                new Fighter("Марк", 250, 25,20),
                new Fighter("Алекс", 150, 100,10),
                new Fighter("Джек", 300,75,5),

            };

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write((i + 1) + " ");
                fighters[i].ShowStats();
            }

        }
    }


    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }


        public void ShowStats()
        {
            Console.WriteLine($"Боец - {_name}, здоровье: - {_health}, наносимый урон: - {_damage}, броня: - {_armor}");
        }

        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}");
        }


        public void TakeDamade(int damage)
        {
            _health -= damage - _armor;
        }



    }
}