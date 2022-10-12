 # Задача.
---
 ### Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуеться пользоваться коллекциями, лутше обойтись исключительно массивами. 
---
 ### Решение:
 1. Запрос у пользователя длины массива
 
 ```C#
 Console.Write("Введите длину массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());

 ```
 и элементов массива через функцию 
```C#
void FillArray(string[] arg)
{
  for (int i = 0; i < arg.Length; i++)
  { 
    Console.WriteLine($"Ввдите {i+1} элемент массива");
    arg[i] = Console.ReadLine();
  }
}
```
обявление второго массива c длина котрого функция первого массива с элементами меньше или равно 3. 
```C#
string[] secondArray = new string[LengthArray(firstArray)];
```
добовлем второму массиву количеству элементы перого массива меншьше и равно 3 методом
```C#
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
```
```C#
secondArray = CopyArray(firstArray, secondArray);
``` 
вывод методом вывода
```C#
void PrintArray(string[] arg)
{
  for (int i = 0; i < arg.Length; i++)
  {
    Console.Write($"{arg[i]} ");
  }
}
```
```C#
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
```