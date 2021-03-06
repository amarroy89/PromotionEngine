﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineDAL
{
    public class PromotionContext : DbContext
    {
        //public PromotionContext(DbContextOptions options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite(@"Data Source=C:\Amar Doc\PromotionDB.db");      
        public DbSet<Sku> Skus { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
    }
}
