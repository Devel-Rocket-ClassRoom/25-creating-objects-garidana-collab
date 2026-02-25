using System;
using System.Globalization;
using System.Security.Cryptography;

// README.md를 읽고 아래에 코드를 작성하세요.

// 1 
Dog choco = new Dog("초코", 3);
choco.Bark();
Console.WriteLine();

//2 
Monster monster = new();
var monster2 = new Monster();
Console.WriteLine(monster);
Console.WriteLine(monster2);
Console.WriteLine();

// 3
Calculator calc = new();
Console.WriteLine("합계: " + calc.Add(3, 5));
Console.WriteLine("곱: " + calc.Multiply(4, 6));
Console.WriteLine();

// 4
Counter counter = new();
counter.Increment();
counter.Increment();
counter.Increment();
counter.Reset();
Console.WriteLine();

// 5
GameManager gm = new();
GameManager.ShowStatus(10);
gm.Greet("홀깅돌");
Console.WriteLine();

// 6
Farewell FW = new();
Greeting GR = new();
Greeting.SayHello();  // 스태틱이면 클래스 이름 호출
Farewell.Wave();  
GR.SayGoodbye();   // 인스턴스면 개체 호출
FW.Vow();
Console.WriteLine();

// 7
Item item = new Item();
item.Price = 100;
item.Name = "potion";
Console.WriteLine(item);
Console.WriteLine();

// 8
Item potion = new();
Console.WriteLine(item);
Console.WriteLine();

// 9
Player p1 = new();
p1.Name = "전사";
p1.Health = 200;
p1.Level = 10;

Player p2 = new();
p2.Name = "마법사";
p2.Health = 120;
p2.Level = 8;

Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());