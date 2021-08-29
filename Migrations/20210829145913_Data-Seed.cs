using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleDatabaseConnector.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Prinz Linacre" },
                    { 2, "Karol Branford" },
                    { 3, "Elga Ross" },
                    { 4, "Ericka Fawdery" },
                    { 5, "Mahmud Threadgould" },
                    { 6, "Nanete Marwood" },
                    { 7, "Emmaline Drews" },
                    { 8, "Susan Downse" },
                    { 9, "Wilmar Nehl" },
                    { 10, "Jo ann Troubridge" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "Category", "DatePublished", "Popularity", "Title" },
                values: new object[,]
                {
                    { new Guid("e257513f-7336-4a7e-962d-692f2de2c29f"), 1, "News", new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Proin interdum mauris non ligula pellentesque ultrices." },
                    { new Guid("f855209b-2268-4984-8a40-f90bf5db9e06"), 6, "Style", new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue." },
                    { new Guid("29635df6-a1bc-48f7-a40e-a20d025d2be9"), 7, "Entertainment", new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Donec ut dolor." },
                    { new Guid("c183d7e1-afd2-4ca9-be2d-2de2f633e47f"), 7, "Religion", new DateTime(2020, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit." },
                    { new Guid("5a0b087b-4b17-449a-b15c-9820329c2dda"), 7, "Sex", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Curabitur gravida nisi at nibh." },
                    { new Guid("5a613a14-8989-403d-b87c-4c1d39172712"), 7, "Style", new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem." },
                    { new Guid("334ea2ac-e701-43c5-9d68-b957f9538545"), 7, "Sports", new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, "Nulla suscipit ligula in lacus." },
                    { new Guid("e5d93925-60b4-476a-8414-908b2a6320d6"), 7, "Sports", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, "Proin eu mi." },
                    { new Guid("5a1a6e4c-2acd-4d1b-a19e-65f8dbc8a219"), 7, "Style", new DateTime(2020, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Proin at turpis a pede posuere nonummy." },
                    { new Guid("1cb17245-c17a-4f0c-b655-fde3cd83584d"), 8, "News", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, "Quisque id justo sit amet sapien dignissim vestibulum." },
                    { new Guid("961c5eea-6e93-455e-9faa-57872b0b45c8"), 8, "News", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Nulla ut erat id mauris vulputate elementum." },
                    { new Guid("6ae75438-4b1d-4989-9ef6-a827baac4930"), 8, "Sports", new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "In sagittis dui vel nisl." },
                    { new Guid("9536bf6f-2043-4adf-934c-a548f3956feb"), 8, "News", new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, "In est risus, auctor sed, tristique in, tempus sit amet, sem." },
                    { new Guid("2a803f30-4635-40c9-a463-dbc09500bbe1"), 6, "Style", new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, "Duis mattis egestas metus." },
                    { new Guid("efc825df-d8ec-4ec3-b540-05e973277df2"), 8, "Sex", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, "Proin eu mi." },
                    { new Guid("1d0bd269-da9b-4343-9d4e-da9b67f2fdb0"), 9, "Religion", new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam." },
                    { new Guid("a375a55c-142e-4c09-9c39-15961c8684b7"), 9, "News", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, "Vivamus vestibulum sagittis sapien." },
                    { new Guid("340e462c-db42-427c-b78d-76bf0c687440"), 9, "Religion", new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, "Praesent blandit lacinia erat." },
                    { new Guid("b0346fc4-4215-4461-883a-1c9812177b5e"), 9, "Sports", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem." },
                    { new Guid("b22d2d99-3983-4833-a6ec-4e4399ae020b"), 9, "Style", new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo." },
                    { new Guid("651ef77c-9381-4d91-9b99-3a24c67949f2"), 9, "Sports", new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, "In quis justo." },
                    { new Guid("50d8d1d7-65f3-4d65-9f36-d16dde6ee110"), 9, "Sports", new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "Pellentesque eget nunc." },
                    { new Guid("ec964392-e77c-4656-ab58-ce93624978e7"), 9, "Religion", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla." },
                    { new Guid("656b25a3-16db-42cc-a682-3110997c2ca5"), 9, "Sports", new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit." },
                    { new Guid("8e86339e-c0ea-48c2-a8e3-4322db832482"), 9, "Religion", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, "Morbi vel lectus in quam fringilla rhoncus." },
                    { new Guid("5cc04767-6613-45b5-8194-16be334a5fee"), 9, "Sex", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, "Quisque id justo sit amet sapien dignissim vestibulum." },
                    { new Guid("7be5d7f6-63ec-4b21-a78c-7eb6d75833c9"), 10, "Sports", new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Sed sagittis." },
                    { new Guid("f891e64d-32b6-44ce-a75f-19594af461cb"), 8, "Style", new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "Praesent lectus." },
                    { new Guid("a1101e28-0163-4fc6-ad18-2c797d94e792"), 10, "Sports", new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, "Vivamus tortor." },
                    { new Guid("773d30d3-be84-4d88-bcc1-1fc7e2563e8c"), 6, "Sports", new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo." },
                    { new Guid("fbcd0e8f-c072-4c3d-88ac-9f33317bd7c2"), 5, "Entertainment", new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Ut tellus." },
                    { new Guid("1d477e94-e22b-4967-95c6-e94d61618b02"), 1, "Entertainment", new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Maecenas tincidunt lacus at velit." },
                    { new Guid("9eb1fdba-fd56-4b07-892a-3281bf830e2f"), 1, "Entertainment", new DateTime(2020, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Nulla tempus." },
                    { new Guid("bd39f1a9-ef56-484c-8443-3f3ba3087ff4"), 1, "News", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, "Duis aliquam convallis nunc." },
                    { new Guid("d73cfb87-b28c-4888-9a44-35a27758fc4a"), 1, "Sports", new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, "Sed ante." },
                    { new Guid("4470ec76-29f8-4001-acf6-0e04dba01127"), 1, "Entertainment", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, "Curabitur at ipsum ac tellus semper interdum." },
                    { new Guid("5d052b97-53d2-43f3-8bbf-3d64aaaab5c9"), 2, "Religion", new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, "Mauris sit amet eros." },
                    { new Guid("4781fbfa-f120-4c9f-a40f-03767e64500f"), 2, "Sports", new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Maecenas pulvinar lobortis est." },
                    { new Guid("754165ca-fc19-412d-8fc4-8499e773fc29"), 2, "Sex", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, "Vivamus tortor." },
                    { new Guid("f46f2691-ce98-4e6b-986f-5076e7369c7c"), 3, "Sports", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, "Morbi non lectus." },
                    { new Guid("8f8c649b-201e-4715-bf71-f0a44450290b"), 3, "Sex", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, "Morbi ut odio." },
                    { new Guid("49d471c2-85ad-4b5b-90b1-156c5d6811e9"), 3, "News", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, "Duis consequat dui nec nisi volutpat eleifend." }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "Category", "DatePublished", "Popularity", "Title" },
                values: new object[,]
                {
                    { new Guid("3a44435b-caad-405a-a89d-9983822c88b3"), 4, "Sex", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Praesent lectus." },
                    { new Guid("47c7adb1-1272-4c14-9dd7-cf0024908b06"), 6, "Religion", new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Aliquam erat volutpat." },
                    { new Guid("602bacae-6323-4d51-95ed-02ebdf574ad0"), 4, "Entertainment", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sed sagittis." },
                    { new Guid("d7790170-d5fa-4ac6-acba-670f9b157d7f"), 4, "Sports", new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Integer tincidunt ante vel ipsum." },
                    { new Guid("7f0c6203-8727-4a0a-9419-b05dec681a19"), 4, "Entertainment", new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, "Suspendisse potenti." },
                    { new Guid("7423f6db-c807-4bc7-ad47-633f47e32f8a"), 4, "Style", new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, "Morbi porttitor lorem id ligula." },
                    { new Guid("8a69d105-c700-44bb-b893-3aeef5dd428c"), 4, "News", new DateTime(2020, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem." },
                    { new Guid("973ba922-bd22-4d48-a8d2-fcf572ed3b4b"), 4, "Religion", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl." },
                    { new Guid("c0627ec7-b75e-4990-aa18-43646f97c2ea"), 4, "News", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, "Praesent blandit." },
                    { new Guid("140eb5b5-2791-4916-a96f-282cffaeb99d"), 4, "Style", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Phasellus id sapien in sapien iaculis congue." },
                    { new Guid("9b68e86c-a0ef-4060-b0e3-4d23fe5e6df7"), 5, "Entertainment", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morbi a ipsum." },
                    { new Guid("83b2f6c5-4240-46cd-b3c9-80a48a964059"), 5, "Entertainment", new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Praesent blandit lacinia erat." },
                    { new Guid("eb8d6755-c5df-4c2e-a0d6-3cf040a0049e"), 5, "Entertainment", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, "Curabitur gravida nisi at nibh." },
                    { new Guid("5ea93e35-3fa0-4418-b22b-d53442bab6b5"), 5, "Style", new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, "Suspendisse potenti." },
                    { new Guid("994ebaf2-3c1a-46a9-815a-a2a4f7d08e3d"), 5, "Religion", new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla." },
                    { new Guid("aa798188-b1c3-4300-974b-7fe9c3584988"), 4, "Sports", new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, "Duis at velit eu est congue elementum." },
                    { new Guid("13eecd61-11f2-4586-8d99-5d55ae1f64da"), 10, "Entertainment", new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "In hac habitasse platea dictumst." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("13eecd61-11f2-4586-8d99-5d55ae1f64da"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("140eb5b5-2791-4916-a96f-282cffaeb99d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1cb17245-c17a-4f0c-b655-fde3cd83584d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1d0bd269-da9b-4343-9d4e-da9b67f2fdb0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1d477e94-e22b-4967-95c6-e94d61618b02"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("29635df6-a1bc-48f7-a40e-a20d025d2be9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2a803f30-4635-40c9-a463-dbc09500bbe1"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("334ea2ac-e701-43c5-9d68-b957f9538545"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("340e462c-db42-427c-b78d-76bf0c687440"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3a44435b-caad-405a-a89d-9983822c88b3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4470ec76-29f8-4001-acf6-0e04dba01127"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4781fbfa-f120-4c9f-a40f-03767e64500f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("47c7adb1-1272-4c14-9dd7-cf0024908b06"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("49d471c2-85ad-4b5b-90b1-156c5d6811e9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50d8d1d7-65f3-4d65-9f36-d16dde6ee110"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a0b087b-4b17-449a-b15c-9820329c2dda"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a1a6e4c-2acd-4d1b-a19e-65f8dbc8a219"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a613a14-8989-403d-b87c-4c1d39172712"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5cc04767-6613-45b5-8194-16be334a5fee"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5d052b97-53d2-43f3-8bbf-3d64aaaab5c9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5ea93e35-3fa0-4418-b22b-d53442bab6b5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("602bacae-6323-4d51-95ed-02ebdf574ad0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("651ef77c-9381-4d91-9b99-3a24c67949f2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("656b25a3-16db-42cc-a682-3110997c2ca5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6ae75438-4b1d-4989-9ef6-a827baac4930"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7423f6db-c807-4bc7-ad47-633f47e32f8a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("754165ca-fc19-412d-8fc4-8499e773fc29"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("773d30d3-be84-4d88-bcc1-1fc7e2563e8c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7be5d7f6-63ec-4b21-a78c-7eb6d75833c9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7f0c6203-8727-4a0a-9419-b05dec681a19"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("83b2f6c5-4240-46cd-b3c9-80a48a964059"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8a69d105-c700-44bb-b893-3aeef5dd428c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8e86339e-c0ea-48c2-a8e3-4322db832482"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8f8c649b-201e-4715-bf71-f0a44450290b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9536bf6f-2043-4adf-934c-a548f3956feb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("961c5eea-6e93-455e-9faa-57872b0b45c8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("973ba922-bd22-4d48-a8d2-fcf572ed3b4b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("994ebaf2-3c1a-46a9-815a-a2a4f7d08e3d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9b68e86c-a0ef-4060-b0e3-4d23fe5e6df7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9eb1fdba-fd56-4b07-892a-3281bf830e2f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a1101e28-0163-4fc6-ad18-2c797d94e792"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a375a55c-142e-4c09-9c39-15961c8684b7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("aa798188-b1c3-4300-974b-7fe9c3584988"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b0346fc4-4215-4461-883a-1c9812177b5e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b22d2d99-3983-4833-a6ec-4e4399ae020b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bd39f1a9-ef56-484c-8443-3f3ba3087ff4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c0627ec7-b75e-4990-aa18-43646f97c2ea"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c183d7e1-afd2-4ca9-be2d-2de2f633e47f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d73cfb87-b28c-4888-9a44-35a27758fc4a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d7790170-d5fa-4ac6-acba-670f9b157d7f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e257513f-7336-4a7e-962d-692f2de2c29f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e5d93925-60b4-476a-8414-908b2a6320d6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("eb8d6755-c5df-4c2e-a0d6-3cf040a0049e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ec964392-e77c-4656-ab58-ce93624978e7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("efc825df-d8ec-4ec3-b540-05e973277df2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f46f2691-ce98-4e6b-986f-5076e7369c7c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f855209b-2268-4984-8a40-f90bf5db9e06"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f891e64d-32b6-44ce-a75f-19594af461cb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fbcd0e8f-c072-4c3d-88ac-9f33317bd7c2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
