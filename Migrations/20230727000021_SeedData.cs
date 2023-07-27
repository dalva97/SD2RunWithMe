using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RunWithMe.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[,]
                {
                    { new Guid("279df99d-26bb-48f2-bbdc-63a609691d96"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "April Fools" },
                    { new Guid("8a6138ba-89e4-4249-88d3-65c3809bfa8e"), new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fourth of July" },
                    { new Guid("edf6fdb9-86ed-4284-9085-a11370c58f6c"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christmas Day" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("279df99d-26bb-48f2-bbdc-63a609691d96"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("8a6138ba-89e4-4249-88d3-65c3809bfa8e"));

            migrationBuilder.DeleteData(
                table: "Holidays",
                keyColumn: "Id",
                keyValue: new Guid("edf6fdb9-86ed-4284-9085-a11370c58f6c"));
        }
    }
}
