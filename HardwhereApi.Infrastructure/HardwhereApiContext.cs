﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwhereApi.Core.Models;

namespace HardwhereApi.Infrastructure
{
    public class HardwhereApiContext : DbContext
    {
        public HardwhereApiContext() : base("HardwhereApi")
        {
        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetProperty> AssertProperties { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<TypeProperty> TypeProperties { get; set; }

        public DbSet<User> Users { get; set; }
    }
}