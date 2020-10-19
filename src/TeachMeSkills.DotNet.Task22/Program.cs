using System;

namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Account SomeAccount = new Account();
            SomeAccount.Notify += BalanceInvoker;
            Console.Write("Input loan sum: ");
            SomeAccount.LoanSum = UserInput();
            do
            {
                Console.Write("Input the payment: ");
                SomeAccount.PayLoan(UserInput());
            }
            while (SomeAccount.InputContinue());
            Console.ReadLine();
        }
        public static double UserInput()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = double.TryParse(str, out double parsedValue);
            return parsedValue;
        }
        public static void BalanceInvoker(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}


