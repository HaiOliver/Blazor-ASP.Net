using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BCIT_ID = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Option = table.Column<string>(nullable: true),
                    Set = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BCIT_ID", "City", "Email", "FirstName", "LastName", "MobileNumber", "Option", "Set" },
                values: new object[,]
                {
                    { "a4dac49b-b167-46c3-a751-54877d70d378", "A01222222", "Vancouver", "aa@gmail.com", "Bob", "YU", "601-234-1234", "AI", "S" },
                    { "9eb10b36-abf6-40bf-9c3a-fb8fe087a271", "A02322222", "Vancouver", "bb@gmail.com", "Long", "YUI", "601-000-1234", "Mobile", "A" },
                    { "ac524377-3e66-432e-903f-260697348e6f", "A01222452", "Vancouver", "aswa@gmail.com", "Bio", "Yong", "601-234-7834", "ML", "B" },
                    { "f4bfe031-0d78-4fe2-b37a-ef4bf3e59a1f", "A01222345", "Burnaby", "aasss@gmail.com", "Kuyn", "San", "601-234-7894", "Cloud", "S" },
                    { "d990d94e-4ed7-45d9-a340-3e15d8754192", "A01222345", "Burnaby", "awewea@gmail.com", "Kuy", "Sang", "601-234-7894", "Cloud", "S" },
                    { "bff01aeb-16aa-4eb7-b8c3-e079d654228c", "A01222390", "Burnaby", "weeaa@gmail.com", "Oliver", "Huynh", "601-234-7376", "Web", "D" },
                    { "be4eabdb-05e7-4764-99e1-9d77e2edd816", "A01222754", "Surrey", "abbva@gmail.com", "Kim", "Huy", "601-234-1762", "Technical Program", "C" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
