﻿using System;
using System.Collections.Generic;
using System.Text;

DbSet:
using System.Data.Entity;
namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
