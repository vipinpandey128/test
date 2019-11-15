﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.DbContexts;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Model.Answers", b =>
                {
                    b.Property<long>("AnswerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText");

                    b.Property<long>("QuestionID");

                    b.HasKey("AnswerID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("WebApplication3.Model.Choices", b =>
                {
                    b.Property<long>("ChoiceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChoiceText");

                    b.Property<long>("QuestionID");

                    b.HasKey("ChoiceID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("WebApplication3.Model.Questions", b =>
                {
                    b.Property<long>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionText");

                    b.Property<long>("QuizID");

                    b.HasKey("QuestionID");

                    b.HasIndex("QuizID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("WebApplication3.Model.Quiz", b =>
                {
                    b.Property<long>("QuizID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuizImage");

                    b.Property<string>("QuizName");

                    b.Property<string>("Route");

                    b.HasKey("QuizID");

                    b.ToTable("Quizs");
                });

            modelBuilder.Entity("WebApplication3.Models.Blog", b =>
                {
                    b.Property<long>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogImage");

                    b.Property<string>("BlogText");

                    b.Property<string>("BlogTitle");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long>("Id");

                    b.Property<bool>("IsActive");

                    b.HasKey("BlogId");

                    b.HasIndex("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("WebApplication3.Models.EmailVerification", b =>
                {
                    b.Property<long>("vID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("eVerifiedDate");

                    b.Property<bool>("vIsStatus");

                    b.Property<string>("vLink");

                    b.Property<long>("vUserId");

                    b.HasKey("vID");

                    b.ToTable("EmailVerifications");
                });

            modelBuilder.Entity("WebApplication3.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuHeader");

                    b.Property<string>("MenuItem");

                    b.HasKey("MenuID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("WebApplication3.Models.MenuPermission", b =>
                {
                    b.Property<long>("mPID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuID");

                    b.Property<int>("RoleID");

                    b.HasKey("mPID");

                    b.HasIndex("MenuID");

                    b.HasIndex("RoleID");

                    b.ToTable("MenuPermissions");
                });

            modelBuilder.Entity("WebApplication3.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication3.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("ProfileImage");

                    b.Property<int>("RoleID");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication3.Model.Answers", b =>
                {
                    b.HasOne("WebApplication3.Model.Questions", "Questions")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication3.Model.Choices", b =>
                {
                    b.HasOne("WebApplication3.Model.Questions", "Questions")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication3.Model.Questions", b =>
                {
                    b.HasOne("WebApplication3.Model.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication3.Models.Blog", b =>
                {
                    b.HasOne("WebApplication3.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication3.Models.MenuPermission", b =>
                {
                    b.HasOne("WebApplication3.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication3.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication3.Models.User", b =>
                {
                    b.HasOne("WebApplication3.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
