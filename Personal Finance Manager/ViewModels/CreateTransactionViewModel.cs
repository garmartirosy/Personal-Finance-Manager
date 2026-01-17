using System.ComponentModel.DataAnnotations;

namespace Personal_Finance_Manager.ViewModels
{
    public class CreateTransactionViewModel
    {
        public int AccountId { get; set; }

        public decimal Amount { get; set; }

        public int TransactionTypeId { get; set; }

        public DateTime TransactionDate { get; set; }
        
        public string? DestinationName { get; set; }
        public string? Description { get; set; }

        public int? CategoryId { get; set; }
    }
}
