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
Item1 item = new Item1();
item.Price1 = 100;
item.Name1 = "potion";
Console.WriteLine(item);
Console.WriteLine();

// 8
Item1 potion = new();
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
Console.WriteLine();

// 10
Enemy[] enemies = new Enemy[3];  // class일 경우, 현재 배열 변수만 생성되고 배열 개체는 0개인 상태
// struct일 경우, 배열 생성과 동시에 기본값으로 개체또한 생성됨

enemies[0] = new Enemy();
enemies[0].Name = "고블린";
enemies[0].Health = 50;

enemies[1] = new Enemy();
enemies[1].Name = "오크";
enemies[1].Health = 100;

enemies[2] = new Enemy();
enemies[2].Name = "드래곤";
enemies[2].Health = 500;


for (int i = 0; i < enemies.Length; i++)
{
    enemies[i].ShowInfo();
}
Console.WriteLine();

// 11
Item1[] items = new Item1[3]; // new.Item[]은 클래스에 한개의 배열 개체 생성. 현재 상태는 요소3개를 가진 배열 1개 변수를 만듦/

items[0] = new Item1 { Name1 = "검", Price1 = 500 };
items[1] = new Item1 { Name1 = "방패", Price1 = 300 };
items[2] = new Item1 { Name1 = "포션", Price1 = 50 };


Console.WriteLine("=== 인벤토리 ===");
foreach (Item1 eyetem in items)
{
    Console.WriteLine(eyetem);
}
Console.WriteLine();

// 12

// 기존 방식
Character c1 = new();
c1.Name = "홍길동";
c1.Level = 1;
c1.Job = "전사";

// Object Initializer   
Character c2 = new Character
{
    Name = "이순신",
    Level = 5,
    Job = "궁수"
};

Console.WriteLine($"{c1.Name} - {c1.Job} Lv.{c1.Level}");
Console.WriteLine($"{c2.Name} - {c2.Job} Lv.{c2.Level}");
Console.WriteLine();

// 13
Student[] students = new Student[3]
{
    new Student { Name = "김철수", }
}

