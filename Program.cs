Console.WriteLine("Введите количество элементов массива:");
int m = Convert.ToInt32(Console.ReadLine());
if (m > 0)
{
Console.WriteLine("Введите элементы массива:");
string[] array = new string[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = Console.ReadLine();
    }
    Console.WriteLine($"Элементы 3 и менее:");
    for (int j = 0; j < m; j++)
    {
        if (array[j].Length <= 3)
        {
            Console.WriteLine(array[j]);
        }   
    }
}
else Console.WriteLine("Error");