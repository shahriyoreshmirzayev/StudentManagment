using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StudentManagment.Migrations
{
    /// <inheritdoc />
    public partial class BookIssuance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookIssuanceHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookIssuanceHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookIssuanceHistory_SystemCodeDetails_ClassId",
                        column: x => x.ClassId,
                        principalTable: "SystemCodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
           
            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_BookId",
                table: "BookIssuanceHistory",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_ClassId",
                table: "BookIssuanceHistory",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssuanceHistory_StudentId",
                table: "BookIssuanceHistory",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookIssuanceHistory");
        }
    }
}
