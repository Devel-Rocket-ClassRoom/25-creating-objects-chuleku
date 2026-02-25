using CodingPractice;
using System;
using System.Net.Security;

///과제 1: 간단한 클래스와 개체
/*Dog myDog = new Dog();
myDog.Name = "초코";
myDog.Age = 3;
myDog.Bark();

Console.WriteLine($"이름: {myDog.Name}, 나이: {myDog.Age}살");

public class Dog
{
    public string Name;
    public int Age;

    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
    }
}*/
///과제 2: var 키워드로 개체 생성
/*Monster monster = new Monster();
Console.WriteLine(monster);
var monset1 = new Monster();
Console.WriteLine(monset1);
public class Monster
{
    public string Name;
}*/
///과제 3: 인스턴스 메서드
/*Calculator calc = new Calculator();
calc.add(3, 5);
calc.Multiply(4, 6);

public class Calculator
{
    public void add(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"합계: {sum}");
    }
    public void Multiply(int x, int y)
    {
        int sum = x * y;
        Console.WriteLine($"곱: {sum}");
    }
}*/
///과제 4: 인스턴스 메서드와 필드
/*Counter count = new Counter();
count.Increment();
count.Increment();
count.Increment();
count.Reset();
public class Counter
{
    public int count;

    public void Increment()
    {
        count++;
        Console.WriteLine($"현재 카운트: {count}");
    }
    public void Reset()
    {
        count = 0;
        Console.WriteLine("카운트가 초기화 되었습니다.");
    }
}*/
///과제 5: 정적 멤버와 인스턴스 멤버
/*GameManager.TotalPlayers = 10;
GameManager.ShowStatus();
GameManager manager = new GameManager();
manager.PlayerName = "홍길동";
manager.Greet();

public class GameManager
{
    public static int TotalPlayers = 0;

    public static void ShowStatus()
    {
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }

    public string PlayerName;

    public void Greet()
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }
}*/
///과제 6: 여러 클래스 함께 사용
/*Greeting.sayHello();
Farewell.Wave();
Greeting greeting = new Greeting();
greeting.saygoodbye();
Farewell farewell = new Farewell();
farewell.bow();*/
///과제 7: Tostring()기본 동장
/*Item item = new Item();
item.Name = "포션";
item.Price = 100;
Console.WriteLine(item);

public class Item
{
    public string Name;
    public int Price;
}*/
///과제 8: ToString() 오버라이드
/*Item item = new Item();
item.Name = "포션";
item.Price = 100;
Console.WriteLine(item);

public class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[아이템] {Name} - {Price}골드";
    }
}*/
///과제 9: Tostring() 활용
/*Player player = new Player();
player.Name = "전사";
player.Level = 10;
player.Health = 200;

Player player1 = new Player();
player1.Name = "마법사";
player1.Level = 8;
player1.Health = 120;
Console.WriteLine(player);
Console.WriteLine(player1);
public class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"[{Level} 레벨] {Name} (HP: {Health})";
    }
}*/
///과제 10: 클래스 배열
/*Enemy[] enemies = new Enemy[3];
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
public class Enemy
{
    public string Name;
    public int Health;

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP {Health}");
    }
}*/
///과제 11: foreach로 클래스 배열 순회
/*Item[] inventory = new Item[3];
inventory[0] = new Item { Name = "검", Price = 500 };
inventory[1] = new Item { Name = "방패", Price = 300 };
inventory[2] = new Item { Name = "포션", Price = 50 };

Console.WriteLine("=== 인벤토리 ===");
foreach (Item item in inventory)
{
Console.WriteLine(item);
}
public class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"{Name}: {Price}골드";
    }
}*/
///과제 12:개체 이니셜라이저
/*characher char1 = new characher();
char1.Name = "홍길동";
char1.Level = 1;
char1.job = "전사";

characher char2 = new characher
{
    Name = "이순신",
    Level = 5,
    job = "궁수"
};
Console.WriteLine($"{char1.Name} - {char1.job} LV.{char1.Level}");
Console.WriteLine($"{char2.Name} - {char2.job} LV.{char2.Level}");
public class characher
{
    public string Name;
    public int Level;
    public string job;
}*/
///과제 13: 배열에서 개체 이니셜라이저 활용
/*Student[] students = new Student[3]
{
    new Student{Name = "김철수",Score = 85},
    new Student{Name = "이영희", Score = 92},
    new Student{Name = "박민수",Score =78}
};
foreach(Student student in students)
{
    Console.WriteLine(student);
}
public class Student
{
    public string Name;
    public int Score;

    public override string ToString()
    {
        return $"{Name}: {Score}점";
    }
}*/