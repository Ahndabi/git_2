using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_2
{
	internal class Up_Down
	{
		static void Game()
        {
            Console.Clear();

            // 컴퓨터가 0~999 중에 랜덤한 숫자를 뽑는다.
            Random r = new Random();
            int comnum = r.Next(0, 999);            // 컴퓨터가 고른 숫자

            for (int i = 0; i< 10; ++i)
            {
                int num = 1000;

                while(num > 999)
                {
                    try
                    {
                        string str = Console.ReadLine();
                        num = int.Parse(str);               // 숫자 하나 int로 입력
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("숫자만 입력하세요.");
                    }

                    if (num < 999)
                        break;

                    Console.WriteLine("999 이하의 숫자만 입력하세요.");
                }
                   
                   
                 if (num == comnum)
                 {
                    Console.WriteLine("맞췄습니다! 축하합니다!");
                     break;
                 }
                 string result = num > comnum ? "Down" : "Up";
                 Console.WriteLine(result);
            }
                  
             Console.WriteLine("R을 누르면 재시작 합니다.");
        }
             
        static void Main()
        {
			Game();

			ConsoleKeyInfo info = Console.ReadKey();
			if (info.Key == ConsoleKey.R)
			{
				Game();
			}

		}
	}
}
