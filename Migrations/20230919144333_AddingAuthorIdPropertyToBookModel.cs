﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTOs.Migrations
{
    /// <inheritdoc />
    public partial class AddingAuthorIdPropertyToBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");
        }
    }
}