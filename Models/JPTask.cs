using System.ComponentModel.DataAnnotations;

namespace JPTaskAssistant.Models
{
    public class JPTask : ItemMeta
    {
        public Guid Id { get; set; }
        public string Title {  get; set; }
        public JPTaskType Type { get; set; }
        public string? Description { get; set; }



    }
}
