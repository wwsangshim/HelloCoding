//8-1
Console.WriteLine("과목 개수를 입려하세요");


int[] scores = new int[5];

int  subject= 0;
while (subject<5)
{
    Console.WriteLine(subject + "번째 과목의 성적을 입력하세요");
    scores[subject] = int.Parse(Console.ReadLine());

    subject = subject + 1;

}
Console.Write("총점은 ");
Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
Console.WriteLine("입니다");

Console.WriteLine("--------------------------------------------------");

//8-2
Console.WriteLine("수업을 몇 과목 들었습니까?");
int subjectCount = int.Parse(Console.ReadLine());

int[] score = new int[subjectCount];
int index = 0;
int total = 0;

while (index < subjectCount) 
{
    Console.Write(index);
    Console.WriteLine("번째 과목의 성적을 입력하세요.");
    score[index] = int.Parse(Console.ReadLine());
    total = total + score[index];
    index = index + 1;
}
Console.Write("평균은");
Console.Write(total/subjectCount);
Console.WriteLine("입니다");

Console.WriteLine("--------------------------------------------------");

//8-3
Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
int friendCount = int.Parse(Console.ReadLine());

int[] appleNumbers = new int[friendCount];
int indexs= 0;
int totals = 0;

while (indexs < friendCount)
{
    Console.Write(indexs);
    Console.WriteLine("번째 친구는 몇개의 사과를 가져갈까요?");
    appleNumbers[indexs] = int.Parse(Console.ReadLine());
    totals = totals + appleNumbers[indexs];
    indexs = indexs + 1;
}
{ 
    Console.Write("친구들에게 ");
    Console.Write(totals);
    Console.WriteLine("개의 사과를 나눠줬습니다.");
}

Console.WriteLine("--------------------------------------------------");

//8-4
string userInput = "";

while(true)
{
    Console.WriteLine("아무 글자나 입려하세요. 끝내려면 '끝'을 입력하세요.");
    userInput = Console.ReadLine();
    Console.WriteLine(userInput);

    if (userInput == "끝")
    {
        break;
    }
}
Console.WriteLine("--------------------------------------------------");

//심화 8-1
int[] passcodeNumber = { 6, 2, 1, 9, 4, 7 };
int[] userInput_2 = new int[6];

while (true)
{
    Console.WriteLine("숫자를 입력하세요:");
    userInput_2 = 
}