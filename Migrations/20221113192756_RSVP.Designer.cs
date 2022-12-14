// <auto-generated />
using System;
using BulldogsPortal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulldogsPortal.Migrations
{
    [DbContext(typeof(RSVPDbContext))]
    [Migration("20221113192756_RSVP")]
    partial class RSVP
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulldogsPortal.Models.Domain.RSVP", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Airframe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Confirm")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RSVPs");
                });
#pragma warning restore 612, 618
        }
    }
}
