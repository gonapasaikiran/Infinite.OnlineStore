﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Infinite.OnlineStore.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("MyCon")
        {
        }
        public DbSet<ProductDetail> Products { get; set; }
        public DbSet<Category> Categeries { get; set; }
        public DbSet<PackSize> PackSizes { get; set; }
    }
}