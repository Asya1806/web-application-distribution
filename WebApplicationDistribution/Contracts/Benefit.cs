using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class Benefit
    {
        [Key]
        public int Benefit_Id { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string _benefit { get; set; }
    }
}
