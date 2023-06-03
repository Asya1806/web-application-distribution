using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts.Specialties;

public class Specialty
{
    [Key]
    public int Spec_Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string SpecialtyName { get; set; }
    
    public int BudgetSeats { get; set; }
    
    public int PaidSeats { get; set; }
}
