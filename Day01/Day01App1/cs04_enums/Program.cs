using System;

namespace cs04_enums
{
    internal class Program
    {
       enum HomeTown  // 열거형으로 만들면 자동완성 기능 0
        {
            SEOUL , 
            DAEJEON,
            DAEGU,
            BUSAN,
            JEJU
        }
        string[] home = new[] { "Seoul", "Daejeon" };

        static void Main(string[] args)
        {
            HomeTown myhomeTown;
            myhomeTown = HomeTown.BUSAN;

            if (myhomeTown == HomeTown.SEOUL)
            {
                Console.WriteLine("서울 출신이시군요");
            }
            else if (myhomeTown == HomeTown.DAEJEON)
            {
                Console.WriteLine("충청도예유");
            }
            else if (myhomeTown == HomeTown.DAEGU) 
            {
                Console.WriteLine("대구여");
            }
            else if (myhomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("부산이라예");
            }
            else
            {
                Console.WriteLine("제주임당");
            }
        }
    }
}
