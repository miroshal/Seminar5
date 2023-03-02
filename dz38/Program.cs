// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] nums = new double[size];
FillArrayRandomNumbers(nums);
PrintArray(nums);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x =0; x < nums.Light; x++)
{
    if (nums[X] > max) max = nums[x];
    if (nums[x] < min) min = nums[x];
}