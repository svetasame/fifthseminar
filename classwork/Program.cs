
// Task31 задайте массив из 12 элементов из промежутка [-9,9]
// найдите сумму отрицательных и положительных чисел
#region
int negative = 0, positive = 0;
int [] arrayResult = new int [12];

int [] GetArray ()
{
  int [] array = new int [12];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-9, 10);
  }
  return array;
}

void SumArray(int[] array)
{
foreach (int element in array) //не задаем индексы и пределы, 
//он проходит по всему массиву сам el это элемент
  {
    if (element > 0)
    positive += element;
    else
    negative += element;
  }
}

void PrintResult (int[] array, int positive, int negative)
{
  System.Console.WriteLine($"Array result is{String.Join("|", array)}");
  System.Console.WriteLine($"Positive sum is: {positive}, Negative sum is: {negative}");
}

void Task31 ()
{
arrayResult = GetArray();
SumArray (arrayResult);
PrintResult (arrayResult, positive, negative);
}
#endregion
//Task31();

//Task32 программа замены элементов массива
//положительные на отрицательные и наоборот
#region
void Task32()
{
  int length = Prompt("Длина массива: ");
  int min = Prompt("Начальное значение для диапазона: ");
  int max = Prompt("Конечное значение значение для диапазона: ");
  int [] array = GenerateArray (length, min, max);
  PrintArray (array);
  ChangeArray(array);
}

static int Prompt(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int [] GenerateArray (int Length, int minValue, int maxValue)
{
  int [] array = new int [Length];
  Random ran = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = ran.Next(minValue, maxValue + 1);
  }
  return array;
}

void PrintArray (int[] array)
{
  string sa = string.Join(", ", array);
  System.Console.WriteLine($"[{sa}]");
}

void ChangeArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
  {
    if (array [i] > 0)
  array [i] = - array [i];

    else
   array [i] = - array [i];
  }
 string change = string.Join(", ", array);
  System.Console.WriteLine($"[{change}]");
}
#endregion
//Task32();

//Task33 задайте массив. программа которая 
//определяет есть ли это в массиве
#region

void Task33()
{
  int length = Prompt("Длина массива: ");
  int min = Prompt("Начальное значение для диапазона: ");
  int max = Prompt("Конечное значение значение для диапазона: ");
  int [] array = GenerateArray (length, min, max);
PrintArray (array);
CheckArray(array);
}

void CheckArray(int[] array)
{
int number = Prompt("Введите число: ");
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    res = res + 1;
      else
    res = res + 0;
}
if (res > 0)
  System.Console.WriteLine("Данное число ЕСТЬ в массиве");
else
  System.Console.WriteLine("Данного числa НЕТ в массиве");
}
#endregion
//Task33 ();

//варианты группы
//Task_32_1 ();
static void Task_32_1 ()
{
  int [] arr = new int [8];
  Random rand = new Random ();
  for (int i = 0; i <arr.Length; i++)
  {
    arr[i] = rand.Next (-10,11);
    System.Console.Write($"{arr[i]}\t"); // \t - помогает вывести массив в строку
  }
  System.Console.WriteLine();
  for (int i = 0; i <arr.Length; i++)
  {
    arr[i] *= -1;
    System.Console.Write($"{arr[i]}\t");
  }
}

//Task_33_1 ();
#region
void Task_33_1 ()
{
  int [] arr = {6, 5, 6, 7, 10, 1};
  int number = Prompt ("введите число для проверки: ");
  int index = 0;
  // задали индекс вне всей функции

if (FindNumb(arr, number, out index) == true)
// добавили к выводу переменную индекс
{
System.Console.WriteLine($"Число {number} есть в массиве под индексом {index}");
}
else
System.Console.WriteLine($"Числа {number} нет в массиве");
}

bool FindNumb (int [] arr, int number, out int index)
//  out int index)  - добавили переменную индекс
{
for (index = 0; index < arr.Length; index ++)
{
  if (arr[index] == number)
  return true;
  }
  return false;
}
#endregion

