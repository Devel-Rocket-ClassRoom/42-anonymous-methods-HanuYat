using System;

// 1. 단순 카운터
Console.WriteLine("=== 단순 카운터 ===");
var count1 = CounterFactory.CreateSimpleCounter();
for (int i = 0; i < 5; i++)
{
    Console.Write($"{count1()} "); // count1은 함수이므로 ()로 호출해야 함
}
Console.WriteLine("\n");

// 2. 스텝 카운터 (step=3)
Console.WriteLine("=== 스텝 카운터 (step=3) ===");
var count2 = CounterFactory.CreateStepCounter(3);
for (int i = 0; i < 4; i++)
{
    Console.Write($"{count2()} ");
}
Console.WriteLine("\n");

// 3. 범위 카운터 (1~3)
Console.WriteLine("=== 범위 카운터 (1~3) ===");
var count3 = CounterFactory.CreateBoundedCounter(1, 3);
for (int i = 0; i < 7; i++)
{
    Console.Write($"{count3()} ");
}
Console.WriteLine("\n");

// 4. 리셋 가능 카운터
Console.WriteLine("=== 리셋 가능 카운터 ===");
CounterFactory.CreateResettableCounter(out Action reset, out Func<int> count4);

Console.Write("호출: ");
for (int i = 0; i < 3; i++) Console.Write($"{count4()} ");

reset(); // 리셋 실행

Console.Write("\n리셋 후: ");
for (int i = 0; i < 2; i++) Console.Write($"{count4()} ");
Console.WriteLine();