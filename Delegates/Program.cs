



List<string> words = new List<string> { "Luka", "Natali", "Zurabi", "Levana", "Dato", "Lasha" };

Predicate<string> predicate = (x) => x.Length > 5;

List<string> filtered = words.FindAll(predicate);

Action<string> printUpper = (x) => Console.WriteLine(x.ToUpper());

filtered.ForEach(printUpper);



MyDelegate myDelegate = PrintSum;

myDelegate(3, 4);

static void PrintSum(int a, int b)
{
    Console.WriteLine(a + b);
}

public delegate void MyDelegate(int x, int y);