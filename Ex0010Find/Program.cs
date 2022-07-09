int[] array = { 1, 12, 31, 4, 14, 16, 16, 19 };

int n = array.Length;
int find = 16;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;    
    }    
        index++;
}