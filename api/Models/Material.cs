using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string? MaterialDescription { get; set; }
        public CalendarEducation Education { get; set; }
    }
}
