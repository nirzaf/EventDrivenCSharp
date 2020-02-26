namespace EventDrivenDemo.Services
{
    public interface IAuditService
    {
        void Subscribe(ITransactionService transactionService);
    }
}