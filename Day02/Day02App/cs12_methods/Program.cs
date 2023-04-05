using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods
{
    class Cal
    {
        public static int Plus (int a, int b)
        {
            return a + b;
        }
        public  int Minus(int a, int b) 
        {
            return a - b;
        }
        // static은 최초 실행 때 메모리에 바로 올라가기 때문에 
        // 클래스의 객체를 만들필요가 없음 like new Cal();
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초 올라가야 하기 때문에 static이 되어야하고 
        /// 메서드 이름이 Main이면 실행될때 알아서 제일 처음에 시작된다. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region <static 메서드 >
            int result = Cal.Plus (1, 2);
            // Cal.Plus (3,3 ); minus는 static이 아니기 때문에 접근불가(객체 생성해야 접근가능)
            result = new Cal().Minus(3, 2);
            Console.WriteLine (result);
            #endregion

            #region <call by reference vs call by value 비교>
            int x = 5; int y = 4;
            Swap(ref x , ref y);   // x,y가 가지고 있는 주소를 전달하라 =>call by reference ==  pointer

            Console.WriteLine ("x= {0}, y = {1}", x, y);

            Console.WriteLine(GetNumder());

            #endregion

            #region <out 매개변수>
            int divid = 10;
            int divor = 3;

            int rem = 0;
            Divide (divid, divor, out result, out  rem);
            Console.WriteLine("나누기 값 {0},  나머지 {1} " , result, rem);     // ref쓰든 out쓰든 결과 차이 없음 

            (result, rem) = Divide(20, 6);
            Console.WriteLine("나누기 값 {0},  나머지 {1} ", result, rem);

            #endregion

            #region  <가변길이 매개변수>

            int resSum = Sum(1, 3, 5, 7, 9);
            Console.WriteLine(resSum);
            Console.WriteLine(Sum(1, 3, 5, 7, 9));
            #endregion
        }

        //static int Divide(int x, int y)
        //{
        //    return x / y;
        //}
        //static int Reminder(int x, int y) 
        //{
        //    return x % y;
        //}

        // 메서드 두개 만들걸 아래처럼 하나로
        //static void Divide(int x, int y, ref int val, ref int rem)
        static void Divide(int x, int y, out int val, out int rem)
        {
            val = x / y;
            rem = x%y;
        }

        // 튜플로 결과값을 받음 
        static (int result, int rem) Divide(int x, int y)
        {
            return (x / y, x % y);
        }

        // Main 메서드와 같은 레벨에 있는 메서드들은 전부 static이 되어야함 (무조건!)
        public static void Swap(ref int a, ref int b) 
        {
            int temp = 0;
            temp = a;    // 5: temp = 5
            a = b;         // a= 4
            b = temp;  // 5
        }

        static int val = 100;

        public static ref int GetNumder() 
        {
            return ref val; // static 메서드에 접근할 수 있는 변수는 static 뿐
        }

        public static int Sum(params int[] args)   // python 가변길이 매개변수랑 비교 
        {
            int sum = 0;

            foreach (int item in args) 
            {
                sum += item;
            }
            return sum;
        }
    }
}
