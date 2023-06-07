﻿// <auto-generated />
using APi.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230607062050_newBill")]
    partial class newBill
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AddressGuest", b =>
                {
                    b.Property<int>("AddressesAddressId")
                        .HasColumnType("int");

                    b.Property<int>("GuestsGuestId")
                        .HasColumnType("int");

                    b.HasKey("AddressesAddressId", "GuestsGuestId");

                    b.HasIndex("GuestsGuestId");

                    b.ToTable("AddressGuest");
                });

            modelBuilder.Entity("HotelverwaltungKlassenbib.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Housenumber")
                        .HasColumnType("int");

                    b.Property<int>("Postalcode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("HotelverwaltungKlassenbib.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotelverwaltungKlassenbib.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Balkon")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Betten")
                        .HasColumnType("int");

                    b.Property<bool>("Kueche")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Preis")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Terrasse")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ZimmerNr")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("AddressGuest", b =>
                {
                    b.HasOne("HotelverwaltungKlassenbib.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelverwaltungKlassenbib.Models.Guest", null)
                        .WithMany()
                        .HasForeignKey("GuestsGuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}