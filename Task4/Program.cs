Random rnd = new Random();
int n = 100;
int[] arr = new int[n];
int j = 0;
while (j < n)
{
    arr[j] = rnd.Next(1, 3);
    j++;
}
j=0;
while (j<n)
{
    Console.Write($"{arr[j]} ");
    j++;
}
