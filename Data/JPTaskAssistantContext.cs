﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JPTaskAssistant.Models;

namespace JPTaskAssistant.Data
{
    public class JPTaskAssistantContext : DbContext
    {
        public JPTaskAssistantContext (DbContextOptions<JPTaskAssistantContext> options)
            : base(options)
        {
        }

        public DbSet<JPTaskAssistant.Models.JPTask> JPTask { get; set; } = default!;
    }
}