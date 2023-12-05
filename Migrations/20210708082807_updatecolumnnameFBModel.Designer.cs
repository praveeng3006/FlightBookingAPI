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
    [Migration("20210708082807_updatecolumnnameFBModel")]
    partial class updatecolumnnameFBModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Flight_booking.Models.AirlineMasterModel", b =>
                {
                    b.Property<int>("AirlinesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirlineLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirlineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Blocked")
                        .HasColumnType("bit");

                    b.HasKey("AirlinesId");

                    b.ToTable("Airlines");

                    b.HasData(
                        new
                        {
                            AirlinesId = 1,
                            AirlineLogo = "AirIndia.jpg",
                            AirlineName = "Air India",
                            Blocked = false
                        },
                        new
                        {
                            AirlinesId = 2,
                            AirlineLogo = "SpiceJet.jpg",
                            AirlineName = "SpiceJet",
                            Blocked = false
                        },
                        new
                        {
                            AirlinesId = 3,
                            AirlineLogo = "IndiGo.jpg",
                            AirlineName = "IndiGo",
                            Blocked = false
                        });
                });

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

            modelBuilder.Entity("Flight_booking.Models.FlightModel", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirlinesId")
                        .HasColumnType("int");

                    b.Property<int>("BusinessClassSeatsCount")
                        .HasColumnType("int");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NonBusinessClassSeatsCount")
                        .HasColumnType("int");

                    b.Property<int>("RowsCount")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("AirlinesId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            FlightId = 1,
                            AirlinesId = 1,
                            BusinessClassSeatsCount = 20,
                            FlightNumber = "AI300",
                            InstrumentUsed = "A320Neo",
                            NonBusinessClassSeatsCount = 80,
                            RowsCount = 50
                        },
                        new
                        {
                            FlightId = 2,
                            AirlinesId = 1,
                            BusinessClassSeatsCount = 20,
                            FlightNumber = "AI301",
                            InstrumentUsed = "A320",
                            NonBusinessClassSeatsCount = 80,
                            RowsCount = 50
                        },
                        new
                        {
                            FlightId = 3,
                            AirlinesId = 2,
                            BusinessClassSeatsCount = 30,
                            FlightNumber = "SP100",
                            InstrumentUsed = "A320",
                            NonBusinessClassSeatsCount = 90,
                            RowsCount = 60
                        });
                });

            modelBuilder.Entity("Flight_booking.Models.FlightTripSchedule", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AvailableDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("FromPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsAvailable")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("costPerSeat")
                        .HasColumnType("int");

                    b.HasKey("TripId");

                    b.HasIndex("FlightId");

                    b.ToTable("FlightTrips");

                    b.HasData(
                        new
                        {
                            TripId = 2,
                            AvailableDate = new DateTime(2021, 7, 8, 13, 58, 6, 805, DateTimeKind.Local).AddTicks(3909),
                            EndDateTime = new DateTime(2021, 7, 8, 15, 58, 6, 805, DateTimeKind.Local).AddTicks(5072),
                            FlightId = 2,
                            FromPlace = "Tirupathi",
                            SeatsAvailable = 100,
                            StartDateTime = new DateTime(2021, 7, 8, 13, 58, 6, 805, DateTimeKind.Local).AddTicks(4572),
                            ToPlace = "Hyderabad",
                            costPerSeat = 0
                        });
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

                    b.Property<string>("Pnrnumber")
                        .HasColumnType("nvarchar(max)");

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
                            Pnrnumber = "123456",
                            ReturnAirlinelogo = "ssss",
                            ReturnAirlinename = "SpiceJet",
                            ReturnAmount = 2504m,
                            ReturnMealtype = "SampleMeal",
                            Selectedseatonward = "A1",
                            Selectedseatreturn = "A2",
                            Toplace = "Bangalore",
                            Totalamount = 5008m,
                            Triptype = "sampelTriptype",
                            UserEmail = "Jack.Reacher@gmail.com",
                            Userid = "1",
                            Username = "Jack",
                            bookeddate = new DateTime(2021, 7, 8, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(172),
                            numberofseats = 2,
                            onwarddate = new DateTime(2021, 7, 13, 13, 58, 6, 787, DateTimeKind.Local).AddTicks(8539),
                            returndate = new DateTime(2021, 7, 15, 13, 58, 6, 789, DateTimeKind.Local).AddTicks(2360),
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
                            Pnrnumber = "789012",
                            ReturnAirlinelogo = "ssss",
                            ReturnAirlinename = "Indigo",
                            ReturnAmount = 2504m,
                            ReturnMealtype = "SampleMeal",
                            Selectedseatonward = "B1",
                            Selectedseatreturn = "B2",
                            Toplace = "Delhi",
                            Totalamount = 5008m,
                            Triptype = "TwoWayTrip",
                            UserEmail = "Jack.Reacher2@gmail.com",
                            Userid = "2",
                            Username = "Jack2",
                            bookeddate = new DateTime(2021, 7, 8, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1189),
                            numberofseats = 1,
                            onwarddate = new DateTime(2021, 7, 13, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1172),
                            returndate = new DateTime(2021, 7, 15, 13, 58, 6, 790, DateTimeKind.Local).AddTicks(1179),
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
                            Name = "Jack",
                            Pnrnumber = 12345,
                            Usermail = "Jack.Reacher@gmail.com",
                            flightbookingid = 1,
                            mealpreference = "mealpref",
                            selectedseatnumber = "A1"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            Gender = "M",
                            Name = "J Reacher",
                            Pnrnumber = 12345,
                            Usermail = "Jack.Reacher2@gmail.com",
                            flightbookingid = 1,
                            mealpreference = "mealpref",
                            selectedseatnumber = "A2"
                        },
                        new
                        {
                            Id = 3,
                            Age = 25,
                            Gender = "M",
                            Name = "J Reacher3",
                            Pnrnumber = 789012,
                            Usermail = "Jack.Reacher3@gmail.com",
                            flightbookingid = 2,
                            mealpreference = "mealpref",
                            selectedseatnumber = "B1"
                        });
                });

            modelBuilder.Entity("Flight_booking.Models.FlightModel", b =>
                {
                    b.HasOne("Flight_booking.Models.AirlineMasterModel", "AirlineMasterModel")
                        .WithMany("Flights")
                        .HasForeignKey("AirlinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirlineMasterModel");
                });

            modelBuilder.Entity("Flight_booking.Models.FlightTripSchedule", b =>
                {
                    b.HasOne("Flight_booking.Models.FlightModel", "Flight")
                        .WithMany("FlightTripSchedules")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
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

            modelBuilder.Entity("Flight_booking.Models.AirlineMasterModel", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("Flight_booking.Models.FlightModel", b =>
                {
                    b.Navigation("FlightTripSchedules");
                });

            modelBuilder.Entity("Flight_booking.Models.Flightbookingsmodel", b =>
                {
                    b.Navigation("passengerdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
