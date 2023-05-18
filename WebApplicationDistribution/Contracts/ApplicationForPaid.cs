using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class ApplicationForPaid
    {
        [Key]
        public int Applic_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Application { get; set; }
    }
}
