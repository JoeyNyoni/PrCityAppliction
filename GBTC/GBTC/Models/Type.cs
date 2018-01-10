using System.ComponentModel.DataAnnotations;

namespace GBTC.Models
{
    public class Type
    {
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}