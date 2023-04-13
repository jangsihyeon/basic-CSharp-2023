﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs30_fileReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;   // 텍스트를 읽어와서 출력 
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(@".\python.py");   // 스트림 리더 파일 연결
                line = reader.ReadLine();   // 한줄씩 읽음
                while (line != null) 
                {
                    Console.WriteLine(line);         // 한줄 읽은것을 출력
                    
                    line = reader.ReadLine();       //다음줄 읽기
                }
                reader.Close();     // 중요한것 !!! (파일을 읽으면 무조건 마지막에 Close로 닫아줘야함 !!)
            }
            catch (Exception e) 
            {
                Console.WriteLine($"예외! {e.Message}");
            }
            finally
            {
                reader.Close();
            }

            // 읽기 끝 
            StreamWriter writer = new StreamWriter(@".\pythonByCsharp.py");

            try
            {
                writer.WriteLine("import sys;");
                writer.WriteLine("");
                writer.WriteLine("print(sys.executable);");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"예외 {e.Message}");
            }
            finally 
            {
                writer.Close(); 
            }
            Console.WriteLine("파일 생성 완료 ");
        }
    }
}
