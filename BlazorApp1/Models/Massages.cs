using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Massages
    {
        [Key]
        public int Id_massages { get; set; }
        public int dialog_id { get; set; }
        public string text { get; set; }
        public DateTime time_creation { get; set; }
        public bool text_changed { get; set; }
        public Dialogs? Dialogs { get; set; }
    }
}
