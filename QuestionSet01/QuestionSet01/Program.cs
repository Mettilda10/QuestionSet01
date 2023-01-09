using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSet01
{
    class Program
    {
        static void Main(string[] args)
        {
            sum(10,20);        
        }
        public static void sum(int a, int b)
        {
            int temp = a + b;
            Console.WriteLine(temp);
        }
    }
}
