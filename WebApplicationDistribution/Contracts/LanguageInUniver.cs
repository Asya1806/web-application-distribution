using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class LanguageInUniver
    {
        [Key]
        public int Lang_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Language { get; set; }
    }
}
