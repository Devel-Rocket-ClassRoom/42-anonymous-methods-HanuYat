using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

int[] datas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
DataProcessor data = new DataProcessor(datas);

Console.WriteLine("=== 원본 배열 출력 ===");
foreach (int i in datas)
{
    Console.Write($"{data.ForEach(i)} ");
}
