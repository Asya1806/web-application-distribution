using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class TypeOfContest
    {
        [Key]
        public int Contest_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Contest { get; set; }
    }
}
