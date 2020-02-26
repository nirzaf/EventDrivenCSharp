using EventDrivenDemo.Events;
using System;

namespace EventDrivenDemo.Services
{
    public class AuditService : IAuditService
    {
        public void Subscribe(ITransactionService transactionService)
        {
            transactionService.OnTransactionProcessed += WriteAuditLog;
        }

        private void WriteAuditLog(object sender, TransactionProcessedEventArgs e)
        {
            Console.WriteLine($"AUDIT LOG: {e.TransactionType} for ${e.Amount} processed");
        }
    }
}