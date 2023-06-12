
using System;

Console.WriteLine("Input Num one");
int numOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Num two");
int numTwo = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input Num tree");
int numTree = Convert.ToInt32(Console.ReadLine());
// 
int max;


if (numOne > numTwo) {
    if (numOne > numTree) {
        max = numOne;
    }
    else
    {
        max = numTree;
    }
}
else
{
    if (numTwo > numTree) {
        max = numTwo;
    }
    else {
        max = numTree;
    }
}

Console.WriteLine("max = {0}",max);