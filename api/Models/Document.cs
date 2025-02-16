using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Category { get; set; }
        public bool HasComments { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Document))]
        public int DocumentId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; } 
        public User? Author { get; set; }
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
