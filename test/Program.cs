

List<int> numbers = new List<int>();
numbers.Add(12);
numbers.Add(5);
numbers.Add(8);
// numbers.Add(14);
// numbers.Add(22);


// numbers.AddRange(new int[] {3,4,5,6});


// numbers.Clear();
numbers.Insert(0,000);
numbers.Insert(1,111);
numbers.Insert(2,222);

for (int i = 0; i < numbers.Count; i++)
{

    System.Console.WriteLine(numbers[i]);


}