using System.ComponentModel.DataAnnotations;

namespace EasyCashIdentityProject.EntityLayer.Concrete;

public class CustomerAccountProcess
{
    [Key]
    public int CustomerAccountProcessId { get; set; }
    public string ProcessType { get; set; }
    public decimal Amount { get; set; }
    public DateTime ProcessDate { get; set; }
}