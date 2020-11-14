﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Roomates.DataModel.Models;

namespace Roomates.DataModel.Migrations.ApartmentsDb
{
    [DbContext(typeof(ApartmentsDbContext))]
    [Migration("20201106124726_ApartmentsMigrations")]
    partial class ApartmentsMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Roomates.DataModel.Models.Apartment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("BathEquipped");

                    b.Property<bool>("BedroomsEquipped");

                    b.Property<bool>("InternetAccess");

                    b.Property<bool>("KitchenEqupped");

                    b.Property<bool>("LivingRoomEqupped");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Price")
                        .HasMaxLength(100);

                    b.Property<int>("Rooms")
                        .HasMaxLength(100);

                    b.Property<bool>("Smoking");

                    b.Property<bool>("TvAccess");

                    b.Property<string>("TvOperator")
                        .IsRequired();

                    b.Property<bool>("TwoSepratedBedRooms");

                    b.Property<string>("TypeOfHEating")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Apartment");

                    b.HasData(
                        new { Id = "2", Area = "Skopje", BathEquipped = true, BedroomsEquipped = true, InternetAccess = true, KitchenEqupped = false, LivingRoomEqupped = true, Name = "Apartmento", Password = "`-?`;?'????F??", Price = 230, Rooms = 4, Smoking = true, TvAccess = true, TvOperator = "N/A", TwoSepratedBedRooms = false, TypeOfHEating = "N/A" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
