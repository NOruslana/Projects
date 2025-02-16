
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class EventStatus
    {
        [Key]
        public int EventStatusId { get; set; }
        public string EventStatusName { get; set; }
    }
}
