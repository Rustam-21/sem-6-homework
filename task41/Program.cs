Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

int[] nums = new int[m];

int count = 0; //счетчик чисел больше 0

for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    nums[i] = num;
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine($"Массив: {string.Join(", ", nums)}");
Console.WriteLine($"Количество чисел больше 0: {count}");