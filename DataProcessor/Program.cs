using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

int[] datas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
DataProcessor data = new DataProcessor(datas);

Console.WriteLine("=== 원본 배열 출력 ===");
data.ForEach((i) => Console.Write($"{i} "));
    
Console.WriteLine();

Console.WriteLine("\n=== 2배로 변환 ===");
Console.Write($"{string.Join(" ", data.Transform(i => i * 2))} ");
Console.WriteLine();

Console.WriteLine("\n== 짝수만 필터링 ===");
Console.Write($"{string.Join(" ", data.Filter(i => i % 2 == 0))} ");
Console.WriteLine();

Console.WriteLine("\n=== 합계 계산 ===");
Console.WriteLine($"합계: {data.Reduce((a, b) => a + b, 0)}");