


Dictionary<string, string> countrieCapitals = new Dictionary<string, string>();

countrieCapitals.Add("Австралия","Канберра");
countrieCapitals.Add("Турция","Анкара");
countrieCapitals.Add("Швейцария","Берн");



countrieCapitals.Remove("Турция");



foreach (var key in countrieCapitals.Keys)
{
    System.Console.WriteLine($"Страна - {key}");
}