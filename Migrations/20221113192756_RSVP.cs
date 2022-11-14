using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulldogsPortal.Migrations
{
    /// <inheritdoc />
    public partial class RSVP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RSVPs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Callsign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Airframe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Confirm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSVPs");
        }
    }
}
