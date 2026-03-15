using System;

class CounterFactory
{
    // 1. 단순 카운터: 호출할 때마다 내부 count 변수를 1씩 증가
    public static Func<int> CreateSimpleCounter()
    {
        int count = 0; // 클로저에 의해 캡처될 로컬 변수
        return () =>
        {
            count++;
            return count;
        };
    }

    // 2. 스텝 카운터: 지정된 step만큼 증가
    public static Func<int> CreateStepCounter(int step)
    {
        int count = 0;
        return () =>
        {
            count += step;
            return count;
        };
    }

    // 3. 범위 카운터: min ~ max 사이를 순환
    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = min;
        return () =>
        {
            int current = count;
            count++;
            if (count > max) count = min; // 범위를 넘어가면 min으로 초기화
            return current;
        };
    }

    // 4. 리셋 가능 카운터: out을 통해 리셋 액션과 카운트 함수를 반환
    public static void CreateResettableCounter(out Action reset, out Func<int> getCount)
    {
        int count = 0;

        reset = () => count = 0; // 외부에서 호출 시 count를 0으로 만듦

        getCount = () =>
        {
            count++;
            return count;
        };
    }
}