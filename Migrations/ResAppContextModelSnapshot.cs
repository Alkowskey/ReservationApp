﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ReservationsApp2.Context;

namespace ReservationsApp2.Migrations
{
    [DbContext(typeof(ResAppContext))]
    partial class ResAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ReservationsApp2.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<DateTime>("From")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("RoomId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("To")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ReservationId");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ReservationsApp2.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("RoomKey")
                        .HasColumnType("text");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ReservationsApp2.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ReservationsApp2.Models.UserRoom", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("RoomId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoom");
                });

            modelBuilder.Entity("ReservationsApp2.Models.Reservation", b =>
                {
                    b.HasOne("ReservationsApp2.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("ReservationsApp2.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ReservationsApp2.Models.UserRoom", b =>
                {
                    b.HasOne("ReservationsApp2.Models.Room", "Room")
                        .WithMany("UserRooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservationsApp2.Models.User", "User")
                        .WithMany("UserRooms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
