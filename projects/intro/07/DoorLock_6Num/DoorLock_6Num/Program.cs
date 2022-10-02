
int[] passcodeNumber = { 6, 2, 1, 9, 4, 7 };

int[] userInput = new int[6];
//               6개의 정수를 넣을수있는 배열을 만들것이다
Console.WriteLine("첫번째 숫자를 입력하세요");
userInput[0] = int.Parse(Console.ReadLine());
Console.WriteLine("두번째 숫자를 입력하세요");
userInput[1] = int.Parse(Console.ReadLine());
Console.WriteLine("세번째 숫자를 입력하세요");
userInput[2] = int.Parse(Console.ReadLine());
Console.WriteLine("네번째 숫자를 입력하세요");
userInput[3] = int.Parse(Console.ReadLine());
Console.WriteLine("다번째 숫자를 입력하세요");
userInput[4] = int.Parse(Console.ReadLine());
Console.WriteLine("여섯번째 숫자를 입력하세요");
userInput[5] = int.Parse(Console.ReadLine());


if (passcodeNumber[0] == userInput[0] && passcodeNumber[1] == userInput[1]
    && passcodeNumber[2] == userInput[2] && passcodeNumber[3] == userInput[3]
    && passcodeNumber[4] == userInput[4] && passcodeNumber[5] == userInput[5])
{
    Console.WriteLine("문이 열렸습니다");
}
else
{
    Console.WriteLine("비밀번호가 틀렸습니다");
}