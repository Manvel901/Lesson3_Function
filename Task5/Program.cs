int n = 5;
int[] arr = new int[n];
int j = 0;
while (j < n)
{
    Console.Write("Введите начальное (целое)число: ");
    string input = Console.ReadLine();
    arr[j] = Convert.ToInt32(input);
    j++;
}
for (j = 0; j < n; j++)
{
    if (arr[j] % 3 == 0)
    {
        arr[j] = 0;
    }

}
j = 0;
while (j < n)
{
    Console.Write($"{arr[j]} ;");
    j++;
}
