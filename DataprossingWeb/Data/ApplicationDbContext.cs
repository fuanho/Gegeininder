﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataprossingWeb.Models;

namespace DataprossingWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PopulationAgeGroupInBaishaPenghu> PopulationAgeGroupInBaishaPenghus { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}