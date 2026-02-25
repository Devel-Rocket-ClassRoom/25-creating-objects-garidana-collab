using System;
using System.Collections.Generic;
using System.Text;

class Dog
{
    string Name;
    int Age;

    public Dog (string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }


}
