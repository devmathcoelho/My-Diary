using System.ComponentModel.DataAnnotations;

namespace ASP.NET_TEST.Models
{
    public class DiaryEntry
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
