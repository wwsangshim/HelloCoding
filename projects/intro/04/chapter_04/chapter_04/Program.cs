Console.Write("100+10=");
Console.WriteLine(100 + 10);
Console.Write("100-10=");
Console.WriteLine(100-10);
Console.Write("100*10=");
Console.WriteLine(100*10);
Console.Write("84/10=");
Console.WriteLine(84/10);
Console.Write("84%10=");  
Console.WriteLine(84%10);

Console.WriteLine("글" + "붙여쓰기");

string appleCountDescription = "바구니 안에 담긴 사과의 개수: ";
Console.Write(appleCountDescription);
int appleCount = 12;
Console.WriteLine(appleCount);

appleCount = appleCount - 2;
appleCountDescription = "내가 먹고 난 뒤에" + appleCountDescription;

Console.Write(appleCountDescription);
Console.WriteLine(appleCount);

// 10=appleCount 오류 변수는 왼쪽에만 올수있음
// int pearCount;
// Console.WriteLine(pearCount); 변수에 값을 넣지 않으면 오류