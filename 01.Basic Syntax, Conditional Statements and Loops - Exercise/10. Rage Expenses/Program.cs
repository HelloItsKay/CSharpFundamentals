using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsets = 0;
            int mice = 0;
            int keyboards = 0;
            int display = 0;

            for (int i = 1; i <=lostGameCount; i++)
            {
                if (i%2==0)
                {
                    headsets++;
                }

                if (i%3==0)
                {
                    mice++;
                }

                if (i%6==0)
                {
                    keyboards++;
                }

                if (i %12==0)
                {
                    display++;
                }

            }
            double totalPrice=headsetPrice*headsets+mice*mousePrice+keyboards*keyboardPrice+display*displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");

        }
    }
}
