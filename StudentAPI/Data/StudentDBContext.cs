using Microsoft.EntityFrameworkCore;
using StudentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Data
{
    public class StudentDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().HasData(
                
              new 
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Bob",
                  LastName = "YU",
                  BCIT_ID = "A01222222",
                  Email = "aa@gmail.com",
                  MobileNumber = "601-234-1234",
                  City = "Vancouver",
                  Option = "AI",
                  Set = "S"
              },
              new
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Long",
                  LastName = "YUI",
                  BCIT_ID = "A02322222",
                  Email = "bb@gmail.com",
                  MobileNumber = "601-000-1234",
                  City = "Vancouver",
                  Option = "Mobile",
                  Set = "A"
              },
              new 
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Bio",
                  LastName = "Yong",
                  BCIT_ID = "A01222452",
                  Email = "aswa@gmail.com",
                  MobileNumber = "601-234-7834",
                  City = "Vancouver",
                  Option = "ML",
                  Set = "B"
              },
              new 
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Kuyn",
                  LastName = "San",
                  BCIT_ID = "A01222345",
                  Email = "aasss@gmail.com",
                  MobileNumber = "601-234-7894",
                  City = "Burnaby",
                  Option = "Cloud",
                  Set = "S"
              },
              new 
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Kuy",
                  LastName = "Sang",
                  BCIT_ID = "A01222345",
                  Email = "awewea@gmail.com",
                  MobileNumber = "601-234-7894",
                  City = "Burnaby",
                  Option = "Cloud",
                  Set = "S"
              },
              new 
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Oliver",
                  LastName = "Huynh",
                  BCIT_ID = "A01222390",
                  Email = "weeaa@gmail.com",
                  MobileNumber = "601-234-7376",
                  City = "Burnaby",
                  Option = "Web",
                  Set = "D"
              },
            new 
            {
                StudentId = Guid.NewGuid().ToString(),
                FirstName = "Kim",
                LastName = "Huy",
                BCIT_ID = "A01222754",
                Email = "abbva@gmail.com",
                MobileNumber = "601-234-1762",
                City = "Surrey",
                Option = "Technical Program",
                Set = "C"
            }
                );
        }
    }
}
