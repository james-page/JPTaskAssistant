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

        public DbSet<JPDailyListTask> JPDailyListTask { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string james = "James";

            modelBuilder.Entity<JPDailyListTask>().HasData(
                new JPDailyListTask()
                {
                    Id = Guid.NewGuid(),
                    Title = "Create New UI",
                    EnteredBy = james,
                    DateEntered = DateTime.Now
                },
                new JPDailyListTask()
                {
                    Id = Guid.NewGuid(),
                    Title = "Test Checking Task as Done",
                    EnteredBy = james,
                    DateEntered = DateTime.Now
                },
                new JPDailyListTask()
                {
                    Id = Guid.NewGuid(),
                    Title = "Add and Remove Tasks",
                    EnteredBy = james,
                    DateEntered = DateTime.Now
                },
                new JPDailyListTask()
                {
                    Id = Guid.NewGuid(),
                    Title = "Come Up With Celebration Idea",
                    EnteredBy = james,
                    DateEntered = DateTime.Now
                },
                new JPDailyListTask()
                {
                    Id = Guid.NewGuid(),
                    Title = "Figure Out a Hosting Solution",
                    EnteredBy = james,
                    DateEntered = DateTime.Now
                });
        }
    }
}
