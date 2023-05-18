using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class YesOrNo
    {
        [Key]
        public int YN_Id { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Y_N { get; set; }
    }
}
