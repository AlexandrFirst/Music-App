﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicAppApi.Models;

namespace MusicAppApi.Migrations
{
    [DbContext(typeof(MyDataContext))]
    [Migration("20211201173953_Rating config changed")]
    partial class Ratingconfigchanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicAppApi.Models.AudioFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceDescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 12, 1, 19, 39, 50, 454, DateTimeKind.Local).AddTicks(1503));

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaceDescriptionId");

                    b.ToTable("AudioFiles");
                });

            modelBuilder.Entity("MusicAppApi.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCommentId")
                        .HasColumnType("int");

                    b.Property<int?>("PlaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentCommentId");

                    b.HasIndex("PlaceId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MusicAppApi.Models.PhotoFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceDescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 12, 1, 19, 39, 50, 463, DateTimeKind.Local).AddTicks(4733));

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaceDescriptionId");

                    b.ToTable("PhotoFiles");
                });

            modelBuilder.Entity("MusicAppApi.Models.PlaceDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ViewNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("PlaceDescriptions");
                });

            modelBuilder.Entity("MusicAppApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Mail")
                        .IsUnique()
                        .HasFilter("[Mail] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MusicAppApi.Models.UserPlaceRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlaceId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("PlaceId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("MusicAppApi.Models.VideoFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceDescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 12, 1, 19, 39, 50, 463, DateTimeKind.Local).AddTicks(3434));

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaceDescriptionId");

                    b.ToTable("VideoFiles");
                });

            modelBuilder.Entity("MusicAppApi.Models.AudioFile", b =>
                {
                    b.HasOne("MusicAppApi.Models.PlaceDescription", "PlaceDescription")
                        .WithMany("Audios")
                        .HasForeignKey("PlaceDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("PlaceDescription");
                });

            modelBuilder.Entity("MusicAppApi.Models.Comment", b =>
                {
                    b.HasOne("MusicAppApi.Models.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId");

                    b.HasOne("MusicAppApi.Models.Comment", "ParentComment")
                        .WithMany("CommentReplies")
                        .HasForeignKey("ParentCommentId");

                    b.HasOne("MusicAppApi.Models.PlaceDescription", "Place")
                        .WithMany("Comments")
                        .HasForeignKey("PlaceId");

                    b.Navigation("Author");

                    b.Navigation("ParentComment");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("MusicAppApi.Models.PhotoFile", b =>
                {
                    b.HasOne("MusicAppApi.Models.PlaceDescription", "PlaceDescription")
                        .WithMany("Photos")
                        .HasForeignKey("PlaceDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("PlaceDescription");
                });

            modelBuilder.Entity("MusicAppApi.Models.PlaceDescription", b =>
                {
                    b.HasOne("MusicAppApi.Models.User", "Author")
                        .WithMany("PlaceDescriptions")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Author");
                });

            modelBuilder.Entity("MusicAppApi.Models.UserPlaceRating", b =>
                {
                    b.HasOne("MusicAppApi.Models.PlaceDescription", "Place")
                        .WithMany("Ratings")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicAppApi.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MusicAppApi.Models.VideoFile", b =>
                {
                    b.HasOne("MusicAppApi.Models.PlaceDescription", "PlaceDescription")
                        .WithMany("Videos")
                        .HasForeignKey("PlaceDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("PlaceDescription");
                });

            modelBuilder.Entity("MusicAppApi.Models.Comment", b =>
                {
                    b.Navigation("CommentReplies");
                });

            modelBuilder.Entity("MusicAppApi.Models.PlaceDescription", b =>
                {
                    b.Navigation("Audios");

                    b.Navigation("Comments");

                    b.Navigation("Photos");

                    b.Navigation("Ratings");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("MusicAppApi.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PlaceDescriptions");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
