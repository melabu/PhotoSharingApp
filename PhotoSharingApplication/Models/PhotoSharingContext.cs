﻿using System.Data.Entity;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingContext : DbContext
    {
        public PhotoSharingContext() : base("KeyDB") { }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}