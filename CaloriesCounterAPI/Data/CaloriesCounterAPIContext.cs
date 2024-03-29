﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaloriesCounterAPI.Models;

namespace CaloriesCounterAPI.Data
{
    public class CaloriesCounterAPIContext : DbContext
    {
        public CaloriesCounterAPIContext (DbContextOptions<CaloriesCounterAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CaloriesCounterAPI.Models.Product> Product { get; set; } = default!;
        public DbSet<CaloriesCounterAPI.Models.ProductAdded> ProductAdded { get; set; } = default!;
        public DbSet<CaloriesCounterAPI.Models.Meal> Meal { get; set; } = default!;
    }
}
