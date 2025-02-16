using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
    }
}
