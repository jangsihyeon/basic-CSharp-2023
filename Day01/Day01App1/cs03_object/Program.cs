using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object 형식
            // int == System.Int 32
            // long == System.Int64
            //int idata = 1024;
            long idata = 1024;
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());

            object iobj = (object)idata;  // 박싱 : 데이터 타입의 값을 object로 담아라 
            Console.WriteLine(iobj);
            Console.WriteLine(iobj.GetType());

            long udata = (long)iobj;  // 언박싱 : object를 원래 데이터 타입으로 바꿔라 
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double ddata = 3.141592;
            object pobj = (object)ddata;
            double pdata = (double)pobj;
            Console.WriteLine(pobj);
            Console.WriteLine(pobj.GetType());
            Console.WriteLine(pdata);
            Console.WriteLine(pdata.GetType());

            short sdata = 32000;
            int inData = sdata;
            Console.WriteLine(inData);

            long lndata = long.MaxValue;
            Console.WriteLine(lndata);
            inData = (int) lndata;      // overflow
            Console.WriteLine(inData);

            float fval = 3.141592f;
            Console.WriteLine("fval : "+fval);
            double dval = (double)fval;
            Console.WriteLine("dval : " + dval);
            Console.WriteLine(fval == dval);
            Console.WriteLine(dval == 3.141592);

            // 정말 중요 !! 실무에서 제일 많이 쓰임
            int numval = 1024;
            string strival = numval.ToString();
            Console.WriteLine(strival);
            Console.WriteLine(numval);
            //Console.WriteLine(numval==strival);  타입을 str로 바꿔서 숫자와 문자열이 비교를 못함
            Console.WriteLine(strival.GetType());

           double numdval = 3.1415926535897;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            // 문자열을 숫자로 변경  
            // 문자열 내에 숫자가 아닌 특수문자나 정수인데 . (소수점)이 있거나 
            string originstr = "34567890";                    // "3million"은 예외 발생
            int convval = Convert.ToInt32(originstr);   // int.Parse() 도 동일 
            Console.WriteLine(originstr);
            originstr = "1.23456";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);

            // 예외 발생하지 않도로고 형변환 하는 방법 
            originstr = "123.0";
            float ffval;
            // TryParse는 예외가 발생하면 값은 0 대체 , 예외가 없으면 값은 원래값으로 
            float.TryParse(originstr, out ffval);        // 예외가 발생하지않게 숫자 변환 
            Console.WriteLine(ffval);

            const double pi = 3.1415926535897;
            Console.WriteLine(pi);

            //pi = 4.58;   // 상수는 못바꿈

        }
    }
}
