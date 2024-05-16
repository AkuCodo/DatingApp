﻿using DatingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Infra.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
}
