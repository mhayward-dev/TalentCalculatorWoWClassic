﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WoWClassicTalentCalculator.DataAccess;

namespace WoWClassicTalentCalculator.Migrations
{
    [DbContext(typeof(TalentCalculatorContext))]
    partial class TalentCalculatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.SpecificationTalent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColumnIndex");

                    b.Property<int>("RowIndex");

                    b.Property<int?>("TalentIconId");

                    b.Property<string>("TalentName");

                    b.Property<int>("WarcraftClassSpecificationId");

                    b.HasKey("Id");

                    b.HasIndex("TalentIconId");

                    b.HasIndex("WarcraftClassSpecificationId");

                    b.ToTable("SpecificationTalents");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.TalentIcon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.HasKey("Id");

                    b.ToTable("TalentIcons");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.TalentRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RankDescription");

                    b.Property<int>("RankNo");

                    b.Property<int?>("SpecificationTalentId");

                    b.HasKey("Id");

                    b.HasIndex("SpecificationTalentId");

                    b.ToTable("TalentRanks");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.TalentRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RequirementDescription");

                    b.Property<int>("TalentRankId");

                    b.HasKey("Id");

                    b.HasIndex("TalentRankId");

                    b.ToTable("TalentRequirements");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.WarcraftClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.ToTable("WarcraftClasses");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.WarcraftClassSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SpecificationIndex");

                    b.Property<string>("SpecificationName");

                    b.Property<int>("WarcraftClassId");

                    b.HasKey("Id");

                    b.HasIndex("WarcraftClassId");

                    b.ToTable("WarcraftClassSpecifications");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.SpecificationTalent", b =>
                {
                    b.HasOne("WoWClassicTalentCalculator.Models.TalentIcon", "TalentIcon")
                        .WithMany()
                        .HasForeignKey("TalentIconId");

                    b.HasOne("WoWClassicTalentCalculator.Models.WarcraftClassSpecification")
                        .WithMany("SpecificationTalents")
                        .HasForeignKey("WarcraftClassSpecificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.TalentRank", b =>
                {
                    b.HasOne("WoWClassicTalentCalculator.Models.SpecificationTalent")
                        .WithMany("TalentRanks")
                        .HasForeignKey("SpecificationTalentId");
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.TalentRequirement", b =>
                {
                    b.HasOne("WoWClassicTalentCalculator.Models.TalentRank")
                        .WithMany("TalentRequirements")
                        .HasForeignKey("TalentRankId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoWClassicTalentCalculator.Models.WarcraftClassSpecification", b =>
                {
                    b.HasOne("WoWClassicTalentCalculator.Models.WarcraftClass")
                        .WithMany("WarcraftClassSpecifications")
                        .HasForeignKey("WarcraftClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
