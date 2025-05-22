using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Notes.API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Description", "IsVisible", "Title" },
                values: new object[,]
                {
                    { new Guid("5a02d8de-2320-4be2-a041-5629d0b44f7e"), "Milk, Eggs, Bread, Butter", true, "Shopping List" },
                    { new Guid("617f6f94-86b3-4092-8a75-2391fc6cb5fc"), "Clothes, Charger, Toothbrush, Travel documents", true, "Packing List" },
                    { new Guid("7aa0e9df-2a2d-4eaf-aaf1-6355be3cb431"), "Summarized notes from 'Deep Work' by Cal Newport.", true, "Book Summary" },
                    { new Guid("7bb08c4d-4d49-4c13-8a5b-d1c84c2b8a8f"), "Monday: Chest, Tuesday: Back, Wednesday: Legs", false, "Workout Plan" },
                    { new Guid("8f0b6fc7-cf8f-47d5-a47c-2a463c0896a1"), "AI Chatbot, Weather App, Budget Tracker", true, "Project Ideas" },
                    { new Guid("9bd5f5b1-80f5-4c5b-b8aa-ff2d90eab5f5"), "Login button not responsive on mobile devices.", true, "Bug Report" },
                    { new Guid("9f5c3a1e-8c6c-4b3a-9a29-aaa1dcb6fd01"), "Discussion points from the weekly team meeting.", true, "Meeting Notes" },
                    { new Guid("ae9b3a75-5f3b-4f08-b1e4-b8e6b7f93e35"), "Tutorial on ASP.NET Core, React intro video", false, "Ideas for YouTube" },
                    { new Guid("b95f03a4-5d90-4b0e-82eb-3d05c2c0dd61"), "Visit Spain in August. Book flights and hotels.", true, "Holiday Plans" },
                    { new Guid("c6b201a4-2b2c-42f3-a0d6-e5f8d045d281"), "Learn Docker, Read 12 books, Run a marathon.", true, "Goals for 2025" },
                    { new Guid("d4b0b244-7296-4c76-a18e-d1c3f406f3ef"), "Clean Code, The Pragmatic Programmer, Atomic Habits", false, "Reading List" },
                    { new Guid("d68fa42e-e5b7-4f0a-b2c2-0bc66e4094f9"), "Watch, Wallet, Personalized Mug", false, "Birthday Gift Ideas" },
                    { new Guid("e0d9f190-b80e-4e59-b7a7-2c46045c48f1"), "Reflections and highlights of the day.", false, "Daily Journal" },
                    { new Guid("ee682960-978d-4ea3-bdd2-7d08c999e0f7"), "Chocolate cake with extra cocoa and vanilla.", true, "Recipe Notes" },
                    { new Guid("fb1f1746-84d8-4ef3-8a33-9c7f0c0c4189"), "Submit monthly report, Check emails, Attend sync call.", true, "Work Reminders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
