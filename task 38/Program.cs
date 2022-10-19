// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
var array = new double[size];
var rnd = new Random();

for (int i = 0; i < size; i++)
{
double rndNum = rnd.NextDouble() * (max - min) + min;
array[i] = Math.Round(rndNum, 2);

}
return array;
}

void PrintArrayDouble (double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

double MaxElementArray(double[] array, double max)
{
    max = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] > max) max = array [i] ;
    }
    return max;
}

double MinElementArray(double[] array, double min)
{
    min = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] < min) min = array [i];
    }
    return min;
}


double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(arr);
double maxEl = default;
double minEl = default;
double maxElementArray = MaxElementArray (arr, maxEl);
double minElementArray = MinElementArray (arr, minEl);
double diffOfMaxMinElem = Math.Round((maxElementArray - minElementArray), 2);
Console.WriteLine ($"-> {diffOfMaxMinElem}");
