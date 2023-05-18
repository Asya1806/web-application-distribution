using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts
{
    public class LoginRequest
    {
        [Key]
        public int Log_Id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Login { get; set; }
       
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
    }
}
