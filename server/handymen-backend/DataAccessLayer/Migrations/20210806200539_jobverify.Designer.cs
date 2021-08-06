﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20210806200539_jobverify")]
    partial class jobverify
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.HasSequence<int>("person_seq");

            modelBuilder.Entity("HandyManTrade", b =>
                {
                    b.Property<int>("HandyMenId")
                        .HasColumnType("integer");

                    b.Property<int>("TradesId")
                        .HasColumnType("integer");

                    b.HasKey("HandyMenId", "TradesId");

                    b.HasIndex("TradesId");

                    b.ToTable("HandyManTrade");
                });

            modelBuilder.Entity("JobAdTrade", b =>
                {
                    b.Property<int>("JobAdsId")
                        .HasColumnType("integer");

                    b.Property<int>("TradesId")
                        .HasColumnType("integer");

                    b.HasKey("JobAdsId", "TradesId");

                    b.HasIndex("TradesId");

                    b.ToTable("JobAdTrade");
                });

            modelBuilder.Entity("Model.models.AdditionalJobAdInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("PriceMax")
                        .HasColumnType("double precision");

                    b.Property<bool>("Urgent")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("AdditionalJobAdInfos");
                });

            modelBuilder.Entity("Model.models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:HiLoSequenceName", "person_seq")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("Model.models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Model.models.HandyMan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:HiLoSequenceName", "person_seq")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SequenceHiLo);

                    b.Property<int?>("CircleId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CircleId");

                    b.ToTable("HandyMen");
                });

            modelBuilder.Entity("Model.models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("HandyManId")
                        .HasColumnType("integer");

                    b.Property<int?>("JobAdId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HandyManId");

                    b.HasIndex("JobAdId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Model.models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Finished")
                        .HasColumnType("boolean");

                    b.Property<int?>("HandyManId")
                        .HasColumnType("integer");

                    b.Property<int?>("JobAdId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HandyManId");

                    b.HasIndex("JobAdId");

                    b.HasIndex("UserId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Model.models.JobAd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AdditionalJobAdInfoId")
                        .HasColumnType("integer");

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateWhen")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalJobAdInfoId");

                    b.HasIndex("AddressId");

                    b.HasIndex("OwnerId");

                    b.ToTable("JobAd");
                });

            modelBuilder.Entity("Model.models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Radius")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Model.models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("Model.models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("HandyManId")
                        .HasColumnType("integer");

                    b.Property<int>("Rate")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HandyManId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Model.models.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("Model.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:HiLoSequenceName", "person_seq")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HandyManTrade", b =>
                {
                    b.HasOne("Model.models.HandyMan", null)
                        .WithMany()
                        .HasForeignKey("HandyMenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.models.Trade", null)
                        .WithMany()
                        .HasForeignKey("TradesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobAdTrade", b =>
                {
                    b.HasOne("Model.models.JobAd", null)
                        .WithMany()
                        .HasForeignKey("JobAdsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.models.Trade", null)
                        .WithMany()
                        .HasForeignKey("TradesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.models.HandyMan", b =>
                {
                    b.HasOne("Model.models.Location", "Circle")
                        .WithMany()
                        .HasForeignKey("CircleId");

                    b.Navigation("Circle");
                });

            modelBuilder.Entity("Model.models.Interest", b =>
                {
                    b.HasOne("Model.models.HandyMan", "HandyMan")
                        .WithMany()
                        .HasForeignKey("HandyManId");

                    b.HasOne("Model.models.JobAd", "JobAd")
                        .WithMany()
                        .HasForeignKey("JobAdId");

                    b.Navigation("HandyMan");

                    b.Navigation("JobAd");
                });

            modelBuilder.Entity("Model.models.Job", b =>
                {
                    b.HasOne("Model.models.HandyMan", "HandyMan")
                        .WithMany("DoneJobs")
                        .HasForeignKey("HandyManId");

                    b.HasOne("Model.models.JobAd", "JobAd")
                        .WithMany()
                        .HasForeignKey("JobAdId");

                    b.HasOne("Model.models.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId");

                    b.Navigation("HandyMan");

                    b.Navigation("JobAd");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.models.JobAd", b =>
                {
                    b.HasOne("Model.models.AdditionalJobAdInfo", "AdditionalJobAdInfo")
                        .WithMany()
                        .HasForeignKey("AdditionalJobAdInfoId");

                    b.HasOne("Model.models.Location", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Model.models.User", "Owner")
                        .WithMany("JobAds")
                        .HasForeignKey("OwnerId");

                    b.Navigation("AdditionalJobAdInfo");

                    b.Navigation("Address");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Model.models.Profession", b =>
                {
                    b.HasOne("Model.models.Category", null)
                        .WithMany("Professions")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Model.models.Rating", b =>
                {
                    b.HasOne("Model.models.HandyMan", null)
                        .WithMany("Ratings")
                        .HasForeignKey("HandyManId");
                });

            modelBuilder.Entity("Model.models.Trade", b =>
                {
                    b.HasOne("Model.models.Profession", null)
                        .WithMany("Trades")
                        .HasForeignKey("ProfessionId");
                });

            modelBuilder.Entity("Model.models.Category", b =>
                {
                    b.Navigation("Professions");
                });

            modelBuilder.Entity("Model.models.HandyMan", b =>
                {
                    b.Navigation("DoneJobs");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Model.models.Profession", b =>
                {
                    b.Navigation("Trades");
                });

            modelBuilder.Entity("Model.models.User", b =>
                {
                    b.Navigation("JobAds");

                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
