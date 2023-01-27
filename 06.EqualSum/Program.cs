int[] array = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

for(int i = 0;i < array.Length; i++)
{
    int leftsum = 0;
    int rightsum = 0;

    for (int j = 0; j < i; j++)
    {
        leftsum += array[j];
    }
    for (int j = i+1; j < array.Length; j++)
    {
        rightsum += array[j];
    }
    if (leftsum == rightsum)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine("no");