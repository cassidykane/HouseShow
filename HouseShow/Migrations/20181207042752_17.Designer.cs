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
    [Migration("20181207042752_17")]
    partial class _17
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

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(300);

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("ShowID");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("ArtistID");

                    b.HasIndex("ShowID");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("HouseShow.Models.Show", b =>
                {
                    b.Property<int>("ShowID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistNames");

                    b.Property<decimal>("Cost");

                    b.Property<string>("Description")
                        .HasMaxLength(300);

                    b.Property<DateTime>("Time");

                    b.Property<int?>("VenueID");

                    b.HasKey("ShowID");

                    b.HasIndex("VenueID");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("HouseShow.Models.Venue", b =>
                {
                    b.Property<int>("VenueID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Website");

                    b.HasKey("VenueID");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("HouseShow.Models.Artist", b =>
                {
                    b.HasOne("HouseShow.Models.Show")
                        .WithMany("Artists")
                        .HasForeignKey("ShowID");
                });

            modelBuilder.Entity("HouseShow.Models.Show", b =>
                {
                    b.HasOne("HouseShow.Models.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueID");
                });
#pragma warning restore 612, 618
        }
    }
}
