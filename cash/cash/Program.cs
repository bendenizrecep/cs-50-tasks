using System;

namespace cash
{
    class Program
    {
        static void Main(string[] args)
        {

            float xx;
            do
            {
                Console.WriteLine("Change:");
                xx = Convert.ToSingle(Console.ReadLine());
            }
            while (xx < 0);
            int cevir = (int)Math.Round(xx * 100);
            int para = 0;

            while (cevir >= 25)
            {
                cevir -= 25;
                para++;
            }
            while (cevir >= 10)
            {
                cevir -= 10;
                para++;
            }
            while (cevir >= 5)
            {
                cevir -= 5;
                para++;
            }
            while (cevir >= 1)
            {
                cevir -= 1;
                para++;
            }
        Console.Write(para);
        }
    }
}
