Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть перше число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введіть друге число: ");
int b = int.Parse(Console.ReadLine());

int r = a + b;

Console.WriteLine($"Результат додавання: {r}");