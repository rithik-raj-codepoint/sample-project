namespace BankAPI.model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public string TransactionType { get; set; }
        public string Amount { get; set; }
        public string BalanceAfterTransaction { get; set; }
    }
}
