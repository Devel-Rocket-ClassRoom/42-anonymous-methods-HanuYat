using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Calculator calc = delegate (int x)
{
    return x * x;
};
Console.WriteLine(calc(5));
Console.WriteLine();

int factor = 3;
Func<int, int> multiplier = delegate (int n)
{
    return n * factor;
};
Console.WriteLine(multiplier(10));
Console.WriteLine();

int factor2 = 2;
Func<int, int> multi = delegate (int n)
{
    return n * factor2;
};
Console.WriteLine($"factor2 = 2일 때: {multi(5)}");

factor2 = 10;
Console.WriteLine($"factor2 = 10일 때: {multi(5)}");
Console.WriteLine();

int counter = 0;
Action increment = delegate ()
{
    counter++;
    Console.WriteLine($"현재 카운터: {counter}");
};

increment();
increment();
increment();

Console.WriteLine($"최종 카운터: {counter}");
Console.WriteLine();

static Func<int> CreateCounter()
{
    int count = 0;
    return delegate ()
    {
        count++;
        return count;
    };
}

var counter1 = CreateCounter();
var counter2 = CreateCounter();

Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter2: {counter2()}");
Console.WriteLine($"counter2: {counter2()}");

delegate int Calculator(int x);