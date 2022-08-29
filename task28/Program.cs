// Напишите программу, которая задает массив из 8 элементов, заполненный
// псведослучайными числами и выводит их на экран
// 1,2,5,7,19->[1,2,5,7,19]
// 6,1,33 -> [6,1,33]

int[] result = CreateArray (8, 1, 100);
PrintArray(result);

int[] CreateArray (int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if ( i < array.Length -1) Console.Write(array[i] + ", "); 
}
Console.Write(array[array.Length-1]);
Console.Write("]");
}