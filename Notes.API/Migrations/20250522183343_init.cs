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
                    { new Guid("036673ed-c006-483c-a161-ca8c4db451a9"), "Success is nothing more than a few simple disciplines, practiced every day.", true, "Jim Rohn Quote 20" },
                    { new Guid("04f400d2-8432-43ad-8e97-eca79933b45d"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 33" },
                    { new Guid("04f7ed32-6fb4-4a50-9912-d398dbd1ef28"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 13" },
                    { new Guid("066652b4-bd6c-4362-82df-30e685020028"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 2" },
                    { new Guid("06b02156-f444-4e90-9838-7d804a2f839a"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 31" },
                    { new Guid("07c65d9a-026c-4b27-b9f1-9fa7b2add122"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 24" },
                    { new Guid("135fc960-13da-40f4-b05e-79f6c8094dcb"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 7" },
                    { new Guid("170371bd-4ec8-4035-a896-11ee1626b70a"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 12" },
                    { new Guid("1b9262bf-7d9e-477f-af01-c9db44c2f960"), "A great man is always willing to be little.", true, "Greatest Man Quote 13" },
                    { new Guid("1c75f9cb-5001-4be3-ab40-f838de8bd4e9"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 29" },
                    { new Guid("1f4c6ccc-a990-4ffa-96ad-b1b1b8730a0f"), "You have to build calluses on your brain just like how you build calluses on your hands. Callus your mind through pain and suffering.", true, "David Goggins Quote 10" },
                    { new Guid("225f7251-8aaa-4970-a522-0178ec821dec"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 2" },
                    { new Guid("2276a423-a094-4ed5-9255-d70cdd55d30f"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 3" },
                    { new Guid("22d746e7-2f9a-4d0b-a8b3-3f1e3196d526"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 26" },
                    { new Guid("239c67ab-ad7c-4c99-af80-10a7f8b2d5c4"), "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively.", true, "Greatest Man Quote 20" },
                    { new Guid("23ddb97f-aa6b-46ea-91bc-2ffbb07b17e6"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 14" },
                    { new Guid("2476d210-dd30-465e-983d-43ffd8723cd2"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 16" },
                    { new Guid("2a4b8247-84a0-4e9a-be19-48831cffd518"), "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively.", true, "Greatest Man Quote 15" },
                    { new Guid("2afab24b-d7ba-43a5-85b6-4904adbc1ddd"), "Success is nothing more than a few simple disciplines, practiced every day.", true, "Jim Rohn Quote 15" },
                    { new Guid("2b59ecb3-a780-4de6-838e-8d76b3b5bece"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 1" },
                    { new Guid("2cc9159d-95d2-479e-8291-8ce3289e46d6"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 2" },
                    { new Guid("2dd1482f-12c5-49d2-b2e7-115246f483d3"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 9" },
                    { new Guid("32096f26-a94c-41cc-936a-ced8200ebfcc"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 13" },
                    { new Guid("32f1b16f-e3d4-4bdf-98fd-2341bba285f9"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 6" },
                    { new Guid("33350cfd-43c4-42c7-aafe-abd7889506c1"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 23" },
                    { new Guid("34904761-6126-4e3a-a935-5d152d55dbec"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 11" },
                    { new Guid("39e126b4-6647-40b5-98d4-68eb6b4e376b"), "Either you run the day or the day runs you.", true, "Jim Rohn Quote 24" },
                    { new Guid("3d69a497-8516-4a5f-a8f4-d8d0e6edc11d"), "He who conquers himself is the mightiest warrior.", true, "Greatest Man Quote 14" },
                    { new Guid("438fd18b-77ea-4a4e-a1af-47127ad0d4f3"), "You have to build calluses on your brain just like how you build calluses on your hands. Callus your mind through pain and suffering.", true, "David Goggins Quote 30" },
                    { new Guid("43f27183-86b5-423c-9585-b2e43de41b1d"), "Either you run the day or the day runs you.", true, "Jim Rohn Quote 9" },
                    { new Guid("4401a7b6-fd52-4de5-96f0-0fe873dd9705"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 6" },
                    { new Guid("4946fa06-89a7-4dd9-be4d-5a9699ce2572"), "A great man is always willing to be little.", true, "Greatest Man Quote 8" },
                    { new Guid("4b150cd2-a36a-45e0-a8a0-f965ed0081dc"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 27" },
                    { new Guid("52820991-04d3-4651-aa83-932695b03f94"), "A great man is always willing to be little.", true, "Greatest Man Quote 33" },
                    { new Guid("55e27cba-0fb2-48ec-b9a0-ef7c26fef352"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 17" },
                    { new Guid("5791b230-c4d2-484f-8d6e-bfda2cdc4462"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 26" },
                    { new Guid("586fb7b2-7708-449e-8fc2-d07f7a88311d"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 17" },
                    { new Guid("5a20e047-c05b-458b-81ed-9880b05d9de5"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 16" },
                    { new Guid("5cb8f6ee-65fe-4557-b534-2a94a8cd6173"), "You have to build calluses on your brain just like how you build calluses on your hands. Callus your mind through pain and suffering.", true, "David Goggins Quote 15" },
                    { new Guid("5feaf154-28ba-403e-895b-1f7ccde625e2"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 21" },
                    { new Guid("60538852-f943-483b-85b6-23b5027856bc"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 28" },
                    { new Guid("60c296b0-d229-4357-aa98-917beeab5706"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 32" },
                    { new Guid("690776bf-a037-4f61-8a7a-5c2321493b8f"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 27" },
                    { new Guid("6981f253-9645-466c-9070-9a7ef8b88c19"), "You have to build calluses on your brain just like how you build calluses on your hands. Callus your mind through pain and suffering.", true, "David Goggins Quote 5" },
                    { new Guid("69f13507-0c69-4f4d-91db-5ef3153a085e"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 17" },
                    { new Guid("6d68ccaf-2081-4448-b05c-2e72bf3213c2"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 12" },
                    { new Guid("72d0abed-8270-4a31-950d-4015656089d0"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 32" },
                    { new Guid("7631dfc7-7867-47d6-80e1-8c4215621fdd"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 1" },
                    { new Guid("78bc7097-ecdd-437c-a999-15ccc7128985"), "Either you run the day or the day runs you.", true, "Jim Rohn Quote 19" },
                    { new Guid("78ec9c06-cedb-4d44-9824-81b1d7b4063b"), "Success is nothing more than a few simple disciplines, practiced every day.", true, "Jim Rohn Quote 30" },
                    { new Guid("7cc184cc-614d-47a9-b265-0a27ab201230"), "You have to build calluses on your brain just like how you build calluses on your hands. Callus your mind through pain and suffering.", true, "David Goggins Quote 25" },
                    { new Guid("7e6b7425-3167-4d75-9b57-71bfdbce3132"), "A great man is always willing to be little.", true, "Greatest Man Quote 28" },
                    { new Guid("80379d46-4aee-4b91-99be-439e5ce604b4"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 22" },
                    { new Guid("81dc52d3-3146-4303-8008-3b4c0a4c6fbd"), "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively.", true, "Greatest Man Quote 30" },
                    { new Guid("84bf6eb4-acee-427f-9088-52d52af15514"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 11" },
                    { new Guid("88a3bc4c-faa6-48c8-ba9f-0a8cd97dbcae"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 8" },
                    { new Guid("8f42ae36-25b3-4635-8350-dde3c0538e7a"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 7" },
                    { new Guid("8f7f4379-3b39-4f7f-af3b-0a52aa15d67c"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 21" },
                    { new Guid("916306a1-a715-46d6-973c-862d40b21684"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 34" },
                    { new Guid("977c8be5-16dd-463a-925b-cf40077727fb"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 18" },
                    { new Guid("97df89b6-0427-4370-95d1-50b1f8a2577a"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 23" },
                    { new Guid("98881e7c-7e90-4fb0-a2a4-366c243f9dec"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 4" },
                    { new Guid("9a666e3f-0f1c-4ab0-8d1e-4a5117192e2a"), "Discipline is the bridge between goals and accomplishment.", true, "Jim Rohn Quote 1" },
                    { new Guid("9c0e0d6c-b882-480b-80c1-7e77f6cb181c"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 12" },
                    { new Guid("9c23b61a-8fe0-413e-b359-6da30d73f81f"), "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively.", true, "Greatest Man Quote 5" },
                    { new Guid("9ed888c3-5c9c-46fa-b9e0-ebe93d0814a5"), "He who conquers himself is the mightiest warrior.", true, "Greatest Man Quote 4" },
                    { new Guid("a03a71d4-f1ad-4d0a-9a14-f31a3c3de873"), "He who conquers himself is the mightiest warrior.", true, "Greatest Man Quote 29" },
                    { new Guid("a3000b30-b3a3-4bb9-861e-b1fb10711508"), "Either you run the day or the day runs you.", true, "Jim Rohn Quote 4" },
                    { new Guid("aac6d502-00d2-4fce-9015-ba2cd128367c"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 11" },
                    { new Guid("ac890a68-1a7a-4ffc-b7bf-3075b5c89864"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 33" },
                    { new Guid("b033b593-888f-43f5-b2af-1300db291840"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 21" },
                    { new Guid("b3f35d2b-9584-453c-87e2-919e539a9fea"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 22" },
                    { new Guid("b65660e6-51f0-4514-88d2-43cdc7a4828c"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 3" },
                    { new Guid("b804ae37-9fbb-49ac-b4ba-c639e7364f7f"), "Success is nothing more than a few simple disciplines, practiced every day.", true, "Jim Rohn Quote 25" },
                    { new Guid("bb8763cc-2cf5-4763-839b-3a8e6a047ea1"), "He who conquers himself is the mightiest warrior.", true, "Greatest Man Quote 9" },
                    { new Guid("c02ef90c-943d-44d1-abce-ffbba91ac4ef"), "Success is nothing more than a few simple disciplines, practiced every day.", true, "Jim Rohn Quote 5" },
                    { new Guid("c24c9e81-0afa-4136-9a15-0b2aef104555"), "He who conquers himself is the mightiest warrior.", true, "Greatest Man Quote 19" },
                    { new Guid("c279c8af-286e-4c26-a7da-6d00d3ef6dc2"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 16" },
                    { new Guid("c2c93010-b0d4-4b86-b2f2-6ec6fb45bb8e"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 26" },
                    { new Guid("c4b51cb3-cdd2-4fbe-821c-d8799c466d27"), "You are in danger of living a life so comfortable and soft, that you will die without ever realizing your true potential.", true, "David Goggins Quote 22" },
                    { new Guid("c51bbd3b-93f3-4a1f-96a9-3fda668f8f42"), "The most important conversations you’ll ever have are the ones you’ll have with yourself.", true, "David Goggins Quote 31" },
                    { new Guid("cb91156b-3164-4c32-bb17-f5d9e0a3383d"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 6" },
                    { new Guid("cebfc0cc-528d-45fc-92dd-17c6216e0ec1"), "A great man is always willing to be little.", true, "Greatest Man Quote 3" },
                    { new Guid("cf081b92-6e15-463c-8862-14846486e2e1"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 32" },
                    { new Guid("d38a2ff6-607f-4448-a79a-1335239a9369"), "Either you run the day or the day runs you.", true, "Jim Rohn Quote 14" },
                    { new Guid("de053f28-9718-4aca-b976-4ce3bcda64a7"), "A great man is always willing to be little.", true, "Greatest Man Quote 18" },
                    { new Guid("e77a5ed1-281b-4cac-b8f0-bd6c8ac1901a"), "True greatness is not in what you have, but in what you give.", true, "Greatest Man Quote 27" },
                    { new Guid("e94ec0fb-2201-4e96-8306-b659b64a7cfb"), "A great man is always willing to be little.", true, "Greatest Man Quote 23" },
                    { new Guid("ea171852-1f69-4f7d-8770-46d2afae2398"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 18" },
                    { new Guid("ea7207f3-6d1c-4b57-8363-6617681793ed"), "Either you run the day or the day runs you.", true, "Jim Rohn Quote 29" },
                    { new Guid("eab41790-d785-4536-ae38-a6ad5fdeefcd"), "Don't wish it were easier, wish you were better.", true, "Jim Rohn Quote 7" },
                    { new Guid("f39924a6-e497-4539-941d-f958e6bfbacf"), "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively.", true, "Greatest Man Quote 10" },
                    { new Guid("f4ae8ae8-c533-4666-ba31-a5ed36898b85"), "He who conquers himself is the mightiest warrior.", true, "Greatest Man Quote 24" },
                    { new Guid("f674249f-756b-4a9e-a7fa-338899789ac6"), "You have to build calluses on your brain just like how you build calluses on your hands. Callus your mind through pain and suffering.", true, "David Goggins Quote 20" },
                    { new Guid("f957b06c-b06e-4c65-9e8a-d2dbe55ea394"), "Success is nothing more than a few simple disciplines, practiced every day.", true, "Jim Rohn Quote 10" },
                    { new Guid("faacedad-94ed-4f53-8312-24607e15c492"), "The greatness of a man is not in how much wealth he acquires, but in his integrity and his ability to affect those around him positively.", true, "Greatest Man Quote 25" },
                    { new Guid("fb63a756-642a-4a2a-9524-58ee124dd061"), "Motivation is what gets you started. Habit is what keeps you going.", true, "Jim Rohn Quote 28" },
                    { new Guid("fbd2429f-d68d-4d59-b14f-e9287af51afc"), "The only way we can change is to be real with ourselves.", true, "David Goggins Quote 8" },
                    { new Guid("fd1350b3-4a6e-4f05-9025-b772952f5c02"), "Suffering is a test. That’s all it is. Suffering is the true test of life.", true, "David Goggins Quote 19" },
                    { new Guid("fdd3cd4e-aad9-4873-9ecc-4cbeb363041b"), "Greatness lies not in being strong, but in the right use of strength.", true, "Greatest Man Quote 31" }
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
