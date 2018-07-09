using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MigrationsDemo.Migrations
{
    public partial class DelUserInfoKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Id","Users");
            migrationBuilder.AddColumn<Guid>("Id", "Users");
            migrationBuilder.AddPrimaryKey("PK_Users", "Users", "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Id", "Users");
            migrationBuilder.AddColumn<Guid>("Id", "Users");
            //migrationBuilder.RenameColumn(
            //    name: "UId",
            //    table: "Users",
            //    newName: "Id");
        }
    }
}
