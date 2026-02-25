using System;
using System.Collections.Generic;
using System.Text;

class Counter
{
    int Count;
    public void Increment()
    {
        Count++;
        Console.WriteLine($"현재 카운트: {Count}");
    }

    public void Reset()
    {
        Count = 0;
        Console.WriteLine("카운트가 초기화 되었습니다.");
    }
    
}