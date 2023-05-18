using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class PassportSeries
    {
        [Key]
        public int series_Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string SeriesName { get; set; }
    }
}
