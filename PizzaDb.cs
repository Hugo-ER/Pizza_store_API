﻿using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;    

namespace PizzaStore.Models
{
    public class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
}
