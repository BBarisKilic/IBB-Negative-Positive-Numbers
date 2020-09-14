using System;

namespace IBB_Negative_Positive_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int positive = 0;
            int negative = 0;
            int zero = 0;
            int loopCondition = 1;

            while (loopCondition != 0)
            {
                Console.WriteLine("10 adet veri giriniz.");
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                foreach (var item in numbers)
                {
                    if (item > 0)
                        positive++;
                    else if (item < 0)
                        negative++;
                    else
                        zero++;
                }
                Console.WriteLine("Girdiğiniz verilerin {0} tanesi pozitif, {1} tanesi negatif, {2} tanesi sıfırdır.", positive, negative, zero);

            LoopCondition:
                Console.Write("Devam etmek için 1'e, çıkmak için 0'a basın lütfen: ");
                loopCondition = int.Parse(Console.ReadLine());
                if (loopCondition != 0 && loopCondition != 1)
                {
                    goto LoopCondition;
                }
            }
        }
    }
}
