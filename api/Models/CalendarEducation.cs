using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CalendarEducation
    {
        [Key]
        public int CalendarEducationId { get; set; }
        public string EducationType { get; set; }
        public string? EducationDescription { get; set; }
        public DateOnly EducationStart { get; set; }
        public DateOnly? EducationEnd { get; set; }
        public Collection<Material>? Materials { get; set; }
    }
}
