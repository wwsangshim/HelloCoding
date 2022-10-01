int passcodeNumber1 = 6;
int pssscodeNumber2 = 2;

Console.WriteLine("첫번째 숫자를 넣어주세요");
int userInput1 = int.Parse(Console.ReadLine());
Console.WriteLine("두번쨰 숫자를 넣어주세요");
int userInput2 = int.Parse(Console.ReadLine());

if (userInput1 == passcodeNumber1)
{
    if (userInput2 == passcodeNumber1)
    {
        Console.WriteLine("문이 열렸습니다");
    }
}
