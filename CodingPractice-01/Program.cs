using System;

// README.md를 읽고 아래에 코드를 작성하세요.

static int Square(int x)
{
    return x * x;
}
Calculator calc = Square;
Console.WriteLine(calc(5));
Console.WriteLine();

Transformer square = delegate(int x)
{
    return x * x; 
};

Transformer cube = delegate (int x)
{
    return x * x * x;
};

Console.WriteLine($"3의 제곱: {square(3)}");
Console.WriteLine($"3의 세제곱: {cube(3)}");
Console.WriteLine();

Printer print = delegate (string msg)
{
    Console.WriteLine($"[메시지] {msg}");
};
print("안녕하세요!");
print("익명 메서드를 사용 중입니다.");
Console.WriteLine();

Func<int, int> doubler = delegate (int x)
{
    return x * 2;
};

Action<string> logger = delegate (string msg)
{
    Console.WriteLine($"[LOG] {msg}");
};

Console.WriteLine(doubler(10));
logger("작업 시작");
Console.WriteLine();

SimpleDelegate handler = delegate
{
    Console.WriteLine("매개변수를 사용하지 않습니다.");
};
handler(100, "테스트");
Console.WriteLine();

EventHandler onClick = delegate
{
    Console.WriteLine("클릭 이벤트 발생!");
};
onClick(null, EventArgs.Empty);


delegate int Calculator(int x);
delegate int Transformer(int x);
delegate void Printer(string s);
delegate void SimpleDelegate(int a, string b);
delegate void EventHandler(object sender, EventArgs e);