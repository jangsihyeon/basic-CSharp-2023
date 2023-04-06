using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{
    class Cat  // private 이라도 같은 cs13_class 안에 있기 때문에 접근 가능 
    {
        #region <생성자>
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Cat() 
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }

        /// <summary>
        /// 사용자 지정 생성자 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public Cat(string name, string color, sbyte age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        #endregion

        #region  <멤버 변수 - 속성>
        public string Name;   // 고양이 이름
        public string Color;   // 고양이 색
        public sbyte Age;     // 고양이 나이
        #endregion

        #region  <멤버 메서드 - 기능>

        public void Meow()
        {
            Console.WriteLine("{0} - 애옹 ", Name);
        }

        public void Run()
        {
            Console.WriteLine("{0} 달린다", Name);
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat helloKitty = new Cat();  // helloKitty라는 이름의 객체를 생성할게 
            helloKitty.Name = "헬로키티";
            helloKitty.Color = "흰색";
            helloKitty.Age = 50;
            helloKitty.Meow();
            helloKitty.Run();

            // 객체를 생성하면서 초기화 
            Cat nero = new Cat() {
                Name = "검은 고양이 네로",
                Color= "검은색",
                Age = 27,
            };
            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", helloKitty.Name, helloKitty.Color, helloKitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", nero.Name, nero.Color, nero.Age);

            Cat yangi = new Cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", yangi.Name, yangi.Color, yangi.Age);

            Cat norangi = new Cat("노랑이", "노란색", 1);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", norangi.Name, norangi.Color, norangi.Age);
        }
    }
}
