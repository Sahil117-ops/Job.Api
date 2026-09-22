using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JobApplications",
                newName: "UserProfileId");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "JobApplications",
                newName: "JobPostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserProfileId",
                table: "JobApplications",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "JobPostId",
                table: "JobApplications",
                newName: "JobId");
        }
    }
}
