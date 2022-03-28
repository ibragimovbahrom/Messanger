using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class MassageToPhotos
    {
        [Key]
        public int Id { get; set; }
        public int photo_id { get; set; }
        public int massage_id { get; set; }
        public Photos? Photos { get; set; }
        public Massages? Massages { get; set; }
    }
}
