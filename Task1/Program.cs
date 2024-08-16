double DzSum(int a, int b, int c, int d)
{
    double er = a * b;
    int at = c + d;
    double result = er / at;
    return result;
}
double result = DzSum(0, 5, 8, 9);
Console.Write(result);