using System.ComponentModel.DataAnnotations;

namespace EasyCashIdentityProject.EntityLayer.Concrete;

public class CustomerAccount
{
    [Key]
    public int CustomerAccountId { get; set; }
    public string CustomerAccountNumber { get; set; }
    public string CustomerAccountCurrency { get; set; }
    public decimal CustomerAccountBalance { get; set; }
    public string BankBranch { get; set; }
}