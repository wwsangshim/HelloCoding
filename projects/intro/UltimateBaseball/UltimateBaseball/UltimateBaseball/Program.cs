﻿using System.Reflection.Metadata.Ecma335;

namespace UltimateBaseball
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|       궁극의 숫자 야구 게임                       |");
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|컴퓨터가 수비수가 되어 세자릿수를 하나 골랐습니다  |");
            Console.WriteLine("|각 숫자는 0~9중에 하나며 중복되는 숫자는 없습니다  |");
            Console.WriteLine("|모든 숫자와 위치를 맞히면 승리합니다               |");
            Console.WriteLine("|숫자와 순서가 둘다 맞으면 스트라이크입니다         |");
            Console.WriteLine("|숫자만 맞고 순서가 틀리면 볼입니다                 |");
            Console.WriteLine("|숫자가 틀리면 아웃입니다                           |");
            Console.WriteLine("+---------------------------------------------------+");

            Console.WriteLine(">수비수가 고른 숫자");
            int[] numbers = { 3, 1, 9 };
            for (int i= 0; i<3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
           


            int[] guesses = new int[3];
            string[] inputMessage = { "> 첫 번쨰숫자를 입력하세요.", "> 두 번쨰숫자를 입력하세요.", "> 세 번쨰숫자를 입력하세요." };
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(inputMessage[i]);
                    guesses[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(">공격수가 고른 숫자");
                for (int i = 0; i < 3; i++)
                { 
                     Console.WriteLine(guesses[i]);

                }

            if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
            {
                Console.WriteLine("같은 숫자를 입력하면 안됩니다");
                continue;
            }
            
            
            int strikeCount = 0;
            int ballCount = 0;

            for (int i =0; i<3; i++)
                {
                    for (int j=0; j<3; j++)
                    {
                        if (guesses[i] == numbers[j])
                            {
                            if (i == j)
                            {
                                strikeCount++;

                            }
                            else
                            {
                                ballCount++;
                            }
                        }
                    }
                }

                Console.Write("스트라이트: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);

            if (guesses[0] == numbers[0] && guesses[1] == numbers[1] && guesses[2] == numbers[2])
            {
                Console.WriteLine("정답입니다");
                break;
            }
            }
        } 
    }
}