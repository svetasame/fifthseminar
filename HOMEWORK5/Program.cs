
//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

static int Prompt(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int [] GenerateArray (int Length)
{
  int [] array = new int [Length];
  Random ran = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = ran.Next(100, 1000);
  }
  return array;
}

void PrintArray (int[] array)
{
  string sa = string.Join(", ", array);
  System.Console.WriteLine($"[{sa}]");
}

void FindEven (int[] array)
{
int res = 0;
for (int i = 0; i < array.Length; i++)
  {
    if (array [i] % 2 == 0)
    res++;
  }
  System.Console.WriteLine($"Количество четных чисел = {res}");
}

void Task34()
{
int length = Prompt("Длина массива: ");
int [] arrayran = GenerateArray(length);
PrintArray (arrayran);
FindEven (arrayran);
}

Task34();


