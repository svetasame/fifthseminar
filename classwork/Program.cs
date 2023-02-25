
// задайте массив из 12 элементов из промежутка [-9,9]
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

