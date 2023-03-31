
Queue<string> patients = new Queue<string>();

patients.Enqueue("Василий");
patients.Enqueue("Леша");
patients.Enqueue("Рома");
patients.Enqueue("Вова");

System.Console.WriteLine("На прием идет " + patients.Dequeue());
System.Console.WriteLine("Cледующий в очереди " + patients.Peek());

foreach (var patien in patients)
{
    System.Console.WriteLine(patien);
}


