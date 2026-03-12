using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 단순 카운터 ===");
var count1 = CounterFactory.CreateSimpleCounter();

for (int i = 0; i < 5; i++)
{
    Console.Write($"{count1} ");
}
