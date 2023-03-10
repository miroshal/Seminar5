// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArrayRandomNumbers(int[] nums)
{
    for (int i = 0; i < nums.Lenght; i++)
    {
        nums[i] = new Random().Next(1, 1000);
    }
}
void PrintArray(int[] nums)
{
    Console.Write(" [ ");
    for (int i = 0; i < nums.Lenght; i++);
    {
        Console.Write(nums[i] + ",");
    }
    Console.Write(" ] ");
}

Console.Clear();
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArrayRandomNumbers(nums);
PrintArray(nums);
int sum = 0;

for (int x = 1; x < nums.Lenght; x += 2)
    sum = sum + nums[x];

Console.WriteLine($" ->  {sum}");