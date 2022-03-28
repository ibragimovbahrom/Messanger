using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class User
    {
        [Key]
        public int Id_user { get; set; }
        public string Email { get; set; }
    }
}
