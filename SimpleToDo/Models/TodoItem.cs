using System.ComponentModel.DataAnnotations;


namespace SimpleToDo.Models
{
    public class TodoItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TodoName { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        
    }
}