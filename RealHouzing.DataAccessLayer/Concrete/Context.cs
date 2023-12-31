﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.DataAccessLayer.Concrete
{
    public class Context :  IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RCI54VP; initial catalog= RealHouzingDb; integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BuyLease> BuyLeases { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<VideoAndAbout> VideoAndAbouts { get; set; }

        public DbSet<About> Abouts { get; set; }

         
       
    }
}
