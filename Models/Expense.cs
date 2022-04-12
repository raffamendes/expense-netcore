namespace ExpenseApi.Models
{
    public class Expense
    {
        public long Id { get; set; }
        public string? Desc { get; set; }
        public string? PaymentMethod { get; set; }
        public decimal Amount { get; set; }
    }
}