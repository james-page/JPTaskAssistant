using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JPTaskAssistant.Data.Models;

namespace JPTaskAssistant.Data
{
    public class JPTaskAssistantContext : DbContext
    {
        public JPTaskAssistantContext (DbContextOptions<JPTaskAssistantContext> options)
            : base(options)
        {
        }

        public DbSet<JPTaskAssistant.Data.Models.JPDailyListTask> JPDailyListTask { get; set; } = default!;
    }
}
