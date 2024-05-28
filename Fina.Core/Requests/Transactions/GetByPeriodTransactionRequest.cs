namespace Fina.Core.Requests.Transactions;

public class GetByPeriodTransactionRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
