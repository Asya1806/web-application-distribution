using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class Locality
    {
        [Key]
        public int Locality_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LocalityName { get; set; }
    }
}
