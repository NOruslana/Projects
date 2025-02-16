using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public Depatment Depatment {  get; set; }
        public Position Position { get; set; }
        [Required]
        public string WorkerName { get; set; }
        public DateOnly Birthday { get; set; }
        [MaxLength(20)]
        public string WorkPhone { get; set; }
        [MaxLength(20)]
        public string? MobilePhone { get; set; }
        [MaxLength(10)]
        public string OfficeRoom { get; set; }
        public string Email { get; set; }
        public bool? IsDirector { get; set; }
        public Collection<CalendarEducation>? Educations { get; set; }
        public Collection<CalendarAbsence>? Absences { get; set; }

    }
}
