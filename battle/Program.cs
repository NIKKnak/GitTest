


int playerHealth = 100;
int playerDamage = 15;
int enemyHealth = 100;
int enemyDamage = 23;

while (playerHealth > 0 && enemyHealth > 0)
{
    playerHealth -= enemyDamage;
    enemyHealth -= playerDamage;

    System.Console.WriteLine(playerHealth + " игрок");
    System.Console.WriteLine(enemyHealth + " враг");
}

if (playerHealth <= 0 && enemyHealth <= 0)
{
    System.Console.WriteLine("Ничья");
}
else if (enemyHealth <= 0)
{
    System.Console.WriteLine("победа игрока");
}
else if (playerHealth <= 0)
{
    System.Console.WriteLine("победа врага");
}
