using System.ComponentModel.DataAnnotations;

public class LoanRequest
{
    [Required]
    public string OperationNumber { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public int Term { get; set; }

    [Required]
    public string Channel { get; set; }
}