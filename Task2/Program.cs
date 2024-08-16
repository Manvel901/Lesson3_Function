void GetSquare(int limit)
{
    int j = 1;
    while (j <= limit)
    {
        Console.Write($"{j * j} ");
        j++;
    }
}
GetSquare(5);
GetSquare(10);
GetSquare(15);