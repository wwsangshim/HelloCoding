//6-1
Console.WriteLine(3 <= 5); // 참
Console.WriteLine(!(5==5)); // 거짓
Console.WriteLine(!(3 < 2)); // 참
Console.WriteLine(1 > 0);   //참
Console.WriteLine("---------------------------------------------------------------");

//6-2
Console.WriteLine("먹은 사과의 개수를 입력하세요");
int eatenAppleCount = int.Parse(Console.ReadLine());
if (eatenAppleCount > 3)
{
    Console.WriteLine("사과를 많이 먹었습니다");
}
else if (eatenAppleCount < 3)
{
    Console.WriteLine("사과를 조금먹었습니다");
}
else
{
    Console.WriteLine("사과를 적절히 먹었습니다");
}
// 에러?
Console.WriteLine("---------------------------------------------------------------");

//6-3
Console.WriteLine("등수를 입력하세요.");
int rank = int.Parse(Console.ReadLine());
Console.WriteLine("점수를 입력하세요.");
int score = int.Parse(Console.ReadLine());

if (rank <10  || score > 90)
{
    Console.WriteLine("A입니다");
}
Console.WriteLine("---------------------------------------------------------------");

//심화 6-1
Console.WriteLine("첫번쨰 숫자를 입력하세요:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("두번째 숫자를 입려하세요:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("연산자를 입력하세요:");
string inputOperator = Console.ReadLine();

Console.Write(number1);
Console.Write(inputOperator);
Console.Write(number2);
Console.WriteLine("=");

if (inputOperator == "+")
{
    Console.WriteLine(number1 + number2);
}
else if (inputOperator == "-")
{
    Console.WriteLine(number1 - number2);
}
else if (inputOperator == "*")
{
    Console.WriteLine(number1 * number2);
}
else if (inputOperator == "/")
{
    Console.WriteLine(number1 / number2);
}
else if (inputOperator == "%")
{
    Console.WriteLine(number1 % number2);
}
Console.WriteLine("---------------------------------------------------------------");

//6-2
Console.WriteLine("숫자를 입력하세요:");
int userInput = int.Parse(Console.ReadLine());
if (userInput % 3 == 0 && userInput > 20)
{
    Console.WriteLine("20보다 큰 3의 배수 입니다.");
}