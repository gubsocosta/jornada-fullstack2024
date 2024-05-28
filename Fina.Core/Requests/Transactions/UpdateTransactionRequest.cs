namespace Fina.Core.Requests.Transactions;

public class UpdateTransactionRequest : Requests
{
    public long Id { get; set; }
    
    [Required(ErrorMessage = "{0} is invalid")]
    public string Title { get; set; }

    [Required(ErrorMessage = "{0} is invalid")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "{0} is invalid")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "{0} is invalid")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "{0} is invalid")]
    public DateTime PaidOrReceived { get; set; }
}
