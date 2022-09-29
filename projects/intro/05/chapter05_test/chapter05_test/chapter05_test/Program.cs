//5-1
Console.WriteLine("첫번째 숫자를 입력하세요");
string userInput1 = Console.ReadLine();
int number1 = int.Parse(userInput1);

Console.WriteLine("두번째 숫자를 입력하세요");
string userInput2 = Console.ReadLine();
int number2 = int.Parse(userInput2);
Console.Write(number1);
Console.Write(" + ");
Console.Write(number2);
Console.Write("=");
Console.WriteLine(number1+number2);
Console.WriteLine("-------------------------------------------------------------");
//5-2
Console.WriteLine("첫번째 숫자를 입력하세요");
string userInput3 = Console.ReadLine();
Console.WriteLine("두번째 숫자를 입력하세요");
string userInput4 = Console.ReadLine();

int number3 = int.Parse(userInput3);
int number4 = int.Parse(userInput4);

Console.WriteLine(number3 - number4);
Console.WriteLine("-------------------------------------------------------------");

//5-3
Console.WriteLine("첫번째 숫자를 입력하세요");
double number = double.Parse(Console.ReadLine());
Console.Write("입력한 숫자는  ");
Console.WriteLine(number);
Console.WriteLine("-------------------------------------------------------------");

//심화5-1
string userInput5 = Console.ReadLine();
int number5 = int.Parse(userInput5);
string userInput6 = Console.ReadLine();
int number6 = int.Parse(userInput6);

Console.WriteLine(number5 + number6);
Console.WriteLine(number5 - number6);
Console.WriteLine(number5 * number6);
Console.WriteLine(number5 / number6);
Console.WriteLine("-------------------------------------------------------------");

//심화5-3
int bag = 10;
Console.WriteLine("주머니에는" + bag + "개 들어있습니다");
Console.WriteLine("어머니는 몇개의 동전을 넣었나요");
int mother=int.Parse(Console.ReadLine());

Console.WriteLine("아람이는 몇개의 동전을 꺼냈나요");
int aram = int.Parse(Console.ReadLine());

Console.WriteLine("우람이는 몇개의 동전을 꺼냈나요?");
int uram = int.Parse(Console.ReadLine());
bag = bag + mother - aram - uram;

Console.WriteLine("주머니에 남아있는 동전의 개수는" + bag + "입니다");


