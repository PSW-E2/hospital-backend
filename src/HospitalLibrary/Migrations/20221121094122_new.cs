﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HospitalLibrary.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergens",
                columns: table => new
                {
                    AllergenId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergens", x => x.AllergenId);
                });

            migrationBuilder.CreateTable(
                name: "BloodRequests",
                columns: table => new
                {
                    BloodRequestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BloodType = table.Column<int>(type: "integer", nullable: false),
                    QuantityInLiters = table.Column<double>(type: "double precision", nullable: false),
                    ReasonForRequest = table.Column<string>(type: "text", nullable: true),
                    FinalDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodRequests", x => x.BloodRequestId);
                });

            migrationBuilder.CreateTable(
                name: "Bloods",
                columns: table => new
                {
                    BloodId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BloodType = table.Column<int>(type: "integer", nullable: false),
                    QuantityInLiters = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloods", x => x.BloodId);
                });

            migrationBuilder.CreateTable(
                name: "BloodUsageEvidencies",
                columns: table => new
                {
                    BloodUsageEvidencyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BloodType = table.Column<int>(type: "integer", nullable: false),
                    QuantityUsedInMililiters = table.Column<double>(type: "double precision", nullable: false),
                    ReasonForUsage = table.Column<string>(type: "text", nullable: true),
                    DateOfUsage = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodUsageEvidencies", x => x.BloodUsageEvidencyId);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Privatisation = table.Column<bool>(type: "boolean", nullable: false),
                    Textt = table.Column<string>(type: "text", nullable: true),
                    User = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<string>(type: "text", nullable: true),
                    IsDisplayedPublic = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BloodType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    IsAccountActivated = table.Column<bool>(type: "boolean", nullable: false),
                    MedicalRecord = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: false),
                    FloorId = table.Column<int>(type: "integer", nullable: false),
                    BuildingId = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    X = table.Column<int>(type: "integer", nullable: false),
                    Y = table.Column<int>(type: "integer", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    SpecializationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.SpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "AllergenMedicalRecord",
                columns: table => new
                {
                    AllergensAllergenId = table.Column<int>(type: "integer", nullable: false),
                    MedicalRecordsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergenMedicalRecord", x => new { x.AllergensAllergenId, x.MedicalRecordsId });
                    table.ForeignKey(
                        name: "FK_AllergenMedicalRecord_Allergens_AllergensAllergenId",
                        column: x => x.AllergensAllergenId,
                        principalTable: "Allergens",
                        principalColumn: "AllergenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergenMedicalRecord_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    BedId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: true),
                    RoomId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.BedId);
                    table.ForeignKey(
                        name: "FK_Beds_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    SpecializationId = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_Doctors_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Start = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: true),
                    PatientId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatient",
                columns: table => new
                {
                    DoctorsDoctorId = table.Column<int>(type: "integer", nullable: false),
                    PatientsPatientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatient", x => new { x.DoctorsDoctorId, x.PatientsPatientId });
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Doctors_DoctorsDoctorId",
                        column: x => x.DoctorsDoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Patients_PatientsPatientId",
                        column: x => x.PatientsPatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    VacationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.VacationId);
                    table.ForeignKey(
                        name: "FK_Vacations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkTimes",
                columns: table => new
                {
                    WorkTimeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTimes", x => x.WorkTimeId);
                    table.ForeignKey(
                        name: "FK_WorkTimes_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Allergens",
                columns: new[] { "AllergenId", "Name" },
                values: new object[,]
                {
                    { 1, "Peanuts" },
                    { 8, "Eggs" },
                    { 7, "Milk and/or dairy products" },
                    { 6, "Pollen" },
                    { 9, "Wheat" },
                    { 4, "Insect and mite feces" },
                    { 3, "Fungal spores" },
                    { 2, "Dust" },
                    { 5, "Insect bites and stinges (their venom)" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "BedId", "Label", "RoomId" },
                values: new object[,]
                {
                    { 1, "201B1", null },
                    { 2, "201B2", null },
                    { 3, "201B3", null }
                });

            migrationBuilder.InsertData(
                table: "BloodRequests",
                columns: new[] { "BloodRequestId", "BloodType", "DoctorId", "FinalDate", "QuantityInLiters", "ReasonForRequest" },
                values: new object[,]
                {
                    { 1, 5, 1, new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5, "Heart surgery" },
                    { 3, 7, 1, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5, "Heart surgery" },
                    { 2, 0, 1, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, "Heart surgery" }
                });

            migrationBuilder.InsertData(
                table: "BloodUsageEvidencies",
                columns: new[] { "BloodUsageEvidencyId", "BloodType", "DateOfUsage", "DoctorId", "QuantityUsedInMililiters", "ReasonForUsage" },
                values: new object[] { 1, 0, new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 200.0, "Hearth surgery" });

            migrationBuilder.InsertData(
                table: "Bloods",
                columns: new[] { "BloodId", "BloodType", "QuantityInLiters" },
                values: new object[,]
                {
                    { 7, 3, 4.0 },
                    { 8, 5, 4.0 },
                    { 5, 7, 4.0 },
                    { 4, 4, 4.0 },
                    { 3, 2, 4.0 },
                    { 2, 0, 4.0 },
                    { 1, 6, 4.0 },
                    { 6, 1, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Date", "IsDisplayedPublic", "Privatisation", "Textt", "User" },
                values: new object[,]
                {
                    { 1, "25.10.2022", false, false, "Awesome clinic!", "Милош" },
                    { 2, "25.10.2022", false, false, "It's okay... I guess.", "Немања" },
                    { 3, "25.10.2022", false, false, "Awful.", "Огњен" }
                });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "Id", "BloodType" },
                values: new object[,]
                {
                    { 9, 3 },
                    { 8, 7 },
                    { 7, 4 },
                    { 6, 1 },
                    { 2, 6 },
                    { 4, 2 },
                    { 3, 5 },
                    { 1, 0 },
                    { 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Email", "IsAccountActivated", "MedicalRecord", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { 6, "proba5@gmail.com", false, 6, "Aleksa", "123", "Aleksic" },
                    { 9, "proba8@gmail.com", false, 9, "Aleksa", "123", "Aleksic" },
                    { 7, "proba6@gmail.com", false, 7, "Pera", "123", "Peric" },
                    { 5, "proba4@gmail.com", false, 5, "Marko", "123", "Markovic" },
                    { 8, "proba7@gmail.com", false, 8, "Marko", "123", "Markovic" },
                    { 3, "proba2@gmail.com", false, 3, "Aleksa", "123", "Aleksic" },
                    { 1, "proba@gmail.com", false, 1, "Pera", "123", "Peric" },
                    { 4, "proba3@gmail.com", false, 4, "Pera", "123", "Peric" },
                    { 2, "proba1@gmail.com", false, 2, "Marko", "123", "Markovic" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BuildingId", "Description", "FloorId", "Height", "Number", "Type", "Width", "X", "Y" },
                values: new object[,]
                {
                    { 22, "B", "neki opis1", 0, 250, "107B", 0, 282, 706, 270 },
                    { 23, "B", "neki opis2", 0, 250, "108B", 0, 282, 706, 530 },
                    { 24, "B", "neki opis", 1, 250, "201B", 0, 485, 10, 10 },
                    { 25, "B", "neki opis1", 1, 250, "202B", 0, 480, 505, 10 },
                    { 26, "B", "neki opis2", 1, 250, "203B", 0, 283, 10, 270 },
                    { 27, "B", "neki opis", 1, 250, "204B", 0, 283, 10, 530 },
                    { 28, "B", "neki opis1", 1, 250, "205B", 0, 283, 358, 270 },
                    { 29, "B", "neki opis2", 1, 250, "206B", 0, 283, 358, 530 },
                    { 30, "B", "neki opis1", 1, 250, "207B", 0, 282, 706, 270 },
                    { 21, "B", "neki opis2", 0, 250, "106B", 0, 283, 358, 530 },
                    { 32, "B", "neki opis", 2, 250, "301B", 0, 485, 10, 10 },
                    { 33, "B", "neki opis1", 2, 250, "302B", 0, 480, 505, 10 },
                    { 34, "B", "neki opis2", 2, 250, "303B", 0, 283, 10, 270 },
                    { 35, "B", "neki opis", 2, 250, "304B", 0, 283, 10, 530 },
                    { 36, "B", "neki opis1", 2, 250, "305B", 0, 283, 358, 270 },
                    { 37, "B", "neki opis2", 2, 250, "306B", 0, 283, 358, 530 },
                    { 38, "B", "neki opis1", 2, 250, "307B", 0, 282, 706, 270 },
                    { 39, "B", "neki opis2", 2, 250, "308B", 0, 282, 706, 530 },
                    { 31, "B", "neki opis2", 1, 250, "208B", 0, 282, 706, 530 },
                    { 19, "B", "neki opis", 0, 250, "104B", 0, 283, 10, 530 },
                    { 18, "B", "neki opis2", 0, 250, "103B", 0, 283, 10, 270 },
                    { 1, "A", "neki opis", 0, 250, "101A", 0, 380, 10, 10 },
                    { 2, "A", "neki opis1", 0, 250, "102A", 0, 170, 10, 270 },
                    { 3, "A", "neki opis2", 0, 250, "103A", 0, 170, 10, 530 },
                    { 4, "A", "neki opis", 0, 250, "104A", 0, 170, 220, 270 },
                    { 5, "A", "neki opis1", 0, 250, "105A", 0, 170, 220, 530 },
                    { 6, "A", "neki opis3", 1, 250, "201A", 0, 380, 10, 10 },
                    { 7, "A", "neki opis4", 1, 250, "202A", 0, 170, 10, 270 },
                    { 20, "B", "neki opis1", 0, 250, "105B", 0, 283, 358, 270 },
                    { 8, "A", "neki opis5", 1, 250, "203A", 0, 170, 10, 530 },
                    { 10, "A", "neki opis5", 1, 250, "205A", 0, 170, 220, 530 },
                    { 11, "A", "neki opis6", 2, 250, "301A", 0, 380, 10, 10 },
                    { 12, "A", "neki opis7", 2, 250, "302A", 0, 170, 10, 270 },
                    { 13, "A", "neki opis8", 2, 250, "303A", 0, 170, 10, 530 },
                    { 14, "A", "neki opis7", 2, 250, "304A", 0, 170, 220, 270 },
                    { 15, "A", "neki opis8", 2, 250, "305A", 0, 170, 220, 530 },
                    { 16, "B", "neki opis", 0, 250, "101B", 0, 485, 10, 10 },
                    { 17, "B", "neki opis1", 0, 250, "102B", 0, 480, 505, 10 },
                    { 9, "A", "neki opis4", 1, 250, "204A", 0, 170, 220, 270 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "SpecializationId", "Name" },
                values: new object[,]
                {
                    { 2, "Dermatology" },
                    { 1, "Anesthesiology" },
                    { 3, "Family medicine" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "Name", "RoomId", "SpecializationId", "Surname" },
                values: new object[,]
                {
                    { 2, "Mika", 2, 1, "Mikic" },
                    { 3, "Aleksa", 1, 2, "Santic" },
                    { 1, "Ognjen", 1, 3, "Nikolic" },
                    { 4, "Nikola", 1, 3, "Peric" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "DoctorId", "PatientId", "Start" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 11, 21, 10, 41, 21, 997, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.InsertData(
                table: "Vacations",
                columns: new[] { "VacationId", "DoctorId", "EndDate", "StartDate" },
                values: new object[] { 1, 1, new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "WorkTimes",
                columns: new[] { "WorkTimeId", "DoctorId", "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[] { 1, 1, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_AllergenMedicalRecord_MedicalRecordsId",
                table: "AllergenMedicalRecord",
                column: "MedicalRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Beds_RoomId",
                table: "Beds",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_PatientsPatientId",
                table: "DoctorPatient",
                column: "PatientsPatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_RoomId",
                table: "Doctors",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecializationId",
                table: "Doctors",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Email",
                table: "Patients",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_DoctorId",
                table: "Vacations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_DoctorId",
                table: "WorkTimes",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergenMedicalRecord");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "BloodRequests");

            migrationBuilder.DropTable(
                name: "Bloods");

            migrationBuilder.DropTable(
                name: "BloodUsageEvidencies");

            migrationBuilder.DropTable(
                name: "DoctorPatient");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "WorkTimes");

            migrationBuilder.DropTable(
                name: "Allergens");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Specializations");
        }
    }
}
