using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SystemEwidencjonowaniaAR.Models;

namespace SystemEwidencjonowaniaAR.Context
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

    }
}