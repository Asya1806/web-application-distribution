using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class CommissionDecision
    {
        [Key]
        public int Dec_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Decision { get; set; }
    }
}
