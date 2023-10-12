using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FootballWarsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Club_League_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "League",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "League",
                columns: new[] { "Id", "Img_Name", "Name" },
                values: new object[,]
                {
                    { 1, "PremierImg", "Premier League" },
                    { 2, "LaligaImg", "Laliga" },
                    { 3, "SerieAImg", "Serie A" },
                    { 4, "BundesligaImg", "Bundesliga" },
                    { 5, "Ligue1Img", "Ligue 1" }
                });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "Img_Name", "LeagueId", "Name" },
                values: new object[,]
                {
                    { 1, "FCBarcelonaImg", 2, "FC Barcelona" },
                    { 2, "RealMadridImg", 2, "Real Madrid" },
                    { 3, "ManchesterCityImg", 1, "Manchester City" },
                    { 4, "ArsenalImg", 1, "Arsenal FC" },
                    { 5, "InterImg", 3, "Inter Milan" },
                    { 6, "ACMilanImg", 3, "AC Milan" },
                    { 7, "FCBayernImg", 4, "FC Bayern Munchen" },
                    { 8, "DortmundImg", 4, "Dortmund" },
                    { 9, "ParisImg", 5, "Paris" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "ClubId", "Img_Name", "Name" },
                values: new object[,]
                {
                    { 1, 1, "FrenkieImg", "Frenkie De Jong" },
                    { 2, 2, "LukaImg", "Luka Modric" },
                    { 3, 3, "ErlingImg", "Erling Haaland" },
                    { 4, 4, "MartinImg", "Martin Odergaard" },
                    { 5, 5, "LautaroImg", "Lautaro Martinez" },
                    { 6, 6, "RafaelImg", "Rafael Leao" },
                    { 7, 7, "ThomasImg", "Thomas Muller" },
                    { 8, 8, "MarcoImg", "Marco Reus" },
                    { 9, 9, "KylianImg", "Kylian Mbappe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Club_LeagueId",
                table: "Club",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ClubId",
                table: "Player",
                column: "ClubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "League");
        }
    }
}
