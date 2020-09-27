using System;

namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Credit Information");
            DateTime dateOfLoan = new DateTime(2020, 1, 1);
            Console.WriteLine($"Date of loan is: {dateOfLoan}");
            DateTime loanEndDate = dateOfLoan.AddMonths(7);
            Console.WriteLine($"End date of loan is: {loanEndDate}");
            double loanSum = 700;
            Console.WriteLine($"Loan sum is: {loanSum}");
            double monthlyPayment = 100;
            Console.WriteLine($"Monthly payment is: {monthlyPayment}");
            Console.Write("Input payment value: ");
            double paymentValue = InputPaymentValue();
            Console.Write("Input payment date: ");
            DateTime paymentDate = InputPaymentDate();
            (double overPay, double debt) = LoanBalance(dateOfLoan, loanEndDate, loanSum, monthlyPayment, paymentValue, paymentDate);
            Console.ReadLine();

        }
        public static (double overPay, double debt) LoanBalance(DateTime dateOfLoan, DateTime loanEndDate,
                       double loanSum, double monthlyPayment, double paymentValue, DateTime paymentDate)
        {

            double overPay;
            double debt;
            double loanBalance = loanSum - paymentValue;
            //int paysCount = 0;



            if (paymentValue == monthlyPayment && paymentDate <= dateOfLoan.AddMonths(1))
            {
                overPay = 0;
                debt = 0;
                //paysCount++;
                Console.WriteLine($"Overpay is: {overPay}");
                Console.WriteLine($"Debt is: {debt}");
                Console.WriteLine("The debt is missing!");
                return (overPay, debt);
            }
            else if (paymentValue < monthlyPayment && paymentDate < dateOfLoan.AddMonths(1))
            {
                overPay = 0;
                debt = monthlyPayment - paymentValue;
                Console.WriteLine($"Overpay is: {overPay}");
                Console.WriteLine($"Debt is: {debt}");
                return (overPay, debt);
            }
            else if (paymentValue > monthlyPayment && paymentDate <= dateOfLoan.AddMonths(1))
            {
                overPay = paymentValue - monthlyPayment;
                debt = 0;
                Console.WriteLine($"Overpay is: {overPay}");
                Console.WriteLine($"Debt is: {debt}");
                Console.WriteLine("The debt is missing!");
                return (overPay, debt);
            }
            else
            {
                if (paymentDate > dateOfLoan.AddMonths(3))
                {

                }
                debt = monthlyPayment;
                overPay = 0;
                Console.WriteLine($"The debt is: {debt}!");
                return (overPay, debt);
            }

        }
        public static double InputPaymentValue()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = double.TryParse(str, out double parsedValue);
            return parsedValue;
        }
        public static DateTime InputPaymentDate()
        {
            string str = Console.ReadLine();
            bool canParse = false;
            canParse = DateTime.TryParse(str, out DateTime parsedValue);
            return parsedValue;
        }

    }
}

