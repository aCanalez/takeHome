using System;
namespace takeHome
{
    public class Program
    {
        public int ReverseInteger(int Num)
        {

            int reverseNum = 0;
            bool isNegative = false;

            if (Num == 0)
            {
                return 0;
            }
            else if (Num < 0)
            {
                Num *= -1;
                isNegative = true;
            }

            while (Num > 0)
            {
                int lastDigit = Num % 10;
                reverseNum = (reverseNum * 10) + lastDigit;
                Num /= 10;
            }

            return isNegative ? reverseNum * -1 : reverseNum;
        }

        public bool IsReverseInteger(int A, int B)
        {
            int reverseNum = ReverseInteger(B);
            if (reverseNum == A)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Program p = new Program();
            Console.WriteLine("Reverse Positive Number: ");
            Console.Write(p.ReverseInteger(1123));
            Console.WriteLine("\n\rReverse Negative Number: ");
            Console.Write(p.ReverseInteger(-1123));
            Console.WriteLine(p.IsReverseInteger(123, 123) ? "\n\rChecking For Reverse: True" : "\n\rChecking For Reverse: Fail");
            Console.WriteLine(p.IsReverseInteger(123, 321) ? "\n\rChecking For Reverse: True" : "\n\rChecking For Reverse: Fail");
        }
    }
}
