using System.Transactions;

int[] passcodeNumber = { 6, 2, 1, 9, 4, 7 };


int passcodeLength = 6;
int[] userInput = new int[passcodeLength];

//               6개의 정수를 넣을수있는 배열을 만들것이다
while (true)
{
    
       for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
        {
            Console.Write(passcodeIndex);
            Console.WriteLine("번째 숫자를 넣어주세요");
            userInput[passcodeIndex] = int.Parse(Console.ReadLine());
        }

        bool isPassWordCorrect = true;
        for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
        {
            if (userInput[passcodeIndex] != passcodeNumber[passcodeIndex])
            {
                isPassWordCorrect = false;
                Console.WriteLine("비밀번호가 틀렸습니다");
                break;
            }
        }

        if (isPassWordCorrect)
            {
                Console.WriteLine("문이 열렸습니다");
                break; 
            }
}