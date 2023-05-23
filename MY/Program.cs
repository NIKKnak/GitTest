

namespace CS
{
    

internal class Start {

    public static void main(String[] args)
    {
        
        Character[] character  =
        {
            new Character("Разбойник", 10,10,100,20,0,20),
            new Character("Воин",20,20,150,5,0,5),
            new Character("Маг",30,5,80,5,100,5),

        };



    }
    

}

class Character
{
    private string _name;
    private int _damage;
    private int _armor;
    private int _health;
    private int _agility; //ловкость
    private int _mana;
    private int _speed;

    public Character(string name, int damage, int armor, int health, int agility, int mana, int speed)
    {
        _name = name;
        _health = health;
        _damage = damage;
        _armor = armor;
        _agility = agility;
        _mana = mana;
        _speed = speed;
    }


    public void ShowStats()
    {
        System.Console.WriteLine($"Персонаж: {_name}, Здоровье: {_health}, Урон {_damage}, Защита: {_armor}, Улонение: {_agility}, Мана: {_mana}, Скорость: {_speed}");
    }

    public void Damage()
    {
        _health -= _damage - _armor;
    }




}


}








