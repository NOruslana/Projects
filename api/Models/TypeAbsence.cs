using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class TypeAbsence
    {
        [Key]
        public int TypeAbsenceId { get; set; }
        public string TypeAbsenceName { get; set; }
    }
}
