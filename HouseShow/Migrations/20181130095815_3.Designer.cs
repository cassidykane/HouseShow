﻿// <auto-generated />
using System;
using HouseShow.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseShow.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181130095815_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseShow.Models.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<int?>("UserID");

                    b.HasKey("ArtistID");

                    b.HasIndex("UserID");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("HouseShow.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtistID");

                    b.Property<string>("Sender");

                    b.Property<DateTime>("Time");

                    b.Property<bool>("Unread");

                    b.Property<int?>("UserID");

                    b.Property<int?>("VenueID");

                    b.HasKey("MessageID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("UserID");

                    b.HasIndex("VenueID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HouseShow.Models.Show", b =>
                {
                    b.Property<int>("ShowID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<DateTime>("Time");

                    b.Property<int?>("VenueID");

                    b.HasKey("ShowID");

                    b.HasIndex("VenueID");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("HouseShow.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("State");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HouseShow.Models.Venue", b =>
                {
                    b.Property<int>("VenueID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<int?>("UserID");

                    b.HasKey("VenueID");

                    b.HasIndex("UserID");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("HouseShow.Models.Artist", b =>
                {
                    b.HasOne("HouseShow.Models.User")
                        .WithMany("Artists")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("HouseShow.Models.Message", b =>
                {
                    b.HasOne("HouseShow.Models.Artist")
                        .WithMany("Inbox")
                        .HasForeignKey("ArtistID");

                    b.HasOne("HouseShow.Models.User")
                        .WithMany("Inbox")
                        .HasForeignKey("UserID");

                    b.HasOne("HouseShow.Models.Venue")
                        .WithMany("Inbox")
                        .HasForeignKey("VenueID");
                });

            modelBuilder.Entity("HouseShow.Models.Show", b =>
                {
                    b.HasOne("HouseShow.Models.Venue", "Venue")
                        .WithMany("Shows")
                        .HasForeignKey("VenueID");
                });

            modelBuilder.Entity("HouseShow.Models.Venue", b =>
                {
                    b.HasOne("HouseShow.Models.User")
                        .WithMany("Venues")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
