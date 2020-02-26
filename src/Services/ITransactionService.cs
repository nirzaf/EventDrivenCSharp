using EventDrivenDemo.Events;
using System;

namespace EventDrivenDemo.Services
{
    public interface ITransactionService
    {
        event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;

        void MakeDeposit(decimal amount);

        void MakeWithdrawal(decimal amount);
    }
}