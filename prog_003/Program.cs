/*
Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

using static System.Console;
Clear();


WriteLine("Введите число.");
int a=int.Parse(ReadLine());
FibArr(a);




void FibArr(int size)
{
    if (size==0) WriteLine($"[{size}]");
    else if (size==1) WriteLine($"[{(size-1)}, {size}]");
    else
        {
            int [] result=new int [size];
            result[0]=0;
            result[1]=1;
            for(int i=2; i<size;i++)
            {
                result[i]=result[i-1]+result[i-2];
            }
            WriteLine($"[{String.Join(" ,", result)}]");
        }
}