using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class Gender
    {
        [Key]
        public int Gender_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; }
    }
}
