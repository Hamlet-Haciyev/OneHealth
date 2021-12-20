using Microsoft.EntityFrameworkCore;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<HealthCategory> HealthCategories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToNews> TagToNews { get; set; }


    }
}
