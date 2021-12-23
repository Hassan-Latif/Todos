using System.ComponentModel.DataAnnotations;

namespace Todos_App.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
