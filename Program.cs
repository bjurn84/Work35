int [] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1000);
    }
    return arr;
}

Console.Write("Введите число массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 & array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел от 10 до 99 это {count}");
