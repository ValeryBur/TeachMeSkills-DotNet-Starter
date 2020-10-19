using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TeachMeSkills.DotNet.Task22
{
    class Account
    {
        public event Action<string> Notify;
        private double _loanSum;
        private double _overPay;
        public double LoanSum { get { return _loanSum; } set { _loanSum = value; } }


        public void PayLoan(double payment)
        {
            if (payment < _loanSum)
            {
                _loanSum -= payment;
                Notify?.Invoke($"Loan sum is: {_loanSum}\nOverpay is: 0");
            }
            else if (payment == _loanSum)
            {
                _loanSum -= payment;
                Notify?.Invoke($"Loan sum is: {_loanSum}\nOverpay is: 0");
            }

            else if (payment > _loanSum)
            {
                _overPay = payment - _loanSum;
                Notify?.Invoke($"Loan sum is missing\nOverpay is: {_overPay}");
            }
            else
            {
                Notify?.Invoke($"Loan sum is: {_loanSum}\nOverpay is: 0");
            }
        }

        public bool InputContinue()
        {
            Console.Write("Do you want to add another payment? Press Y/y");
            var key = Console.ReadKey().Key;
            Console.WriteLine();
            return key == ConsoleKey.Y;
        }

    }
}


