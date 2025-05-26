using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notes.API.Migrations
{
    /// <inheritdoc />
    public partial class favoritearchiece : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchieved",
                table: "Notes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "Notes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("036673ed-c006-483c-a161-ca8c4db451a9"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("04f400d2-8432-43ad-8e97-eca79933b45d"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("04f7ed32-6fb4-4a50-9912-d398dbd1ef28"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("066652b4-bd6c-4362-82df-30e685020028"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("06b02156-f444-4e90-9838-7d804a2f839a"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("07c65d9a-026c-4b27-b9f1-9fa7b2add122"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("135fc960-13da-40f4-b05e-79f6c8094dcb"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("170371bd-4ec8-4035-a896-11ee1626b70a"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1b9262bf-7d9e-477f-af01-c9db44c2f960"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1c75f9cb-5001-4be3-ab40-f838de8bd4e9"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("1f4c6ccc-a990-4ffa-96ad-b1b1b8730a0f"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("225f7251-8aaa-4970-a522-0178ec821dec"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2276a423-a094-4ed5-9255-d70cdd55d30f"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("22d746e7-2f9a-4d0b-a8b3-3f1e3196d526"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("239c67ab-ad7c-4c99-af80-10a7f8b2d5c4"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("23ddb97f-aa6b-46ea-91bc-2ffbb07b17e6"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2476d210-dd30-465e-983d-43ffd8723cd2"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2a4b8247-84a0-4e9a-be19-48831cffd518"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2afab24b-d7ba-43a5-85b6-4904adbc1ddd"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2b59ecb3-a780-4de6-838e-8d76b3b5bece"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2cc9159d-95d2-479e-8291-8ce3289e46d6"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("2dd1482f-12c5-49d2-b2e7-115246f483d3"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("32096f26-a94c-41cc-936a-ced8200ebfcc"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("32f1b16f-e3d4-4bdf-98fd-2341bba285f9"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("33350cfd-43c4-42c7-aafe-abd7889506c1"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("34904761-6126-4e3a-a935-5d152d55dbec"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("39e126b4-6647-40b5-98d4-68eb6b4e376b"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("3d69a497-8516-4a5f-a8f4-d8d0e6edc11d"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("438fd18b-77ea-4a4e-a1af-47127ad0d4f3"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("43f27183-86b5-423c-9585-b2e43de41b1d"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4401a7b6-fd52-4de5-96f0-0fe873dd9705"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4946fa06-89a7-4dd9-be4d-5a9699ce2572"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("4b150cd2-a36a-45e0-a8a0-f965ed0081dc"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("52820991-04d3-4651-aa83-932695b03f94"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("55e27cba-0fb2-48ec-b9a0-ef7c26fef352"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5791b230-c4d2-484f-8d6e-bfda2cdc4462"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("586fb7b2-7708-449e-8fc2-d07f7a88311d"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5a20e047-c05b-458b-81ed-9880b05d9de5"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5cb8f6ee-65fe-4557-b534-2a94a8cd6173"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("5feaf154-28ba-403e-895b-1f7ccde625e2"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("60538852-f943-483b-85b6-23b5027856bc"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("60c296b0-d229-4357-aa98-917beeab5706"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("690776bf-a037-4f61-8a7a-5c2321493b8f"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6981f253-9645-466c-9070-9a7ef8b88c19"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("69f13507-0c69-4f4d-91db-5ef3153a085e"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("6d68ccaf-2081-4448-b05c-2e72bf3213c2"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("72d0abed-8270-4a31-950d-4015656089d0"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7631dfc7-7867-47d6-80e1-8c4215621fdd"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("78bc7097-ecdd-437c-a999-15ccc7128985"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("78ec9c06-cedb-4d44-9824-81b1d7b4063b"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7cc184cc-614d-47a9-b265-0a27ab201230"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("7e6b7425-3167-4d75-9b57-71bfdbce3132"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("80379d46-4aee-4b91-99be-439e5ce604b4"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("81dc52d3-3146-4303-8008-3b4c0a4c6fbd"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("84bf6eb4-acee-427f-9088-52d52af15514"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("88a3bc4c-faa6-48c8-ba9f-0a8cd97dbcae"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8f42ae36-25b3-4635-8350-dde3c0538e7a"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("8f7f4379-3b39-4f7f-af3b-0a52aa15d67c"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("916306a1-a715-46d6-973c-862d40b21684"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("977c8be5-16dd-463a-925b-cf40077727fb"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("97df89b6-0427-4370-95d1-50b1f8a2577a"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("98881e7c-7e90-4fb0-a2a4-366c243f9dec"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9a666e3f-0f1c-4ab0-8d1e-4a5117192e2a"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9c0e0d6c-b882-480b-80c1-7e77f6cb181c"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9c23b61a-8fe0-413e-b359-6da30d73f81f"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("9ed888c3-5c9c-46fa-b9e0-ebe93d0814a5"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a03a71d4-f1ad-4d0a-9a14-f31a3c3de873"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("a3000b30-b3a3-4bb9-861e-b1fb10711508"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("aac6d502-00d2-4fce-9015-ba2cd128367c"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ac890a68-1a7a-4ffc-b7bf-3075b5c89864"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b033b593-888f-43f5-b2af-1300db291840"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b3f35d2b-9584-453c-87e2-919e539a9fea"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b65660e6-51f0-4514-88d2-43cdc7a4828c"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b804ae37-9fbb-49ac-b4ba-c639e7364f7f"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("bb8763cc-2cf5-4763-839b-3a8e6a047ea1"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c02ef90c-943d-44d1-abce-ffbba91ac4ef"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c24c9e81-0afa-4136-9a15-0b2aef104555"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c279c8af-286e-4c26-a7da-6d00d3ef6dc2"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c2c93010-b0d4-4b86-b2f2-6ec6fb45bb8e"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c4b51cb3-cdd2-4fbe-821c-d8799c466d27"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("c51bbd3b-93f3-4a1f-96a9-3fda668f8f42"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cb91156b-3164-4c32-bb17-f5d9e0a3383d"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cebfc0cc-528d-45fc-92dd-17c6216e0ec1"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("cf081b92-6e15-463c-8862-14846486e2e1"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("d38a2ff6-607f-4448-a79a-1335239a9369"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("de053f28-9718-4aca-b976-4ce3bcda64a7"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e77a5ed1-281b-4cac-b8f0-bd6c8ac1901a"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("e94ec0fb-2201-4e96-8306-b659b64a7cfb"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ea171852-1f69-4f7d-8770-46d2afae2398"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("ea7207f3-6d1c-4b57-8363-6617681793ed"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("eab41790-d785-4536-ae38-a6ad5fdeefcd"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f39924a6-e497-4539-941d-f958e6bfbacf"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f4ae8ae8-c533-4666-ba31-a5ed36898b85"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f674249f-756b-4a9e-a7fa-338899789ac6"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("f957b06c-b06e-4c65-9e8a-d2dbe55ea394"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("faacedad-94ed-4f53-8312-24607e15c492"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fb63a756-642a-4a2a-9524-58ee124dd061"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fbd2429f-d68d-4d59-b14f-e9287af51afc"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fd1350b3-4a6e-4f05-9025-b772952f5c02"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fdd3cd4e-aad9-4873-9ecc-4cbeb363041b"),
                columns: new[] { "IsArchieved", "IsFavourite" },
                values: new object[] { false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchieved",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "Notes");
        }
    }
}
