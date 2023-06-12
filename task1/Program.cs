using System;

Console.WriteLine("Input Num one");
int numOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Num two");
int numTwo = Convert.ToInt32(Console.ReadLine());
int max;


if (numOne > numTwo) {
    max = numOne;
}
else
{
    max = numTwo;
}

Console.WriteLine("max = {0}",max);