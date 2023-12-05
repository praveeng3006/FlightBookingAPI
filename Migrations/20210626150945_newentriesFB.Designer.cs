﻿// <auto-generated />
using System;
using Flight_booking.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flight_booking.Migrations
{
    [DbContext(typeof(FDbcontext))]
    [Migration("20210626150945_newentriesFB")]
    partial class newentriesFB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Flight_booking.Models.Airlinesmodel", b =>
                {
                    b.Property<byte[]>("Airlinelogo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Airlinename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Avilabledate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contactname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contactnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Triptype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("flightnumber")
                        .HasColumnType("int");

                    b.Property<string>("instrumentused")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("airlinemodel");
                });

            modelBuilder.Entity("Flight_booking.Models.Flightbookingsmodel", b =>
                {
                    b.Property<int>("FlightBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Airlinelogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Airlinename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Discountcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fromplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mealtype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pnrnumber")
                        .HasColumnType("int");

                    b.Property<string>("ReturnAirlinelogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnAirlinename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReturnAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReturnMealtype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Selectedseatonward")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Selectedseatreturn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Totalamount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Triptype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Userid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("bookeddate")
                        .HasColumnType("datetime2");

                    b.Property<int>("numberofseats")
                        .HasColumnType("int");

                    b.Property<DateTime>("onwarddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("returndate")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("FlightBookingId");

                    b.ToTable("bookmodel");

                    b.HasData(
                        new
                        {
                            FlightBookingId = 1,
                            Airlinelogo = "",
                            Airlinename = "SpiceJet",
                            Amount = 2504m,
                            Discountcode = "DC100",
                            Fromplace = "Hyderabad",
                            Mealtype = "SampleMeal",
                            Pnrnumber = 123456,
                            ReturnAirlinelogo = "ssss",
                            ReturnAirlinename = "SpiceJet",
                            ReturnAmount = 2504m,
                            ReturnMealtype = "SampleMeal",
                            Selectedseatonward = "A1",
                            Selectedseatreturn = "A2",
                            Toplace = "Bangalore",
                            Totalamount = 5008m,
                            Triptype = "sampelTriptype",
                            UserEmail = "Surya.Teja@gmail.com",
                            Userid = "1",
                            Username = "Surya",
                            bookeddate = new DateTime(2021, 6, 26, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(300),
                            numberofseats = 3,
                            onwarddate = new DateTime(2021, 7, 1, 20, 39, 45, 245, DateTimeKind.Local).AddTicks(7685),
                            returndate = new DateTime(2021, 7, 3, 20, 39, 45, 246, DateTimeKind.Local).AddTicks(5180),
                            status = 1
                        },
                        new
                        {
                            FlightBookingId = 2,
                            Airlinelogo = "",
                            Airlinename = "SpiceJet",
                            Amount = 2504m,
                            Discountcode = "DC100",
                            Fromplace = "Hyderabad",
                            Mealtype = "SampleMeal",
                            Pnrnumber = 789012,
                            ReturnAirlinelogo = "ssss",
                            ReturnAirlinename = "Indigo",
                            ReturnAmount = 2504m,
                            ReturnMealtype = "SampleMeal",
                            Selectedseatonward = "B1",
                            Selectedseatreturn = "B2",
                            Toplace = "Delhi",
                            Totalamount = 5008m,
                            Triptype = "TwoWayTrip",
                            UserEmail = "Surya.Teja2@gmail.com",
                            Userid = "2",
                            Username = "Surya2",
                            bookeddate = new DateTime(2021, 6, 26, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(1001),
                            numberofseats = 1,
                            onwarddate = new DateTime(2021, 7, 1, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(993),
                            returndate = new DateTime(2021, 7, 3, 20, 39, 45, 247, DateTimeKind.Local).AddTicks(997),
                            status = 1
                        });
                });

            modelBuilder.Entity("Flight_booking.Models.Usersmodel", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("usermodel");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Password = "Ind@3333",
                            Role = "user",
                            UserEmail = "Surya.Teja@gmail.com",
                            Username = "Surya Teja"
                        },
                        new
                        {
                            UserID = 2,
                            Password = "Ind@3333",
                            Role = "user",
                            UserEmail = "Surya.Teja2@gmail.com",
                            Username = "Surya Teja2"
                        });
                });

            modelBuilder.Entity("Flight_booking.Models.passengerdetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pnrnumber")
                        .HasColumnType("int");

                    b.Property<string>("Usermail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("flightbookingid")
                        .HasColumnType("int");

                    b.Property<string>("mealpreference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("selectedseatnumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("flightbookingid");

                    b.ToTable("PassengerDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            Gender = "M",
                            Name = "Surya",
                            Pnrnumber = 12345,
                            Usermail = "Surya.Teja@gmail.com",
                            flightbookingid = 1,
                            mealpreference = "mealpref",
                            selectedseatnumber = "A1"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            Gender = "M",
                            Name = "Teja",
                            Pnrnumber = 12345,
                            Usermail = "Surya.Teja3@gmail.com",
                            flightbookingid = 1,
                            mealpreference = "mealpref",
                            selectedseatnumber = "A2"
                        },
                        new
                        {
                            Id = 3,
                            Age = 25,
                            Gender = "M",
                            Name = "Surya2",
                            Pnrnumber = 789012,
                            Usermail = "Surya.Teja2@gmail.com",
                            flightbookingid = 2,
                            mealpreference = "mealpref",
                            selectedseatnumber = "B1"
                        });
                });

            modelBuilder.Entity("Flight_booking.Models.passengerdetails", b =>
                {
                    b.HasOne("Flight_booking.Models.Flightbookingsmodel", "flightbookingsmodel")
                        .WithMany("passengerdetails")
                        .HasForeignKey("flightbookingid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("flightbookingsmodel");
                });

            modelBuilder.Entity("Flight_booking.Models.Flightbookingsmodel", b =>
                {
                    b.Navigation("passengerdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
