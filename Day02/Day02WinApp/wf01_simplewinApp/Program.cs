using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf01_simplewinApp
{
    class Program : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First WinApp");
            System.Windows.Forms.Application.Run(new Program());
        }
    }
}
