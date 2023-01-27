int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int longestSequenceStartIndex = 0;
int longestSequenceLength = 0;

for(int i = 0;i < numbers.Length; i++)
{
    int currentSequenceStart = i - 1;
    int currentSequenceLength = 1;

    while (i < numbers.Length && numbers[i] == numbers[i - 1])
    {
        currentSequenceLength++;
        i++;
    }

    if (currentSequenceLength > longestSequenceLength)
    {
        longestSequenceLength = currentSequenceLength;
        longestSequenceStartIndex = longestSequenceStartIndex;
    }
}

for(int i = longestSequenceStartIndex;i < longestSequenceStartIndex + longestSequenceLength; i++)
{
    Console.Write($"{numbers[i]}");
}