﻿// <auto-generated />
using System;
using EntityFrameworkProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkProject.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20220505164909_IniatialCreation")]
    partial class IniatialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartamentLecture", b =>
                {
                    b.Property<int>("DepartamentsId")
                        .HasColumnType("int");

                    b.Property<int>("LecturesId")
                        .HasColumnType("int");

                    b.HasKey("DepartamentsId", "LecturesId");

                    b.HasIndex("LecturesId");

                    b.ToTable("DepartamentLecture");
                });

            modelBuilder.Entity("EntityFrameworkProject.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("EntityFrameworkProject.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("EntityFrameworkProject.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DepartamentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DepartamentLecture", b =>
                {
                    b.HasOne("EntityFrameworkProject.Departament", null)
                        .WithMany()
                        .HasForeignKey("DepartamentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkProject.Lecture", null)
                        .WithMany()
                        .HasForeignKey("LecturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameworkProject.Student", b =>
                {
                    b.HasOne("EntityFrameworkProject.Departament", null)
                        .WithMany("Students")
                        .HasForeignKey("DepartamentId");
                });

            modelBuilder.Entity("EntityFrameworkProject.Departament", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}