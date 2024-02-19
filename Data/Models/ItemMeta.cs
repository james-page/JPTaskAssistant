using System.ComponentModel.DataAnnotations;

namespace JPTaskAssistant.Data.Models
{
    public class ItemMeta
    {
        [Required]
        public DateTime DateEntered { get; set; }
        [Required]
        public string? EnteredBy { get; set; }

    }
}
