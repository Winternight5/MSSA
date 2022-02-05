using System;

namespace Assignment4._4
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }

    delegate void LowBalanceDelegation();

    struct FinanceTransaction
    {
        public double amount { get; set; }
        public TransactionType transactionType { get; set; }

    }
    internal class AccountBalancer
    {        
        private double amount { get; set; }
        public event LowBalanceDelegation LowBalance;
        public bool withdrawable { get; set; }
        public Double Balance
        {
            get { return this.amount; }

            set {
                if (value < 200) {
                    LowBalance();
                    this.amount = value;

                } else {
                    this.amount = value;
                }
            }
        }
    }
}