using EventDrivenDemo.Events;
using System;

namespace EventDrivenDemo.Services
{
    public class TransactionService : ITransactionService
    {
        public event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;

        public void MakeDeposit(decimal amount)
        {
            ProcessDeposit(amount);
            if (OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, TransactionType.Deposit));
            }
        }

        public void MakeWithdrawal(decimal amount)
        {
            ProcessWithdrawal(amount);
            ProcessDeposit(amount);
            if (OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, TransactionType.Withdrawal));
            }
        }

        private void ProcessDeposit(decimal amount)
        {
            // Processing logic here
        }

        private void ProcessWithdrawal(decimal amount)
        {
            // Processing logic here
        }
    }
}