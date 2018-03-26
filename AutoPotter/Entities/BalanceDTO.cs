namespace AutoPotter
{
    public class BalanceDTO
    {
        public long Balance { get; set; }
        public string Currency { get; set; }
        public long SpendToday { get; set; }

        public BalanceDTO(long balance, string currency, long spendToday)
        {
            Balance = balance;
            Currency = currency;
            SpendToday = spendToday;
        }
    }
}