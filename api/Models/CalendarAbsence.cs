using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CalendarAbsence
    {
        [Key]
        public int CalendarAbsenceId { get; set; }
        public TypeAbsence TypeAbsence { get; set; }
        public DateOnly EducationStart { get; set; }
        public DateOnly? EducationEnd { get; set; }
        public string? Information { get; set; }
    }
}
