using System;

Console.WriteLine("Input Num");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0) {
        Console.WriteLine("even = {0}", i);
    }
    // else {
    //     Console.WriteLine("odd = {0}", i);
    // }
}