
namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

    public class Payload
    {
        // TODO
        public string User { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public string Item { get; set; }
        public int Amount { get; set; }

        public Payload(string user, TransactionTypes trans, int amt, string item)
        {
            User = user;
            TransactionType = trans;
            Item = item;
            Amount = amt;
        }
    }
}
