// Задача. Написать программу, которая из имеющего массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуеться
// пользоваться коллекциями, лутше обойтись исключительно массивами. 
// Пример:
//  ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//  ["1234", "1567", "-2", "computer science"] -> ["-2"]
//  ["Russia", "Denmark", "Kazan"] -> []
Console.Clear();

void PrintArray(string[] arg)
{
  for (int i = 0; i < arg.Length; i++)
  {
    Console.Write($"{arg[i]} ");
  }
}

int LengthArray(string[] arg)
{
  int cout = 0;
  for (int i = 0; i < arg.Length; i++)
  {
    if (arg[i].Length <= 3)
    {
      cout++;
    }
  }
  return cout;
}

string[] CopyArray(string[] arg, string[] arg1)
{
  for (int i = 0; i < arg1.Length; i++)
  {
    int index = 0;
    for (int j = 0; j < arg.Length; j++)
    {
      if (arg[j].Length <= 3)
      {
        arg1[index] = arg[j];
        index++;
      }
    }
  }
  return arg1;
}


string[] firstArray = { "hello", "2", "world", ":-)" };
string[] secondArray = new string[LengthArray(firstArray)];

secondArray = CopyArray(firstArray, secondArray);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
