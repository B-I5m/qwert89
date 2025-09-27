public class Transaction
{
    public string Id { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string? FromAccountId { get; set; }   
    public string? ToAccountId { get; set; }     
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; }
    public string? Reason { get; set; }    
}