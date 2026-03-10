using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Calculator anonymous = delegate (int x)
{
    return x * x;
};
Calculator lambda1 = x =>
{
    return x * x;
};
Calculator lambda2 = x => x * x;

Console.WriteLine($"익명 메서드: {anonymous(5)}");
Console.WriteLine($"람다식 (블록): {lambda1(5)}");
Console.WriteLine($"람다식 (표현식): {lambda2(5)}");
Console.WriteLine();

EventHandler handler1 = delegate
{
    Console.WriteLine("이벤트 처리됨");
};
EventHandler handler2 = (sender, e) => Console.WriteLine("이벤트 처리됨");

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);
Console.WriteLine();

GameEvent onScoreChange = delegate { };
GameEvent onGameOver = delegate { };
onScoreChange("점수 변경", 100);
onGameOver("게임 종료", 0);

onScoreChange += delegate(string eventName, int value)
{
    Console.WriteLine($"[이벤트] {eventName}: {value}");
};
onScoreChange("점수 변경", 500);
Console.WriteLine();

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

static void ProcessData(int[] datas, Action<int> callback)
{
    foreach (int data in datas)
    {
        callback(data);
    }
}
ProcessData(numbers, delegate (int n)
{
    sum += n;
    Console.WriteLine($"처리 중: {n}, 누적: {sum}");
});

Console.WriteLine($"최종 합계: {sum}");


delegate int Calculator(int x);
delegate void EventHandler(object sender, EventArgs e);
delegate void GameEvent(string s, int i);