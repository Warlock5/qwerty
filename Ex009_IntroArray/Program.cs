﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 11, 21, 31, 41, 51, 14, 24, 64, 65, 33, 45 };

int result = Max(
    Max(array[0], array[2], array[3]),
    Max(array[4], array[5], array[6]),
    Max(array[7], array[8], array[9])
);
System.Console.WriteLine(result);


