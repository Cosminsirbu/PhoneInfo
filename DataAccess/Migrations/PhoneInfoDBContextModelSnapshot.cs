﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneInfo.DataAccess;

namespace DataAccess.Migrations
{
    [DbContext(typeof(PhoneInfoDBContext))]
    partial class PhoneInfoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.Comment", b =>
                {
                    b.Property<long>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long?>("PhoneId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("AdminId");

                    b.HasIndex("PhoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.Phone", b =>
                {
                    b.Property<long>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.TipUs", b =>
                {
                    b.Property<long>("TipusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipusId");

                    b.HasIndex("AdminId");

                    b.ToTable("TipUs");
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccessPermission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AdminId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.Comment", b =>
                {
                    b.HasOne("PhoneInfo.ApplicationLogic.DataModel.Admin", null)
                        .WithMany("CommentsId")
                        .HasForeignKey("AdminId");

                    b.HasOne("PhoneInfo.ApplicationLogic.DataModel.Phone", null)
                        .WithMany("CommentId")
                        .HasForeignKey("PhoneId");

                    b.HasOne("PhoneInfo.ApplicationLogic.DataModel.User", null)
                        .WithMany("CommentId")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.TipUs", b =>
                {
                    b.HasOne("PhoneInfo.ApplicationLogic.DataModel.Admin", null)
                        .WithMany("TipusId")
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("PhoneInfo.ApplicationLogic.DataModel.User", b =>
                {
                    b.HasOne("PhoneInfo.ApplicationLogic.DataModel.Admin", null)
                        .WithMany("UsersId")
                        .HasForeignKey("AdminId");
                });
#pragma warning restore 612, 618
        }
    }
}
