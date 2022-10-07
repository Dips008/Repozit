int[] array = { 99, 35, 13, 65, 4, 6, 7, 99 };
int n = array.Length;
int find = 99;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}