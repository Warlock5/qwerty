
void FillArray(int [] collection)
{
   int Length = collection.Length;
   int index = 0;
   while (index < Length) 
   {
    collection[index] = new Random().Next(1, 10);
    index++;
   }

}

void PrintArray(int[] col)
{
    int count =col.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

//int [] array = new int[10];
//FillArray(array);
//PrintArray(array);


int indexOf(int[] colltction, int find)
{
    int count = colltction.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(colltction[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
array[4] =4;
array[6] =4;
PrintArray(array);
System.Console.WriteLine();

int pos = indexOf(array, 4);
System.Console.WriteLine(pos);
