void ZeroElement(int[] arr)
{
    for (int j =0; j<arr.Length; j++)
    {
        if (arr[j] % 2 == 0)
        {
            arr[j]=0;
        }
    }
}
void PrintElement(int[] arr)
{
    foreach( int e in arr)
    {
        Console.Write($"{e} ");

    }
}
int[] array ={41,6,81,22,9,5,34};
ZeroElement(array);
PrintElement(array);