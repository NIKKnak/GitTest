

Stack<int> numbers = new Stack<int>();

numbers.Push(1);
numbers.Push(2);
numbers.Push(3);
numbers.Push(4);
numbers.Push(5);

// System.Console.WriteLine(numbers.Peek());


// numbers.Pop();



foreach (var number in numbers)
{
    System.Console.WriteLine(number);
}


while (numbers.Count > 0)
{
    System.Console.WriteLine("Следующее число в стеке " + numbers.Pop());
}
