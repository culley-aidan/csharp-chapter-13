using System;

namespace DiscountDelegateDemo2
{
    delegate void DiscountDelegate(ref double saleAmount);
    class Program
    {
        static void Main(string[] args)
        {
            double saleAmount;
            char code;
            DiscountDelegate firstDel, secondDel, thirdDel;

            firstDel = new DiscountDelegate(StandardDiscount);
            secondDel = new DiscountDelegate(PreferredDiscount);

            thirdDel = firstDel;
            thirdDel += secondDel;

            Console.Write("Enter the amount of sale ");
            saleAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter S for standard discount, or P for preferred discount\nor X for eXtreme discount ");
            code = Convert.ToChar(Console.ReadLine());

            if (code == 'S') {
                firstDel(ref saleAmount);
            } else {
                if (code == 'P') {
                    secondDel(ref saleAmount);
                } else {
                    thirdDel(ref saleAmount);
                }
            }

            Console.WriteLine("New sale amount is {0}", saleAmount.ToString("C2"));
        }

        public static void StandardDiscount(ref double saleAmount)
        {
            const double DISCOUNT_RATE = 0.05, CUTOFF = 1000.0;
            double discount;
            if (saleAmount >= CUTOFF) {
                discount = saleAmount * DISCOUNT_RATE;
            } else {
                discount = 0;
            }
            saleAmount -= discount;
        }
        public static void PreferredDiscount(ref double saleAmount)
        {
            const double SPECIAL_DISCOUNT = 0.10;
            double discount = saleAmount * SPECIAL_DISCOUNT;
            saleAmount -= discount;
        }
    }
}
