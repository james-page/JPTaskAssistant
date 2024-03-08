using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace JPTaskAssistant.Data.Models
{
    public enum JPTaskType
    {
        [Description("Daily List Task")]
        DailyListTask,
        [Description("Hourly Task")]
        HourlyTask,
        [Description("All Day Task")]
        AllDayTask,
        [Description("All Week Task")]
        AllWeekTask,
        [Description("All Month Task")]
        AllMonthTask
    }

    internal static class Extensions
    {
        public static string ToDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

}
