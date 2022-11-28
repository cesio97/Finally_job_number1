Console.WriteLine("Введите длинну массива:");
int N =int.Parse(Console.ReadLine());
string[] array = new string[N];

newArray(array);
printArray(array);
printNewArray(array);

void newArray(string[]array)
{
  Console.WriteLine("Введите массив строк:");
    for (int i=0;i<array.Length;i++)
    {
      Console.Write($"{array[i]}");
      array[i] = Console.ReadLine();
    }
}

void printArray(string[]array)
{
  Console.WriteLine("Первоначальный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
          if (i < (array.Length -1)) Console.Write($", ");
    }
  Console.WriteLine(" ");
}

void printNewArray(string[]array)
{
  Console.WriteLine("Новый массив:");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]}");
        if (i < (array.Length -2)) Console.Write($", ");
    }
  Console.WriteLine(" ");
}
