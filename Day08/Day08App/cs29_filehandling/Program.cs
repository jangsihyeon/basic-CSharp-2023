using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory == Folder
            // "C:\DEV" ,  @"C:\DEV"    리터럴 여러줄 문자열도 가능 
            string curDirectory = @"C:\Temp";  //   C:\DEV 는 절대경로   /  . 은  현재 디렉토리 (상대경로)  .. 은 부모 디렉토리 
            Console.WriteLine("현재 디렉토리 정보 ");

            var dirs = Directory.GetDirectories(curDirectory);  // 현재 디렉토리에 모든 디렉토리를 불러온다 .
            foreach (var dir in dirs) 
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.Write(dirInfo.Name);
                Console.WriteLine(" [{0}]", dirInfo.Attributes);
            }
            Console.WriteLine("현재 디렉토리 파일 정보");

            var files = Directory.GetFiles(curDirectory);
            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.Write(fileInfo.Name);
                Console.WriteLine("[{0}]", fileInfo.Attributes);
            }

            // 특정 경로에 하위 폴더 / 하위 파일 조회 

            string path = @"C:\Temp\Csharp_Bank";   // 만들고자 하는 폴더     구분자로 / 도 가능 
            string sfile = "Test.log";                            // 생성할 파일 
            
            if (Directory.Exists(path))
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다. /");
                File.Create(path+@"\"+sfile);    // C:\Temp\Csharp_Bank\Test.log
            }
            else
            {
                Console.WriteLine($"해당 경로가 없습니다.  {path}, 만듭니다.");
                Directory.CreateDirectory(path);

                Console.WriteLine("경로를 생성하여 파일을 생성합니다");
                File.Create(path + @"\" + sfile);
            }
        }
    }
}
