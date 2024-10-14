namespace AccountTransactionAPP.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; } // Example., "Debit", "Credit"

        public int? NaturalPersonId { get; set; }
        public NaturalPerson NaturalPerson { get; set; }

        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }


}
