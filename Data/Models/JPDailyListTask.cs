using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace JPTaskAssistant.Data.Models
{
    public class JPDailyListTask : ItemMeta
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required]
        [DefaultValue(JPTaskType.DailyListTask)]
        public JPTaskType Type { get; set; }

        public string? Description { get; set; }



    }
}
