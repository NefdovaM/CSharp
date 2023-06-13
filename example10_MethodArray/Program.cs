int[] array = { 1, 12, 31, 4, 15, 61, 17, 28 };

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
