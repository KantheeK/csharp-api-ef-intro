﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Band", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Formed")
                        .HasColumnType("integer")
                        .HasColumnName("formed_year");

                    b.Property<string>("Genre")
                        .HasColumnType("text")
                        .HasColumnName("genre");

                    b.Property<int>("MembersCount")
                        .HasColumnType("integer")
                        .HasColumnName("members");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("bands");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.BandMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BandId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_band_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("bandmembers");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.BandMemberInstrument", b =>
                {
                    b.Property<int>("BandMemberId")
                        .HasColumnType("integer")
                        .HasColumnName("bandmemberid");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("integer")
                        .HasColumnName("instrumentid");

                    b.HasKey("BandMemberId", "InstrumentId");

                    b.ToTable("bandmember_instrument");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("instruments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.BandMember", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.DatabaseModels.Band", "Band")
                        .WithMany("Members")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.DatabaseModels.Band", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
