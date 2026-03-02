using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string Name;
    public int Score;

    public override string ToString()  // 오버라이드를 하면 원하는 형식으로 return 해줄 수 있음
    {
        return $"{Name}: {Score}점";
    }
}