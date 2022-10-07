//7-1
double[] weights = new double[3];

Console.WriteLine("첫 번째 무게: ");
weights[0] =double.Parse(Console.ReadLine());


Console.WriteLine("두 번째 무게: ");
weights[1] = double.Parse(Console.ReadLine());

Console.WriteLine("세 번째 무게: ");
weights[2] = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------------------------");
//7-2
string[] studentsNames = {"홍길동","김철수","이영희"};

Console.WriteLine(studentsNames[0]);
Console.WriteLine(studentsNames[1]);
Console.WriteLine(studentsNames[2]);

Console.WriteLine("------------------------------------------------------");
//7-3
int[] scores = { 90, 85, 73, 100 };

Console.WriteLine(scores[0]);
Console.WriteLine(scores[1]);
Console.WriteLine(scores[2]);
Console.WriteLine(scores[3]);

Console.WriteLine("------------------------------------------------------");

//7-4 심화7-1,7-2  
string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
int[] score = new int[5];
double[] weight_2 = new double[5];  

Console.Write(subjects[0]);
Console.WriteLine("점수를 입력하세요: ");
score[0] = int.Parse(Console.ReadLine());

Console.Write(subjects[1]);
Console.WriteLine("점수를 입력하세요: ");
score[1] = int.Parse(Console.ReadLine());

Console.Write(subjects[2]);
Console.WriteLine("점수를 입력하세요: ");
score[2] = int.Parse(Console.ReadLine());

Console.Write(subjects[3]);
Console.WriteLine("점수를 입력하세요: ");
score[3] = int.Parse(Console.ReadLine());

Console.Write(subjects[4]);
Console.WriteLine("점수를 입력하세요: ");
score[4] = int.Parse(Console.ReadLine());




Console.WriteLine("몸무게를 입력하세요: ");
weight_2[0] = int.Parse(Console.ReadLine());

Console.WriteLine("몸무게를 입력하세요: ");
weight_2[1] = int.Parse(Console.ReadLine());

Console.WriteLine("몸무게를 입력하세요: ");
weight_2[2] = int.Parse(Console.ReadLine());

Console.WriteLine("몸무게를 입력하세요: ");
weight_2[3] = int.Parse(Console.ReadLine());

Console.WriteLine("몸무게를 입력하세요: ");
weight_2[4] = int.Parse(Console.ReadLine());

Console.Write(subjects[0]);
Console.Write(" 점수: ");
Console.WriteLine(score[0]);

Console.Write(subjects[1]);
Console.Write(" 점수: ");
Console.WriteLine(score[1]);

Console.Write(subjects[2]);
Console.Write(" 점수: ");
Console.WriteLine(score[2]);

Console.Write(subjects[3]);
Console.Write(" 점수: ");
Console.WriteLine(score[3]);

Console.Write(subjects[4]);
Console.Write(" 점수: ");
Console.WriteLine(score[4]);

int sum =  score[0] + score[1] + score[2] + score[3] + score[4] ;
double average = sum / 5;

Console.WriteLine("총점: "+sum);
Console.WriteLine("평균: "+average);

Console.WriteLine("------------------------------------------------------");

