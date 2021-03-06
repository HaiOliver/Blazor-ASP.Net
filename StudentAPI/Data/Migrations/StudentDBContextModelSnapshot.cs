﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAPI.Data;

namespace StudentAPI.Data.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    partial class StudentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentClass.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BCIT_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Set")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = "a4dac49b-b167-46c3-a751-54877d70d378",
                            BCIT_ID = "A01222222",
                            City = "Vancouver",
                            Email = "aa@gmail.com",
                            FirstName = "Bob",
                            LastName = "YU",
                            MobileNumber = "601-234-1234",
                            Option = "AI",
                            Set = "S"
                        },
                        new
                        {
                            StudentId = "9eb10b36-abf6-40bf-9c3a-fb8fe087a271",
                            BCIT_ID = "A02322222",
                            City = "Vancouver",
                            Email = "bb@gmail.com",
                            FirstName = "Long",
                            LastName = "YUI",
                            MobileNumber = "601-000-1234",
                            Option = "Mobile",
                            Set = "A"
                        },
                        new
                        {
                            StudentId = "ac524377-3e66-432e-903f-260697348e6f",
                            BCIT_ID = "A01222452",
                            City = "Vancouver",
                            Email = "aswa@gmail.com",
                            FirstName = "Bio",
                            LastName = "Yong",
                            MobileNumber = "601-234-7834",
                            Option = "ML",
                            Set = "B"
                        },
                        new
                        {
                            StudentId = "f4bfe031-0d78-4fe2-b37a-ef4bf3e59a1f",
                            BCIT_ID = "A01222345",
                            City = "Burnaby",
                            Email = "aasss@gmail.com",
                            FirstName = "Kuyn",
                            LastName = "San",
                            MobileNumber = "601-234-7894",
                            Option = "Cloud",
                            Set = "S"
                        },
                        new
                        {
                            StudentId = "d990d94e-4ed7-45d9-a340-3e15d8754192",
                            BCIT_ID = "A01222345",
                            City = "Burnaby",
                            Email = "awewea@gmail.com",
                            FirstName = "Kuy",
                            LastName = "Sang",
                            MobileNumber = "601-234-7894",
                            Option = "Cloud",
                            Set = "S"
                        },
                        new
                        {
                            StudentId = "bff01aeb-16aa-4eb7-b8c3-e079d654228c",
                            BCIT_ID = "A01222390",
                            City = "Burnaby",
                            Email = "weeaa@gmail.com",
                            FirstName = "Oliver",
                            LastName = "Huynh",
                            MobileNumber = "601-234-7376",
                            Option = "Web",
                            Set = "D"
                        },
                        new
                        {
                            StudentId = "be4eabdb-05e7-4764-99e1-9d77e2edd816",
                            BCIT_ID = "A01222754",
                            City = "Surrey",
                            Email = "abbva@gmail.com",
                            FirstName = "Kim",
                            LastName = "Huy",
                            MobileNumber = "601-234-1762",
                            Option = "Technical Program",
                            Set = "C"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
