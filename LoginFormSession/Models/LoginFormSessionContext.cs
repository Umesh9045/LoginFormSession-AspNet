﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginFormSession.Models;

public partial class LoginFormSessionContext : DbContext
{
    public LoginFormSessionContext()
    {
    }

    public LoginFormSessionContext(DbContextOptions<LoginFormSessionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserTbl> UserTbls { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_tbl__3213E83F7EA3EC94");

            entity.ToTable("user_tbl");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
