using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение");
            string message = Console.ReadLine();
            Console.WriteLine("Введите кол-во повторений");
            int timesOfRepeat = int.Parse(Console.ReadLine());
            for(int i = 0; i < timesOfRepeat;i++) 
            {
                Console.WriteLine(message);
            }
        }
    }
}
