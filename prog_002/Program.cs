/*
Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

*/

using static System.Console;
Clear();
WriteLine("Введите число.");
int nuber10=int.Parse(ReadLine());
int size=$"{nuber10}".Length;
WriteLine(BinNumber(nuber10));


string BinNumber(int number)
{
    string number_bin="";
    while (number>0)
    {
    
        if(number%2==0)
        {
            number_bin+="1";
         }
         else
         {
            number_bin+="0";
         }
         number/=2;
    }
    return number_bin;
}