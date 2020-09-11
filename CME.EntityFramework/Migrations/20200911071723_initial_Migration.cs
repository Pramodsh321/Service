using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CME.EntityFramework.Migrations
{
    public partial class initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResolutionTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SecurityLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResolutionTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResolutionTypes");
        }
    }
}
