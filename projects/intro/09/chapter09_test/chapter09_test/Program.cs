//9-1
using System;
using System.Runtime.ExceptionServices;

Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
int friendCount = int.Parse(Console.ReadLine());
int[] appleNumbers = new int[friendCount];
int index = 0;

for (int i =0; i <friendCount; i++)
{
    Console.Write(index);
    Console.WriteLine("번째 친구는 몇개의 사과를 가져갈까요?");
    appleNumbers[index] = int.Parse(Console.ReadLine());
   
 
}

index = 0;

for (int i=0; i<friendCount; i++)
{
    Console.Write(index);
    Console.Write("번째 친구가 가져간 사과의 개수는");
    Console.Write(appleNumbers[i]);
    Console.WriteLine("개입니다.");
}
Console.WriteLine("--------------------------------------------------");

//9-2
int[] scores = new int[5];

for (int i=0; i<5; i++)
{
    Console.Write(i);
    Console.WriteLine("번째 과목의 성적을 입력하세요");
    scores[i] = int.Parse(Console.ReadLine());
}
Console.Write("총점은");
Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
Console.WriteLine("입니다");
Console.WriteLine("--------------------------------------------------");

//9-3
for (int i = 2; i <= 8; i=i+2)
{
    Console.Write(i);
    Console.WriteLine("단");

    for (int j = 1; j <= 9; j++)
    {
        Console.Write(i);
        Console.Write("X");
        Console.Write(j);
        Console.Write("=");
        Console.Write(i * j);
        Console.Write(" ");
    }
    Console.WriteLine();
}
Console.WriteLine("--------------------------------------------------");

//심화9-1
Console.WriteLine("--------------------------------------------------");

//심화9-2
