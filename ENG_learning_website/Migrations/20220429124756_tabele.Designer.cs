﻿// <auto-generated />
using System;
using ENG_learning_website.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ENG_learning_website.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220429124756_tabele")]
    partial class tabele
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ENG_learning_website.Models.Answers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("points")
                        .HasColumnType("int");

                    b.Property<bool>("subscription")
                        .HasColumnType("bit");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ENG_learning_website.Models.ClientLang", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("LangId")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "LangId");

                    b.HasIndex("LangId");

                    b.ToTable("ClientLang");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Dictionary", b =>
                {
                    b.Property<int>("DictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DictId"), 1L, 1);

                    b.Property<string>("meaningOb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meaningPl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DictId");

                    b.ToTable("Dictionary");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DicId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DicId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoobsHolder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("NoobsHolder")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Answers", b =>
                {
                    b.HasOne("ENG_learning_website.Models.Task", "Task")
                        .WithMany("Answers")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ENG_learning_website.Models.ClientLang", b =>
                {
                    b.HasOne("ENG_learning_website.Models.Client", "Client")
                        .WithMany("Clientlangs")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENG_learning_website.Models.Language", "Language")
                        .WithMany("ClientLangs")
                        .HasForeignKey("LangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Course", b =>
                {
                    b.HasOne("ENG_learning_website.Models.Language", null)
                        .WithMany("Courses")
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Language", b =>
                {
                    b.HasOne("ENG_learning_website.Models.Dictionary", "dictionary")
                        .WithMany("Languages")
                        .HasForeignKey("DicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dictionary");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Lesson", b =>
                {
                    b.HasOne("ENG_learning_website.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Task", b =>
                {
                    b.HasOne("ENG_learning_website.Models.Lesson", "lesson")
                        .WithMany("Tasks")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lesson");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Client", b =>
                {
                    b.Navigation("Clientlangs");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Course", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Dictionary", b =>
                {
                    b.Navigation("Languages");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Language", b =>
                {
                    b.Navigation("ClientLangs");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Lesson", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("ENG_learning_website.Models.Task", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
