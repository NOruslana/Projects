using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Depatment
    {
        [Key]
        public int DepatmentId { get; set; }
        [Required]
        public string DepatmentName { get; set; }
        public int? Level { get; set; }
        public int? Parent {  get; set; }
        public string? Information { get; set; }
    }
}
