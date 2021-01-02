using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mario
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int height;
                do
                {
                    Console.WriteLine("Height:");
                    height = Convert.ToInt32(Console.ReadLine());
                }
                while (height < 1 || height > 8);
                for (int i = 1; i <= height; i++)
                {
                    for (int j = height; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                }
            
        }
    }
}
