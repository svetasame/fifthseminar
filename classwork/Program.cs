
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
#region
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
#endregion

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

// задача 35 найдите массив из 123 слуйчайных чисел
// найдите кол во элементов, значения которых лежит в отрезке [10, 99]
#region
int [] array123 = new int [123];
int [] GetArray123 ()
{
  int [] array = new int [123];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 124);
  }
  return array;
}

void FindAndSumArray(int[] array)
{
int res = 0;
for (int i = 0; i < array.Length; i++)
  {
    if (array [i] > 10 && array [i] < 99)
    res += 1;
  }
  System.Console.WriteLine($"Количество числет от 10 до 99 = {res}");
}

void Task35()
{
array123 = GetArray123();
PrintArray (array123);
FindAndSumArray (array123);
}
#endregion
//Task35();


// задача 37 найти произведение пар чисел в одномерном
//массиве. пара это первый и последный элемент, 2 и предпоследний и тд 
//результат в новом массиве

#region
int [] GetArrayRan(int length)
{
  int [] array = new int [length];
  for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(1, 10);
    }
  return array;
}

void SumOfPair(int[] array)
{
int sum = 0;
int i = 0;
int j = array.Length - 1;
if (array.Length % 2 == 0)
  {
  while (i < array.Length &&  j >= array.Length/2)
  {
    sum = array[i] + array[j];
    Console.Write($"{array[i]} + {array[j]} = {sum}" + " ");
    i++;
    j--;
    }
  }
else
  {
  while (i < array.Length &&  j > array.Length/2)
  {
    sum = array[i] + array[j];
    Console.Write($"{array[i]} + {array[j]} = {sum}" + " ");
    i++;
    j--;
    }
}
}

static int Prompt1(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

void Task37()
{
int length = Prompt1("Длина массива: ");
int [] arrayran = GetArrayRan(length);
PrintArray (arrayran);
SumOfPair (arrayran);
}
#endregion

Task37();