﻿// <auto-generated />
using System;
using Cryptocurrency.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cryptocurrency.Migrations
{
    [DbContext(typeof(CryptocurrencyContext))]
    [Migration("20190809153312_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cryptocurrency.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Symbol");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("cryptocurrency.Models.CurrencyInfo", b =>
                {
                    b.Property<int?>("CurInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Ath");

                    b.Property<float>("AthChangePercentage");

                    b.Property<DateTime>("AthDate");

                    b.Property<long>("CirculatingSupply");

                    b.Property<int?>("CurrencyId");

                    b.Property<float>("CurrentPtice");

                    b.Property<long>("High24h");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<long>("Low24h");

                    b.Property<long>("MarkertCap");

                    b.Property<long>("MarketCapChange24h");

                    b.Property<float>("MarketCapChangePercentage24");

                    b.Property<int>("MarketCapRank");

                    b.Property<float>("PriceChange24h");

                    b.Property<float>("PriceChangePercentage24h");

                    b.Property<int>("Roi");

                    b.Property<long>("TotalSupply");

                    b.Property<long>("TotalVolume");

                    b.HasKey("CurInfoId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("CurrencyInfos");
                });

            modelBuilder.Entity("cryptocurrency.Models.CurrencyInfo", b =>
                {
                    b.HasOne("cryptocurrency.Models.Currency", "currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");
                });
#pragma warning restore 612, 618
        }
    }
}