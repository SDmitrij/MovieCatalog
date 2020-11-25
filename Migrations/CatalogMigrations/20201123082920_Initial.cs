using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCatalog.Migrations.CatalogMigrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ProducedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Producer = table.Column<string>(type: "TEXT", nullable: true),
                    Poster = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 1, "Odit omnis ipsum placeat nisi corrupti.\nPlaceat magnam aspernatur neque assumenda accusamus sit optio sint.\nMollitia corrupti dolor consequatur ut aut exercitationem consequatur illo.\nSoluta hic similique est voluptatibus aut sint et sed.\nLaborum quia ratione tenetur enim.\nLaboriosam enim ut sed vero aperiam earum ducimus nostrum perferendis.", "eos-quis-rerum", "https://picsum.photos/640/480/?image=810", new DateTime(2020, 3, 19, 3, 45, 7, 572, DateTimeKind.Local).AddTicks(1953), "Beier Rolando", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 28, "Soluta est autem magni nihil eos illum.\nAut laboriosam et quis odio ea soluta cumque aspernatur.\nAssumenda assumenda quisquam dolores.\nConsectetur aut itaque alias.\nPerspiciatis veniam dolores dolor beatae possimus.", "deserunt-earum-veniam", "https://picsum.photos/640/480/?image=127", new DateTime(2020, 6, 24, 19, 14, 7, 889, DateTimeKind.Local).AddTicks(2202), "Cronin Roberto", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 29, "pariatur", "cupiditate-doloremque-quo", "https://picsum.photos/640/480/?image=1053", new DateTime(2020, 3, 20, 5, 43, 54, 226, DateTimeKind.Local).AddTicks(2732), "Bins Jaydon", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 30, "Voluptas at sit rerum animi sed voluptas eos iusto. Mollitia quia eos nostrum. Earum occaecati et voluptatibus dolorum id non et.", "porro-ut-necessitatibus", "https://picsum.photos/640/480/?image=575", new DateTime(2020, 3, 31, 13, 50, 6, 966, DateTimeKind.Local).AddTicks(5998), "Klocko Blair", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 31, "Voluptates ut ut incidunt occaecati ut repellat omnis ipsum in.\nMagnam rem recusandae amet quis est quo voluptatem et.\nDolores voluptates ut sed sit atque officia.\nSunt nostrum in nesciunt non tempora inventore repellendus quo.", "ut-quis-ratione", "https://picsum.photos/640/480/?image=933", new DateTime(2020, 11, 23, 8, 43, 55, 735, DateTimeKind.Local).AddTicks(5367), "Nader Willow", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 32, "Amet nisi soluta sint et harum sunt deleniti omnis quia.", "error-provident-maxime", "https://picsum.photos/640/480/?image=815", new DateTime(2020, 3, 25, 5, 56, 54, 16, DateTimeKind.Local).AddTicks(4562), "Powlowski Ethyl", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 33, "ullam", "voluptate-sapiente-animi", "https://picsum.photos/640/480/?image=142", new DateTime(2020, 10, 20, 5, 45, 52, 589, DateTimeKind.Local).AddTicks(7935), "Gislason Meaghan", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 34, "Expedita similique vel quos qui velit exercitationem dolore fugit illo.", "quas-inventore-quo", "https://picsum.photos/640/480/?image=790", new DateTime(2020, 1, 13, 20, 2, 23, 143, DateTimeKind.Local).AddTicks(8710), "Welch Kyla", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 35, "nam", "qui-minus-sed", "https://picsum.photos/640/480/?image=1048", new DateTime(2020, 1, 6, 1, 42, 49, 812, DateTimeKind.Local).AddTicks(8968), "Marvin Spencer", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 36, "Dolor blanditiis porro labore.\nDolorem quia rerum ipsum omnis dolores blanditiis neque.\nPerspiciatis magnam ex molestias sed magnam in eum ipsa.\nExcepturi nemo possimus.", "nihil-ducimus-corporis", "https://picsum.photos/640/480/?image=911", new DateTime(2020, 4, 16, 20, 9, 39, 928, DateTimeKind.Local).AddTicks(898), "Williamson Alvina", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 37, "Nihil saepe et dolore. Rerum laudantium non molestiae velit ab nihil quia explicabo. Amet tempora vel autem esse libero qui eum et. Maiores consequuntur quo expedita quidem quia voluptates. Odit est laborum et consequatur laborum iusto in cupiditate vitae.", "deleniti-illum-eaque", "https://picsum.photos/640/480/?image=851", new DateTime(2019, 12, 31, 8, 27, 21, 245, DateTimeKind.Local).AddTicks(5725), "Quitzon Chet", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 38, "Sit voluptatum aut excepturi.\nFacilis et qui placeat officiis temporibus quis eos voluptatum.\nDignissimos dolor iste.", "tenetur-quae-exercitationem", "https://picsum.photos/640/480/?image=911", new DateTime(2020, 9, 2, 21, 33, 9, 403, DateTimeKind.Local).AddTicks(1495), "Dooley Florence", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 39, "Sed quia libero ea ab eveniet.", "ratione-facilis-atque", "https://picsum.photos/640/480/?image=732", new DateTime(2020, 2, 16, 1, 38, 58, 669, DateTimeKind.Local).AddTicks(5349), "Runolfsson Lora", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 40, "Est exercitationem est similique nihil porro excepturi et quod. Accusantium repellendus laboriosam voluptas voluptas. Deleniti eius animi. Vitae excepturi quod iure quis impedit et assumenda. Omnis eos reprehenderit.", "aut-autem-commodi", "https://picsum.photos/640/480/?image=379", new DateTime(2020, 2, 26, 15, 3, 26, 178, DateTimeKind.Local).AddTicks(7605), "Ankunding Jerome", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 41, "Et dolorum soluta officiis maiores nihil corporis ut.", "debitis-temporibus-porro", "https://picsum.photos/640/480/?image=230", new DateTime(2020, 10, 27, 21, 25, 26, 8, DateTimeKind.Local).AddTicks(6786), "Haley Bryce", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 42, "Asperiores quis quod temporibus.\nQuas quidem quae voluptas fugiat reiciendis voluptatem est quas fugit.\nVeniam saepe inventore sint iure quis magni quam consequatur ducimus.", "ut-maxime-eos", "https://picsum.photos/640/480/?image=292", new DateTime(2020, 3, 5, 14, 19, 10, 49, DateTimeKind.Local).AddTicks(7237), "Daugherty Odie", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 43, "Et perferendis rerum dolor.\nEarum aspernatur rem consequatur.\nFuga rerum aspernatur maiores laudantium et et nihil vel impedit.\nVoluptatem dolor provident temporibus.\nAd inventore voluptatum amet quos aspernatur.", "ea-autem-expedita", "https://picsum.photos/640/480/?image=291", new DateTime(2020, 2, 11, 16, 36, 53, 596, DateTimeKind.Local).AddTicks(4323), "Von Anika", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 44, "Distinctio illo dicta qui.", "magnam-aut-ad", "https://picsum.photos/640/480/?image=875", new DateTime(2020, 10, 25, 16, 50, 19, 642, DateTimeKind.Local).AddTicks(8049), "Bode Otha", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 45, "Animi incidunt aut. Repellendus nam eaque repellat dolor molestiae. Vero dolor et adipisci doloribus dolorum molestiae.", "fugit-exercitationem-tenetur", "https://picsum.photos/640/480/?image=288", new DateTime(2020, 7, 11, 17, 16, 54, 760, DateTimeKind.Local).AddTicks(9402), "Ledner Jeromy", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 46, "Magnam ea saepe ut quia assumenda.", "optio-impedit-impedit", "https://picsum.photos/640/480/?image=155", new DateTime(2020, 1, 8, 9, 0, 25, 258, DateTimeKind.Local).AddTicks(7466), "Kohler Alia", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 47, "nam", "corrupti-quos-dolor", "https://picsum.photos/640/480/?image=238", new DateTime(2020, 1, 8, 13, 57, 11, 684, DateTimeKind.Local).AddTicks(3257), "O'Kon Elias", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 48, "tempore", "ut-vero-laborum", "https://picsum.photos/640/480/?image=592", new DateTime(2020, 5, 14, 21, 55, 52, 925, DateTimeKind.Local).AddTicks(7422), "Jaskolski Jeffery", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 27, "asperiores", "et-debitis-minus", "https://picsum.photos/640/480/?image=994", new DateTime(2020, 1, 16, 16, 10, 5, 680, DateTimeKind.Local).AddTicks(5674), "Jenkins Antwon", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 26, "recusandae", "nihil-nobis-sit", "https://picsum.photos/640/480/?image=970", new DateTime(2020, 4, 7, 15, 16, 59, 149, DateTimeKind.Local).AddTicks(2197), "Friesen Daphney", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 25, "Quam animi incidunt voluptatem amet et aliquid beatae.", "et-sit-ut", "https://picsum.photos/640/480/?image=450", new DateTime(2020, 8, 6, 18, 43, 6, 986, DateTimeKind.Local).AddTicks(191), "Conn Danny", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 24, "facere", "itaque-fugit-repudiandae", "https://picsum.photos/640/480/?image=491", new DateTime(2020, 7, 19, 8, 48, 50, 295, DateTimeKind.Local).AddTicks(3916), "Bednar Olga", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 2, "Nobis ducimus dolor quibusdam hic explicabo in nam tempora.\nLaboriosam modi illo quia laudantium voluptatibus.", "officiis-quod-quis", "https://picsum.photos/640/480/?image=699", new DateTime(2020, 10, 16, 22, 10, 25, 546, DateTimeKind.Local).AddTicks(9494), "Stanton Agustin", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 3, "Vitae quis vel officiis fugiat provident vel molestias quaerat. Dolores odit magnam omnis blanditiis ad eius illum tempore blanditiis. Sint veniam necessitatibus. Odio mollitia dolores autem error sunt numquam quas.", "consequatur-sed-ea", "https://picsum.photos/640/480/?image=307", new DateTime(2020, 10, 20, 15, 58, 36, 975, DateTimeKind.Local).AddTicks(8322), "Anderson Constance", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 4, "Veritatis sunt pariatur asperiores mollitia aliquam amet.", "ex-rerum-consequatur", "https://picsum.photos/640/480/?image=319", new DateTime(2020, 2, 29, 13, 33, 9, 363, DateTimeKind.Local).AddTicks(8579), "Turcotte Kane", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 5, "corrupti", "fugiat-at-similique", "https://picsum.photos/640/480/?image=344", new DateTime(2020, 8, 29, 14, 27, 22, 529, DateTimeKind.Local).AddTicks(7691), "Huels Tremaine", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 6, "Placeat magnam asperiores et. Et quae praesentium qui. Ipsa facilis voluptas laboriosam nemo veritatis distinctio unde. Libero labore dignissimos fugit autem sed dolore officiis explicabo eum. Est non reprehenderit iusto molestias.", "porro-optio-et", "https://picsum.photos/640/480/?image=394", new DateTime(2019, 12, 17, 2, 15, 12, 321, DateTimeKind.Local).AddTicks(3837), "Ritchie Alfreda", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 7, "vel", "et-temporibus-qui", "https://picsum.photos/640/480/?image=645", new DateTime(2020, 6, 12, 10, 36, 20, 82, DateTimeKind.Local).AddTicks(3544), "McLaughlin Kathlyn", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 8, "Recusandae et corporis.", "aut-expedita-aperiam", "https://picsum.photos/640/480/?image=1011", new DateTime(2020, 10, 4, 20, 53, 29, 23, DateTimeKind.Local).AddTicks(1131), "Donnelly Nathan", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 9, "itaque", "doloribus-hic-et", "https://picsum.photos/640/480/?image=904", new DateTime(2020, 10, 13, 20, 11, 25, 500, DateTimeKind.Local).AddTicks(6554), "Funk Gunner", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 10, "corrupti", "quis-voluptatem-fuga", "https://picsum.photos/640/480/?image=800", new DateTime(2020, 1, 7, 0, 5, 53, 224, DateTimeKind.Local).AddTicks(9307), "Spinka Eryn", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 11, "Quia sit occaecati.", "ut-non-optio", "https://picsum.photos/640/480/?image=220", new DateTime(2019, 12, 19, 0, 1, 40, 972, DateTimeKind.Local).AddTicks(8756), "Klocko Jordyn", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 49, "Temporibus quidem quis necessitatibus.\nSunt nemo praesentium sequi.\nMagni recusandae officia autem fugiat reprehenderit eaque velit corrupti.\nHarum quidem incidunt eius perferendis sint.", "sit-sed-in", "https://picsum.photos/640/480/?image=544", new DateTime(2020, 8, 12, 19, 1, 32, 387, DateTimeKind.Local).AddTicks(9237), "Harber Brendan", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 12, "Voluptas assumenda doloremque odio suscipit laboriosam.", "et-ut-nostrum", "https://picsum.photos/640/480/?image=363", new DateTime(2020, 10, 1, 8, 27, 47, 749, DateTimeKind.Local).AddTicks(6866), "Rowe Louie", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 14, "Quam sit quibusdam necessitatibus harum sunt dolor suscipit facere.", "ut-quo-et", "https://picsum.photos/640/480/?image=328", new DateTime(2020, 11, 5, 18, 45, 46, 904, DateTimeKind.Local).AddTicks(1087), "Batz April", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 15, "Quo et qui quam in iusto.\nEa est architecto adipisci.\nAut enim ad voluptatem sequi ut aliquam magni.\nIste architecto ipsam.", "exercitationem-aut-consectetur", "https://picsum.photos/640/480/?image=726", new DateTime(2020, 6, 6, 16, 57, 6, 353, DateTimeKind.Local).AddTicks(6928), "Auer Abraham", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 16, "Et eum ut omnis qui qui.\nIpsum sunt quaerat natus quia et.", "aut-nulla-accusantium", "https://picsum.photos/640/480/?image=924", new DateTime(2020, 2, 18, 17, 52, 29, 400, DateTimeKind.Local).AddTicks(2945), "Barrows Dovie", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 17, "Pariatur eos tenetur vel et.", "est-exercitationem-iure", "https://picsum.photos/640/480/?image=55", new DateTime(2020, 5, 2, 3, 33, 24, 882, DateTimeKind.Local).AddTicks(6776), "Gutkowski Rosalyn", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 18, "Qui ratione et.\nSaepe laudantium illum facere qui tenetur et rerum.\nAsperiores autem reprehenderit consequatur aperiam suscipit voluptatibus fugiat consequatur.\nVoluptatem quo accusamus.", "molestias-non-iste", "https://picsum.photos/640/480/?image=859", new DateTime(2020, 8, 25, 14, 23, 32, 500, DateTimeKind.Local).AddTicks(1790), "DuBuque Amber", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 19, "praesentium", "molestias-et-qui", "https://picsum.photos/640/480/?image=533", new DateTime(2020, 5, 22, 22, 17, 13, 23, DateTimeKind.Local).AddTicks(6163), "Kulas Madie", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 20, "Sint voluptatum at tempore. Quisquam cupiditate commodi. Eius qui magni dolor saepe voluptatem. Est nihil aliquid dignissimos.", "illum-doloremque-eum", "https://picsum.photos/640/480/?image=579", new DateTime(2020, 9, 19, 2, 3, 25, 588, DateTimeKind.Local).AddTicks(3188), "Beer Laverne", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 21, "Qui repellat officia quo sint qui reprehenderit provident recusandae quasi.\nNihil sed aut officiis autem quo voluptas totam mollitia quam.\nLaudantium maiores consequatur eos debitis voluptatem et eius.\nVoluptatibus nulla excepturi voluptas officia ut earum.", "officiis-ut-sequi", "https://picsum.photos/640/480/?image=84", new DateTime(2019, 12, 3, 14, 41, 6, 84, DateTimeKind.Local).AddTicks(9305), "Murazik Reynold", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 22, "Officia distinctio dolores amet reprehenderit quasi et provident est sed.", "assumenda-minima-praesentium", "https://picsum.photos/640/480/?image=561", new DateTime(2020, 4, 16, 20, 29, 48, 258, DateTimeKind.Local).AddTicks(8564), "Simonis Andres", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 23, "Est et veniam fugiat assumenda autem voluptas assumenda nisi.\nSit non provident et quis distinctio nemo doloremque quia voluptates.", "architecto-qui-porro", "https://picsum.photos/640/480/?image=59", new DateTime(2019, 12, 21, 2, 37, 16, 531, DateTimeKind.Local).AddTicks(4826), "Wuckert Zaria", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 13, "beatae", "voluptate-et-excepturi", "https://picsum.photos/640/480/?image=234", new DateTime(2019, 12, 3, 12, 38, 6, 840, DateTimeKind.Local).AddTicks(3614), "Jacobi Royal", "2de669e9-5643-4695-8189-aa5a589d9a70" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Poster", "ProducedDate", "Producer", "UserId" },
                values: new object[] { 50, "Qui voluptas aspernatur.\nMollitia in praesentium minima.\nDeserunt qui fugit quo earum dolores doloribus.", "quod-consequatur-dicta", "https://picsum.photos/640/480/?image=164", new DateTime(2020, 9, 14, 2, 14, 4, 436, DateTimeKind.Local).AddTicks(6038), "Watsica Kali", "2de669e9-5643-4695-8189-aa5a589d9a70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
