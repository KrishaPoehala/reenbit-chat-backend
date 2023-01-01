using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reenbitChat.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeletedOnlyForSender = table.Column<bool>(type: "bit", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivateMessages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrivateMessages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ContactUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => new { x.UserId, x.ContactUserId });
                    table.ForeignKey(
                        name: "FK_UserContacts_AspNetUsers_ContactUserId",
                        column: x => x.ContactUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserContacts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatUser",
                columns: table => new
                {
                    ChatsId = table.Column<int>(type: "int", nullable: false),
                    MembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUser", x => new { x.ChatsId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_ChatUser_AspNetUsers_MembersId",
                        column: x => x.MembersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatUser_Chats_ChatsId",
                        column: x => x.ChatsId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeletedOnlyForSender = table.Column<bool>(type: "bit", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhotoUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "eb03294a-0adb-4e0b-aa10-076c5b0d62cd", null, false, false, null, "Elmore_Crooks28@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=776", null, false, "Eugenia" },
                    { 2, 0, "f23489d6-77de-40f6-9d69-374334e7b459", null, false, false, null, "Bertrand95@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=506", null, false, "Tommie" },
                    { 3, 0, "bc752c54-f35d-4820-a737-5686b8cecc6a", null, false, false, null, "Emile.Funk16@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=448", null, false, "Adrienne" },
                    { 4, 0, "48efd1bf-689d-4242-915e-8919ea64f2cd", null, false, false, null, "Mozell_Mante@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=257", null, false, "Genesis" },
                    { 5, 0, "d369d650-9fd4-4294-96f5-f1eab2c187bf", null, false, false, null, "Maeve.Bayer91@gmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=364", null, false, "Raven" },
                    { 6, 0, "e8f7defb-f464-45e5-99f6-7ac45e9d78b6", null, false, false, null, "Cielo50@gmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=800", null, false, "Krystel" },
                    { 7, 0, "d6d1c435-afb8-485d-b6a2-258ad6ec9530", null, false, false, null, "Roberta.Mann@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=822", null, false, "Eric" },
                    { 8, 0, "625a1f88-bb4d-4bb9-bef0-03f222a8195a", null, false, false, null, "Toy_Lubowitz49@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=1006", null, false, "Martine" },
                    { 9, 0, "08242d78-fc2a-40f5-97b7-11321a6ee500", null, false, false, null, "Chaya_Larson20@gmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=1019", null, false, "Janice" },
                    { 10, 0, "ff8690f1-b86f-4f58-a244-09a67e510335", null, false, false, null, "Lorena.Considine@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=82", null, false, "Nicola" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "https://picsum.photos/640/480/?image=961", "Parker and Sons" },
                    { 2, "https://picsum.photos/640/480/?image=86", "Glover - Vandervort" },
                    { 3, "https://picsum.photos/640/480/?image=1033", "Robel, Walter and Schamberger" },
                    { 4, "https://picsum.photos/640/480/?image=489", "Kemmer, Nitzsche and Schiller" },
                    { 5, "https://picsum.photos/640/480/?image=402", "Romaguera - Heidenreich" },
                    { 6, "https://picsum.photos/640/480/?image=383", "Schiller Group" },
                    { 7, "https://picsum.photos/640/480/?image=337", "Sporer - Schimmel" },
                    { 8, "https://picsum.photos/640/480/?image=785", "Skiles - Murray" },
                    { 9, "https://picsum.photos/640/480/?image=382", "Baumbach, Bins and Wiegand" },
                    { 10, "https://picsum.photos/640/480/?image=837", "Cormier LLC" },
                    { 11, "https://picsum.photos/640/480/?image=111", "Sipes LLC" },
                    { 12, "https://picsum.photos/640/480/?image=995", "Schneider Group" },
                    { 13, "https://picsum.photos/640/480/?image=217", "Lynch Group" },
                    { 14, "https://picsum.photos/640/480/?image=936", "Mraz LLC" },
                    { 15, "https://picsum.photos/640/480/?image=952", "Greenfelder, Pfannerstill and Powlowski" },
                    { 16, "https://picsum.photos/640/480/?image=804", "Cruickshank Inc" },
                    { 17, "https://picsum.photos/640/480/?image=312", "Dare Inc" },
                    { 18, "https://picsum.photos/640/480/?image=779", "Mante - Hartmann" },
                    { 19, "https://picsum.photos/640/480/?image=567", "Brown - Wolff" },
                    { 20, "https://picsum.photos/640/480/?image=545", "Hermann Inc" }
                });

            migrationBuilder.InsertData(
                table: "ChatUser",
                columns: new[] { "ChatsId", "MembersId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 10 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 10 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 8 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 8, 1 },
                    { 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "ChatUser",
                columns: new[] { "ChatsId", "MembersId" },
                values: new object[,]
                {
                    { 8, 4 },
                    { 8, 7 },
                    { 8, 10 },
                    { 9, 3 },
                    { 9, 5 },
                    { 9, 7 },
                    { 9, 10 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 9 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 13, 4 },
                    { 13, 6 },
                    { 13, 8 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 5 },
                    { 14, 7 },
                    { 15, 1 },
                    { 15, 3 },
                    { 15, 5 }
                });

            migrationBuilder.InsertData(
                table: "ChatUser",
                columns: new[] { "ChatsId", "MembersId" },
                values: new object[,]
                {
                    { 15, 6 },
                    { 15, 10 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 },
                    { 16, 4 },
                    { 16, 8 },
                    { 16, 9 },
                    { 16, 10 },
                    { 17, 1 },
                    { 17, 2 },
                    { 17, 3 },
                    { 17, 4 },
                    { 17, 5 },
                    { 17, 7 },
                    { 17, 9 },
                    { 17, 10 },
                    { 18, 2 },
                    { 18, 4 },
                    { 18, 5 },
                    { 18, 6 },
                    { 18, 8 },
                    { 18, 9 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 4 },
                    { 19, 5 },
                    { 19, 9 },
                    { 19, 10 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 20, 6 },
                    { 20, 7 },
                    { 20, 9 },
                    { 20, 10 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 1, 8, null, 7, new DateTime(2022, 9, 10, 3, 46, 20, 439, DateTimeKind.Local).AddTicks(8228), "Dolorum dolorem distinctio sapiente.\nMinus pariatur animi eum iure deserunt." },
                    { 2, 15, null, 1, new DateTime(2022, 10, 3, 11, 8, 6, 687, DateTimeKind.Local).AddTicks(3351), "Laudantium sit eum quia deleniti illum sapiente.\nVoluptatibus nesciunt modi." },
                    { 3, 14, null, 5, new DateTime(2022, 9, 19, 14, 52, 41, 97, DateTimeKind.Local).AddTicks(7826), "Maiores incidunt temporibus sunt rerum illo magnam et.\nNihil necessitatibus porro recusandae ratione natus deserunt dolore impedit." },
                    { 4, 14, null, 5, new DateTime(2022, 3, 22, 3, 27, 0, 667, DateTimeKind.Local).AddTicks(9228), "Corporis at itaque ut et voluptatem rerum sit nostrum.\nSit sequi quia perferendis voluptatem blanditiis eum fugit voluptas." },
                    { 5, 20, null, 7, new DateTime(2022, 5, 12, 12, 34, 51, 855, DateTimeKind.Local).AddTicks(1465), "Impedit vero sed.\nAd velit doloribus hic commodi." },
                    { 6, 11, null, 6, new DateTime(2021, 12, 20, 9, 9, 11, 556, DateTimeKind.Local).AddTicks(6379), "Est rerum non hic.\nDebitis ipsam beatae ut nihil voluptas." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 7, 8, null, 7, new DateTime(2022, 5, 10, 8, 32, 2, 647, DateTimeKind.Local).AddTicks(6127), "Perferendis nulla nobis similique iure eveniet.\nCorrupti illo officia voluptatem atque neque alias." },
                    { 8, 14, null, 7, new DateTime(2022, 7, 14, 15, 16, 45, 297, DateTimeKind.Local).AddTicks(2428), "Consequatur accusantium eaque reiciendis sed sunt cum quisquam nostrum dolor.\nInventore amet et." },
                    { 9, 19, null, 8, new DateTime(2022, 8, 9, 7, 20, 53, 401, DateTimeKind.Local).AddTicks(6888), "Aut officia laborum provident repudiandae enim nihil dicta totam.\nCommodi dignissimos rerum odit rerum ratione." },
                    { 10, 1, null, 5, new DateTime(2022, 8, 11, 4, 7, 45, 305, DateTimeKind.Local).AddTicks(7909), "Nostrum dolor aperiam modi exercitationem.\nLaborum voluptatem tempore." },
                    { 11, 6, null, 2, new DateTime(2022, 1, 18, 1, 40, 20, 899, DateTimeKind.Local).AddTicks(6718), "Inventore nemo iste ex voluptas debitis.\nSuscipit cum minus unde quis nesciunt magni voluptatem doloremque debitis." },
                    { 12, 15, null, 1, new DateTime(2022, 6, 29, 13, 7, 3, 24, DateTimeKind.Local).AddTicks(9918), "Molestiae esse corrupti.\nOptio dolores magni quae et consequuntur exercitationem." },
                    { 13, 6, null, 6, new DateTime(2022, 1, 17, 23, 53, 36, 993, DateTimeKind.Local).AddTicks(1419), "Laboriosam numquam excepturi similique consequatur reiciendis modi.\nQuibusdam aut temporibus eos et qui enim molestias qui quasi." },
                    { 14, 2, null, 6, new DateTime(2022, 7, 2, 1, 57, 38, 781, DateTimeKind.Local).AddTicks(1212), "Debitis corporis nostrum eum iure excepturi ex commodi voluptatem.\nEx modi accusantium nesciunt." },
                    { 15, 11, null, 2, new DateTime(2022, 7, 24, 20, 12, 1, 481, DateTimeKind.Local).AddTicks(4269), "Molestiae sapiente itaque.\nDebitis quo autem molestiae dolorem atque quis rem rerum officiis." },
                    { 16, 19, null, 6, new DateTime(2022, 5, 12, 7, 19, 7, 819, DateTimeKind.Local).AddTicks(4826), "Molestias est iusto facere culpa odit repellendus numquam.\nEt ut quo quod ullam est ea et." },
                    { 17, 17, null, 7, new DateTime(2022, 4, 16, 13, 5, 26, 990, DateTimeKind.Local).AddTicks(2735), "Officia enim incidunt.\nPlaceat neque quaerat qui." },
                    { 18, 14, null, 2, new DateTime(2022, 7, 15, 5, 4, 46, 604, DateTimeKind.Local).AddTicks(5586), "Consequatur aperiam repudiandae sit cumque.\nLaudantium possimus laudantium ducimus aut est." },
                    { 19, 14, null, 10, new DateTime(2022, 9, 28, 0, 5, 13, 882, DateTimeKind.Local).AddTicks(9491), "Autem ratione et.\nAspernatur enim id suscipit quia odio." },
                    { 20, 9, null, 3, new DateTime(2022, 1, 1, 19, 29, 6, 356, DateTimeKind.Local).AddTicks(2171), "Asperiores adipisci quos incidunt reiciendis excepturi.\nNihil dolorem modi dolor iste ut quis aspernatur natus quae." },
                    { 21, 15, null, 2, new DateTime(2022, 5, 30, 1, 16, 17, 550, DateTimeKind.Local).AddTicks(8346), "Et voluptatem mollitia.\nQuibusdam explicabo et et rem sint deserunt." },
                    { 22, 13, null, 2, new DateTime(2022, 4, 23, 11, 8, 35, 986, DateTimeKind.Local).AddTicks(5527), "Porro fugiat similique.\nQuia quo ex tenetur qui voluptas maiores." },
                    { 23, 18, null, 8, new DateTime(2022, 4, 25, 21, 4, 55, 256, DateTimeKind.Local).AddTicks(2579), "Ut facere ea commodi ducimus.\nNisi quia quia eos tempora laboriosam velit iusto illum rerum." },
                    { 24, 5, null, 7, new DateTime(2022, 6, 5, 13, 39, 50, 30, DateTimeKind.Local).AddTicks(1903), "Inventore dolores magnam aut aspernatur.\nLaborum maxime ad aliquid iusto et sint voluptate dolore." },
                    { 25, 19, null, 5, new DateTime(2022, 2, 12, 11, 44, 39, 707, DateTimeKind.Local).AddTicks(8609), "Vero corrupti eius perferendis vel tempore quasi.\nVeritatis aut sed veritatis consectetur quia dicta sit unde ut." },
                    { 26, 4, null, 1, new DateTime(2022, 5, 10, 3, 48, 22, 357, DateTimeKind.Local).AddTicks(1312), "At quo expedita sint eum sed.\nUllam ea consectetur dolorem ipsa sed praesentium est." },
                    { 27, 11, null, 9, new DateTime(2021, 12, 28, 23, 48, 55, 165, DateTimeKind.Local).AddTicks(1126), "Ducimus laboriosam laudantium unde aspernatur quasi.\nIpsum est deleniti sit molestiae architecto sed quos quis." },
                    { 28, 9, null, 3, new DateTime(2022, 4, 20, 0, 53, 28, 445, DateTimeKind.Local).AddTicks(3971), "Aut harum odio eum molestiae temporibus ad id ipsam.\nEt tenetur et consequatur corporis et." },
                    { 29, 3, null, 3, new DateTime(2022, 5, 26, 19, 27, 36, 933, DateTimeKind.Local).AddTicks(5723), "Laudantium molestias itaque magnam et.\nIn quae corrupti animi est." },
                    { 30, 3, null, 2, new DateTime(2022, 1, 31, 23, 29, 6, 156, DateTimeKind.Local).AddTicks(6331), "Cum sapiente aut ratione et quasi eum sit.\nExplicabo numquam soluta." },
                    { 31, 1, null, 7, new DateTime(2022, 9, 27, 13, 39, 42, 45, DateTimeKind.Local).AddTicks(5511), "Expedita deserunt non provident facilis amet.\nDebitis hic eos veniam repudiandae veritatis ipsum consequatur." },
                    { 32, 12, null, 1, new DateTime(2022, 9, 14, 17, 32, 57, 406, DateTimeKind.Local).AddTicks(2487), "Deleniti architecto fugit nihil inventore nobis culpa aut.\nRepudiandae dignissimos cum." },
                    { 33, 11, null, 4, new DateTime(2022, 11, 24, 2, 34, 41, 815, DateTimeKind.Local).AddTicks(5264), "Ut ipsum quibusdam delectus ducimus dolore earum molestiae doloribus rerum.\nVoluptatem laboriosam corporis nemo ullam." },
                    { 34, 1, null, 5, new DateTime(2022, 5, 2, 21, 0, 1, 32, DateTimeKind.Local).AddTicks(6083), "Voluptatem ducimus sunt.\nBlanditiis cum ad commodi maxime tenetur tempore ut." },
                    { 35, 1, null, 9, new DateTime(2022, 9, 2, 13, 50, 44, 121, DateTimeKind.Local).AddTicks(8162), "Adipisci officiis sit ipsam maiores nemo sunt non eum illum.\nFuga aliquid eligendi ullam ut magnam maxime quia numquam." },
                    { 36, 3, null, 4, new DateTime(2022, 4, 10, 6, 44, 23, 913, DateTimeKind.Local).AddTicks(7145), "Dolore debitis mollitia deserunt.\nRerum voluptatum corrupti mollitia et eos sit magnam." },
                    { 37, 15, null, 5, new DateTime(2022, 8, 1, 15, 44, 57, 312, DateTimeKind.Local).AddTicks(1254), "Blanditiis recusandae ut et eum quisquam voluptatem.\nOccaecati quaerat culpa odit non atque nesciunt sit." },
                    { 38, 19, null, 9, new DateTime(2022, 11, 2, 19, 52, 21, 946, DateTimeKind.Local).AddTicks(2522), "Qui cumque dolores magni quibusdam sit numquam impedit.\nMinus ut voluptas occaecati ratione tempora a laborum sed." },
                    { 39, 15, null, 6, new DateTime(2022, 12, 5, 11, 41, 0, 901, DateTimeKind.Local).AddTicks(7824), "At commodi et eaque error rerum fugit.\nTempora similique praesentium rerum dolor." },
                    { 40, 18, null, 1, new DateTime(2022, 1, 28, 7, 27, 53, 287, DateTimeKind.Local).AddTicks(4598), "Ut fugit molestiae non labore repudiandae et sit incidunt.\nFacere vitae et." },
                    { 41, 8, null, 6, new DateTime(2022, 7, 11, 20, 48, 31, 594, DateTimeKind.Local).AddTicks(9909), "Similique sed occaecati voluptatem quidem eligendi voluptatem dolorem et.\nRerum asperiores saepe dolore sed ex temporibus consequuntur qui." },
                    { 42, 1, null, 8, new DateTime(2022, 2, 27, 21, 43, 14, 431, DateTimeKind.Local).AddTicks(9241), "Perferendis praesentium commodi id voluptatem.\nQuia quaerat tempore." },
                    { 43, 9, null, 1, new DateTime(2022, 6, 4, 14, 7, 42, 182, DateTimeKind.Local).AddTicks(5589), "Neque dolor sed ex.\nAperiam officia soluta sint." },
                    { 44, 2, null, 6, new DateTime(2022, 7, 31, 3, 20, 56, 930, DateTimeKind.Local).AddTicks(7028), "Molestiae libero aperiam tempora tempore et nobis magnam quas.\nEligendi voluptates voluptatem saepe excepturi et quod sint." },
                    { 45, 9, null, 3, new DateTime(2022, 11, 30, 20, 37, 53, 501, DateTimeKind.Local).AddTicks(4764), "Aspernatur et fuga hic porro voluptatem.\nReprehenderit quis aut sapiente sequi reprehenderit alias voluptatem." },
                    { 46, 15, null, 1, new DateTime(2021, 12, 22, 19, 11, 35, 673, DateTimeKind.Local).AddTicks(534), "Aut sit facilis qui nam ab natus ullam.\nMinus quas voluptas dolores tempore." },
                    { 47, 10, null, 5, new DateTime(2022, 10, 17, 18, 55, 29, 719, DateTimeKind.Local).AddTicks(6159), "Rerum et autem omnis incidunt autem.\nTempora qui nostrum laboriosam error qui est." },
                    { 48, 5, null, 4, new DateTime(2022, 11, 17, 22, 43, 59, 132, DateTimeKind.Local).AddTicks(7050), "Et sed veritatis dolore animi quo.\nSunt vero veniam placeat nesciunt autem aperiam." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 49, 9, null, 8, new DateTime(2022, 7, 18, 21, 4, 47, 806, DateTimeKind.Local).AddTicks(802), "Et accusamus unde sint est ducimus voluptatem.\nIncidunt nihil maiores voluptatem sint excepturi." },
                    { 50, 6, null, 3, new DateTime(2022, 3, 13, 14, 49, 41, 412, DateTimeKind.Local).AddTicks(6531), "Expedita mollitia officiis eos.\nRerum neque dolorum mollitia." },
                    { 51, 14, null, 3, new DateTime(2022, 1, 23, 19, 46, 46, 369, DateTimeKind.Local).AddTicks(9690), "Omnis voluptatem et iste iure ea recusandae.\nAdipisci ipsa enim voluptas laudantium ut voluptates aperiam omnis molestiae." },
                    { 52, 6, null, 4, new DateTime(2021, 12, 20, 2, 28, 48, 867, DateTimeKind.Local).AddTicks(3919), "Consectetur fugit omnis totam velit enim est doloribus inventore.\nImpedit sed ex eos repellat dolorem." },
                    { 53, 1, null, 10, new DateTime(2021, 12, 22, 1, 24, 20, 453, DateTimeKind.Local).AddTicks(3108), "Quo fuga beatae animi.\nMollitia odio nam." },
                    { 54, 20, null, 8, new DateTime(2022, 5, 3, 11, 45, 36, 218, DateTimeKind.Local).AddTicks(437), "Rerum ut qui nulla deleniti ea ratione.\nPlaceat impedit nam distinctio est necessitatibus dignissimos." },
                    { 55, 9, null, 4, new DateTime(2022, 1, 5, 1, 22, 10, 41, DateTimeKind.Local).AddTicks(9563), "Id id fugiat sed nesciunt officiis ipsa cupiditate.\nQuos itaque consectetur autem molestiae unde maxime voluptate quia consequuntur." },
                    { 56, 8, null, 6, new DateTime(2022, 10, 24, 8, 29, 22, 961, DateTimeKind.Local).AddTicks(6983), "Eveniet adipisci expedita voluptatem quaerat sequi nostrum.\nFacere consequatur ut perferendis aut." },
                    { 57, 16, null, 4, new DateTime(2022, 6, 29, 22, 30, 43, 141, DateTimeKind.Local).AddTicks(405), "Qui adipisci illo commodi dolores similique nisi neque.\nFugiat natus vel." },
                    { 58, 18, null, 1, new DateTime(2022, 7, 16, 19, 51, 34, 672, DateTimeKind.Local).AddTicks(6194), "Eos ut nihil culpa sit ut maxime atque aspernatur non.\nPerspiciatis ut quidem officiis quis et blanditiis minus." },
                    { 59, 19, null, 6, new DateTime(2022, 11, 5, 5, 6, 8, 568, DateTimeKind.Local).AddTicks(3766), "Minus et debitis consequatur.\nSed totam nihil debitis." },
                    { 60, 13, null, 8, new DateTime(2022, 3, 20, 22, 4, 35, 256, DateTimeKind.Local).AddTicks(7944), "Repudiandae accusantium repellat voluptas id impedit sit suscipit atque.\nEst praesentium voluptatem quasi consectetur maxime." },
                    { 61, 13, null, 7, new DateTime(2021, 12, 15, 6, 40, 31, 214, DateTimeKind.Local).AddTicks(1086), "Quod expedita corporis labore.\nAtque eum enim nostrum laborum aut nihil eligendi." },
                    { 62, 10, null, 5, new DateTime(2022, 5, 30, 20, 15, 25, 945, DateTimeKind.Local).AddTicks(4346), "In blanditiis quisquam veniam vero magnam qui aut temporibus vero.\nDicta ea quaerat." },
                    { 63, 18, null, 5, new DateTime(2022, 1, 5, 13, 36, 48, 249, DateTimeKind.Local).AddTicks(5239), "Harum debitis ullam id ipsum.\nEst molestiae accusamus hic architecto libero." },
                    { 64, 14, null, 4, new DateTime(2022, 8, 28, 14, 47, 38, 951, DateTimeKind.Local).AddTicks(1920), "Quia consectetur aliquid facere harum inventore aspernatur quis sunt.\nOmnis consectetur sapiente et doloribus." },
                    { 65, 7, null, 6, new DateTime(2022, 10, 29, 14, 24, 49, 150, DateTimeKind.Local).AddTicks(1822), "Praesentium amet quasi.\nEos sed et non beatae natus quisquam ea velit." },
                    { 66, 19, null, 3, new DateTime(2022, 5, 20, 10, 49, 51, 568, DateTimeKind.Local).AddTicks(2821), "Alias praesentium dolore ipsum.\nRepudiandae suscipit voluptate." },
                    { 67, 13, null, 9, new DateTime(2022, 12, 2, 11, 29, 19, 561, DateTimeKind.Local).AddTicks(3432), "Autem dicta dolor.\nQuis accusantium eos totam incidunt iure sed ut." },
                    { 68, 9, null, 9, new DateTime(2022, 5, 5, 20, 4, 46, 762, DateTimeKind.Local).AddTicks(7391), "Qui ratione earum cupiditate iure quaerat vero quae.\nIn natus voluptatem accusamus in fugit velit." },
                    { 69, 20, null, 7, new DateTime(2021, 12, 12, 7, 46, 24, 992, DateTimeKind.Local).AddTicks(9572), "Sed placeat doloribus dolorum reiciendis cupiditate quibusdam cupiditate.\nOfficiis quia minus quibusdam sint esse numquam." },
                    { 70, 18, null, 8, new DateTime(2021, 12, 21, 6, 21, 52, 113, DateTimeKind.Local).AddTicks(4478), "Dolorem quis omnis error a consectetur.\nNumquam suscipit aut officiis velit et mollitia." },
                    { 71, 17, null, 4, new DateTime(2022, 9, 17, 2, 47, 27, 413, DateTimeKind.Local).AddTicks(9718), "Voluptatem vel deleniti et illo.\nQuia doloremque aut voluptatum architecto amet laboriosam cupiditate." },
                    { 72, 12, null, 9, new DateTime(2021, 12, 20, 2, 58, 46, 9, DateTimeKind.Local).AddTicks(834), "Ab eveniet reiciendis in aut.\nMagnam modi ipsa nulla rerum quis odio dolorem est aut." },
                    { 73, 9, null, 5, new DateTime(2022, 11, 21, 10, 16, 56, 713, DateTimeKind.Local).AddTicks(5318), "In molestiae delectus beatae fuga veritatis quia molestiae.\nAlias non quam nihil qui culpa esse pariatur." },
                    { 74, 8, null, 3, new DateTime(2022, 7, 2, 17, 8, 54, 170, DateTimeKind.Local).AddTicks(8881), "Perferendis nostrum fugiat nulla quisquam quia perferendis neque laudantium.\nPlaceat mollitia ipsam quis." },
                    { 75, 3, null, 10, new DateTime(2022, 7, 24, 10, 32, 31, 697, DateTimeKind.Local).AddTicks(6666), "Velit itaque aperiam doloremque quo nihil.\nOccaecati aut omnis quia deleniti dolorum." },
                    { 76, 14, null, 10, new DateTime(2022, 5, 12, 18, 41, 0, 660, DateTimeKind.Local).AddTicks(2393), "Vitae eos cum esse saepe dicta facere dolore ea aut.\nEst fugit aut ut." },
                    { 77, 3, null, 3, new DateTime(2022, 1, 8, 20, 24, 44, 986, DateTimeKind.Local).AddTicks(8375), "Sint autem omnis.\nVoluptas quia molestiae excepturi et veniam qui cupiditate." },
                    { 78, 2, null, 6, new DateTime(2021, 12, 22, 9, 42, 13, 0, DateTimeKind.Local).AddTicks(4661), "Hic quia dolorem et eum nesciunt.\nCommodi iure quisquam et unde illum delectus." },
                    { 79, 6, null, 10, new DateTime(2022, 3, 7, 11, 52, 34, 23, DateTimeKind.Local).AddTicks(1236), "Nisi libero et excepturi nisi laboriosam ea vel minima rem.\nTemporibus omnis natus." },
                    { 80, 19, null, 6, new DateTime(2022, 9, 19, 16, 14, 38, 309, DateTimeKind.Local).AddTicks(5763), "Deserunt iure facere.\nMagnam similique iusto totam alias iste." },
                    { 81, 16, null, 10, new DateTime(2022, 8, 20, 2, 7, 24, 982, DateTimeKind.Local).AddTicks(5097), "Quia esse consequuntur hic minima voluptatem voluptatum.\nMinima non voluptas in et aliquid et." },
                    { 82, 14, null, 9, new DateTime(2022, 2, 3, 19, 57, 53, 684, DateTimeKind.Local).AddTicks(7032), "Ea laboriosam quia.\nVoluptatum est et molestias." },
                    { 83, 12, null, 10, new DateTime(2022, 3, 19, 13, 41, 54, 806, DateTimeKind.Local).AddTicks(7969), "Eius non ad et id illo.\nPlaceat dolorum tempora dicta ipsum." },
                    { 84, 14, null, 1, new DateTime(2022, 4, 21, 11, 55, 7, 827, DateTimeKind.Local).AddTicks(1374), "Cupiditate accusantium autem est doloribus amet.\nSimilique velit nam." },
                    { 85, 11, null, 2, new DateTime(2022, 10, 17, 4, 50, 59, 832, DateTimeKind.Local).AddTicks(1945), "Fugiat suscipit aut nemo impedit voluptas repudiandae quasi labore qui.\nId eligendi saepe sit tenetur fugit praesentium quia nobis." },
                    { 86, 13, null, 9, new DateTime(2022, 3, 18, 15, 36, 33, 16, DateTimeKind.Local).AddTicks(9071), "Earum autem illum nihil dicta dolor.\nQuam dolor a dolorem omnis et rerum." },
                    { 87, 17, null, 7, new DateTime(2022, 5, 11, 17, 51, 26, 545, DateTimeKind.Local).AddTicks(503), "Autem provident aspernatur sunt exercitationem dicta quos voluptate unde.\nQuia dolorem reprehenderit ea eos." },
                    { 88, 11, null, 4, new DateTime(2022, 1, 1, 13, 25, 16, 871, DateTimeKind.Local).AddTicks(9406), "Rerum quia architecto enim est eius.\nDucimus odit velit." },
                    { 89, 15, null, 5, new DateTime(2022, 9, 9, 7, 31, 0, 861, DateTimeKind.Local).AddTicks(6076), "A quo consequatur optio nisi fugit.\nRem illum quas." },
                    { 90, 4, null, 7, new DateTime(2022, 1, 5, 5, 47, 31, 857, DateTimeKind.Local).AddTicks(5229), "Fugit iusto iure recusandae veniam dolores earum adipisci.\nAtque ratione sint sunt error eum provident voluptate rem rem." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 91, 13, null, 1, new DateTime(2022, 6, 30, 9, 36, 58, 835, DateTimeKind.Local).AddTicks(1484), "Ut atque et rem quis dolore voluptas.\nVelit consequatur eos tenetur est." },
                    { 92, 7, null, 7, new DateTime(2022, 8, 27, 8, 36, 54, 156, DateTimeKind.Local).AddTicks(6883), "Ea voluptatum qui aut rerum temporibus in.\nAccusamus modi beatae blanditiis fuga qui est cupiditate." },
                    { 93, 12, null, 6, new DateTime(2022, 1, 30, 17, 6, 11, 978, DateTimeKind.Local).AddTicks(3698), "Iusto sed animi aut tenetur.\nVoluptatem consequatur repellendus." },
                    { 94, 3, null, 1, new DateTime(2022, 1, 3, 6, 38, 36, 721, DateTimeKind.Local).AddTicks(3868), "Possimus quam accusamus quisquam et est molestiae blanditiis.\nVel nihil qui consectetur rerum ipsum accusamus." },
                    { 95, 13, null, 5, new DateTime(2022, 11, 7, 8, 23, 59, 401, DateTimeKind.Local).AddTicks(4201), "Ullam magnam voluptas.\nDolor sit et repudiandae." },
                    { 96, 1, null, 7, new DateTime(2021, 12, 10, 4, 19, 40, 70, DateTimeKind.Local).AddTicks(1483), "Est repellendus ipsam quas quia non omnis.\nNemo eum sapiente soluta id voluptatum omnis est nisi." },
                    { 97, 16, null, 2, new DateTime(2021, 12, 23, 9, 10, 51, 689, DateTimeKind.Local).AddTicks(2991), "Porro est accusantium voluptatem laborum.\nAut eos est adipisci fugit et omnis harum consequatur consequatur." },
                    { 98, 12, null, 6, new DateTime(2022, 9, 3, 14, 42, 7, 443, DateTimeKind.Local).AddTicks(5147), "Et aut voluptas sit corrupti fugit aliquam voluptate corporis quos.\nPraesentium sint officia enim voluptas esse rerum." },
                    { 99, 7, null, 2, new DateTime(2022, 12, 2, 7, 30, 19, 59, DateTimeKind.Local).AddTicks(7200), "Doloribus dolores voluptas asperiores totam praesentium totam.\nAssumenda perferendis voluptates porro et consequatur." },
                    { 100, 18, null, 6, new DateTime(2022, 1, 8, 20, 55, 54, 252, DateTimeKind.Local).AddTicks(3767), "Ut nam sunt sit quaerat porro.\nSaepe eos quam maiores exercitationem accusantium necessitatibus." },
                    { 101, 18, null, 9, new DateTime(2022, 3, 5, 13, 48, 18, 991, DateTimeKind.Local).AddTicks(9791), "Numquam quis reprehenderit quibusdam consequatur.\nTotam sequi inventore saepe voluptas suscipit omnis vel et." },
                    { 102, 18, null, 4, new DateTime(2022, 8, 19, 15, 43, 16, 276, DateTimeKind.Local).AddTicks(9840), "Distinctio qui quia sit amet temporibus.\nFugiat sed et et vel omnis ullam non." },
                    { 103, 12, null, 1, new DateTime(2022, 4, 20, 5, 30, 19, 588, DateTimeKind.Local).AddTicks(5363), "Est numquam nemo.\nDolores ex repellat blanditiis totam itaque ipsum." },
                    { 104, 2, null, 6, new DateTime(2022, 6, 22, 3, 15, 38, 1, DateTimeKind.Local).AddTicks(3945), "Atque quos optio dicta.\nUnde est occaecati animi qui dolores autem architecto et quia." },
                    { 105, 17, null, 2, new DateTime(2022, 1, 21, 0, 51, 35, 493, DateTimeKind.Local).AddTicks(1535), "Praesentium a et voluptates nam.\nQuaerat molestias nulla ea voluptate qui enim dolores quia accusantium." },
                    { 106, 15, null, 4, new DateTime(2022, 9, 9, 2, 11, 20, 355, DateTimeKind.Local).AddTicks(3485), "Consectetur laudantium et ut inventore.\nMinima in enim omnis molestias ea." },
                    { 107, 20, null, 7, new DateTime(2021, 12, 10, 3, 14, 22, 42, DateTimeKind.Local).AddTicks(5133), "Dolor omnis quo ipsa eius eum alias.\nMaiores maiores rerum commodi id quasi in cupiditate ipsam beatae." },
                    { 108, 6, null, 5, new DateTime(2022, 8, 22, 3, 0, 56, 489, DateTimeKind.Local).AddTicks(4187), "Dolorum quia aspernatur laborum at aut qui inventore corporis.\nEaque voluptatem ducimus animi optio repellendus temporibus debitis et sit." },
                    { 109, 9, null, 2, new DateTime(2022, 10, 19, 16, 44, 47, 939, DateTimeKind.Local).AddTicks(9333), "Autem deserunt qui iste provident.\nHarum et similique mollitia a ut est." },
                    { 110, 20, null, 1, new DateTime(2022, 4, 26, 14, 22, 2, 938, DateTimeKind.Local).AddTicks(8814), "Ipsum nihil dignissimos provident vitae sint.\nIpsa voluptas et aut aut animi voluptatem." },
                    { 111, 20, null, 3, new DateTime(2022, 12, 8, 6, 45, 34, 710, DateTimeKind.Local).AddTicks(5558), "Sint voluptas magnam dolores iure.\nOmnis est quibusdam cumque aliquid quam non." },
                    { 112, 17, null, 10, new DateTime(2022, 7, 2, 20, 12, 1, 200, DateTimeKind.Local).AddTicks(192), "Sunt voluptatem architecto quisquam quas itaque ullam.\nQuaerat delectus est et." },
                    { 113, 4, null, 2, new DateTime(2022, 2, 22, 12, 7, 59, 992, DateTimeKind.Local).AddTicks(825), "Numquam corporis tenetur.\nQuam minima ipsa ipsam corrupti alias libero non ducimus officia." },
                    { 114, 12, null, 7, new DateTime(2022, 7, 19, 21, 18, 37, 360, DateTimeKind.Local).AddTicks(1939), "Accusantium dignissimos consequuntur.\nVoluptas omnis magnam et." },
                    { 115, 6, null, 6, new DateTime(2022, 7, 18, 16, 8, 21, 81, DateTimeKind.Local).AddTicks(4277), "Ut et fugiat consequatur et et enim ratione.\nDoloribus maiores fugiat velit officiis molestias voluptatum sed." },
                    { 116, 8, null, 8, new DateTime(2022, 7, 6, 7, 35, 2, 734, DateTimeKind.Local).AddTicks(4948), "Nulla nostrum pariatur est ut esse nam eligendi iusto aut.\nMollitia sunt aliquam vitae harum quo ea voluptatem pariatur eos." },
                    { 117, 6, null, 5, new DateTime(2022, 1, 23, 8, 29, 59, 904, DateTimeKind.Local).AddTicks(8411), "Quos quos non aperiam soluta vitae aspernatur ea deleniti.\nSunt assumenda voluptatem quis omnis distinctio vero in." },
                    { 118, 3, null, 10, new DateTime(2022, 10, 7, 20, 11, 34, 481, DateTimeKind.Local).AddTicks(5085), "Doloribus aliquam eos fuga deserunt.\nSit expedita itaque nihil voluptate dolores qui odio aut dolorem." },
                    { 119, 19, null, 4, new DateTime(2022, 10, 11, 20, 7, 39, 301, DateTimeKind.Local).AddTicks(2076), "Dolores expedita quia qui dolorem natus iure.\nConsectetur ducimus non tenetur et autem." },
                    { 120, 13, null, 1, new DateTime(2022, 8, 10, 19, 24, 57, 563, DateTimeKind.Local).AddTicks(7384), "Fuga consequatur eveniet natus aliquid saepe placeat molestiae soluta.\nRecusandae ipsum incidunt." },
                    { 121, 13, null, 9, new DateTime(2022, 6, 17, 12, 4, 20, 93, DateTimeKind.Local).AddTicks(9754), "Tempore voluptatem quo quibusdam et voluptatem.\nEnim vel occaecati officia ducimus sit voluptatem placeat." },
                    { 122, 11, null, 7, new DateTime(2022, 1, 28, 1, 7, 9, 925, DateTimeKind.Local).AddTicks(8669), "Cumque earum minima beatae perferendis corporis eos.\nEarum quibusdam iusto." },
                    { 123, 6, null, 6, new DateTime(2022, 6, 16, 3, 48, 8, 814, DateTimeKind.Local).AddTicks(9722), "Architecto corporis dolores aut ea culpa.\nEarum distinctio dolor non itaque mollitia consectetur vero minus." },
                    { 124, 10, null, 3, new DateTime(2022, 7, 10, 21, 30, 19, 342, DateTimeKind.Local).AddTicks(6509), "Nam adipisci ducimus.\nEnim neque consequuntur omnis architecto repellendus soluta eveniet quia." },
                    { 125, 15, null, 4, new DateTime(2022, 6, 22, 9, 13, 33, 297, DateTimeKind.Local).AddTicks(2114), "Id soluta eum assumenda exercitationem rerum illo aperiam nam explicabo.\nEt ea eum vero omnis odio." },
                    { 126, 17, null, 5, new DateTime(2022, 9, 5, 14, 22, 53, 818, DateTimeKind.Local).AddTicks(188), "Tempore assumenda voluptas officiis ad sunt.\nEst aut iste." },
                    { 127, 13, null, 9, new DateTime(2022, 7, 8, 22, 56, 57, 428, DateTimeKind.Local).AddTicks(2006), "Ipsum ut repellat voluptatem.\nConsequatur aliquid fugit aut voluptatibus molestiae dolores fugit blanditiis." },
                    { 128, 11, null, 6, new DateTime(2022, 3, 15, 14, 11, 44, 465, DateTimeKind.Local).AddTicks(812), "Iure quasi beatae itaque optio eligendi.\nEt beatae omnis repudiandae consequatur consequatur minus nam incidunt est." },
                    { 129, 13, null, 4, new DateTime(2022, 3, 2, 21, 39, 24, 552, DateTimeKind.Local).AddTicks(7929), "Facere qui et dicta doloribus pariatur.\nOmnis quam ab similique ea qui atque aspernatur est exercitationem." },
                    { 130, 12, null, 3, new DateTime(2022, 2, 3, 12, 17, 10, 100, DateTimeKind.Local).AddTicks(1022), "Omnis et aliquam suscipit.\nVelit rerum magnam aliquam id quia tempore at." },
                    { 131, 17, null, 7, new DateTime(2022, 4, 4, 16, 54, 45, 196, DateTimeKind.Local).AddTicks(2106), "Deleniti laboriosam quibusdam sit dolorum beatae eum.\nRerum ratione hic nulla quibusdam est." },
                    { 132, 18, null, 10, new DateTime(2022, 2, 4, 19, 50, 34, 671, DateTimeKind.Local).AddTicks(8562), "In molestiae enim distinctio alias qui.\nEt doloremque facere atque sed." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 133, 6, null, 7, new DateTime(2022, 2, 26, 19, 53, 51, 565, DateTimeKind.Local).AddTicks(2264), "Facilis cum hic rerum et et.\nQuisquam reprehenderit quia laborum nihil voluptatem facilis ad qui." },
                    { 134, 3, null, 8, new DateTime(2022, 1, 25, 23, 47, 22, 16, DateTimeKind.Local).AddTicks(5821), "Voluptas ex quia numquam voluptas maxime.\nIste nihil distinctio veniam eos autem in." },
                    { 135, 7, null, 4, new DateTime(2022, 4, 12, 23, 48, 29, 317, DateTimeKind.Local).AddTicks(8775), "Quas quasi doloribus qui repudiandae rerum.\nSuscipit in deserunt omnis pariatur ut." },
                    { 136, 8, null, 3, new DateTime(2022, 4, 15, 14, 51, 4, 655, DateTimeKind.Local).AddTicks(5125), "Consequatur dignissimos necessitatibus id velit consequatur repellat ut sed.\nVoluptatem ex ut voluptatem odit sunt." },
                    { 137, 6, null, 10, new DateTime(2022, 7, 6, 2, 51, 13, 679, DateTimeKind.Local).AddTicks(1781), "Architecto velit incidunt et sapiente sint occaecati aut.\nMagni nulla quod enim deserunt ullam dolorem quos aperiam." },
                    { 138, 1, null, 8, new DateTime(2022, 8, 1, 19, 38, 52, 943, DateTimeKind.Local).AddTicks(9298), "Laborum repellendus est vel.\nMaxime ut reprehenderit maiores sint dolorem ut." },
                    { 139, 7, null, 1, new DateTime(2022, 5, 4, 14, 44, 8, 816, DateTimeKind.Local).AddTicks(3366), "Optio vero velit.\nVoluptatibus assumenda sit ullam vero et ratione nesciunt neque itaque." },
                    { 140, 19, null, 9, new DateTime(2022, 3, 25, 10, 40, 54, 953, DateTimeKind.Local).AddTicks(4451), "Est dolore ut nihil et quae non consequuntur.\nId molestiae expedita ad minus vel eos." },
                    { 141, 3, null, 2, new DateTime(2022, 3, 16, 10, 46, 47, 794, DateTimeKind.Local).AddTicks(7040), "Vero sed sed sequi aut et.\nFuga odit blanditiis quam omnis est labore." },
                    { 142, 13, null, 1, new DateTime(2022, 2, 19, 18, 23, 47, 320, DateTimeKind.Local).AddTicks(499), "Beatae consequatur nostrum unde maxime ullam quaerat autem voluptas.\nEt nobis ipsum totam quisquam est animi enim iusto." },
                    { 143, 2, null, 8, new DateTime(2022, 4, 29, 16, 12, 16, 163, DateTimeKind.Local).AddTicks(6714), "Eveniet modi sit dolor omnis ea nesciunt dignissimos et.\nSed sint ullam rerum eum ab." },
                    { 144, 15, null, 6, new DateTime(2022, 8, 6, 17, 15, 52, 714, DateTimeKind.Local).AddTicks(5653), "Facilis beatae et voluptatum quae voluptates tempora.\nMinima quos explicabo est et non non dicta." },
                    { 145, 1, null, 1, new DateTime(2022, 6, 12, 1, 11, 59, 900, DateTimeKind.Local).AddTicks(3259), "Animi quod eaque tenetur libero non nisi repellat omnis sunt.\nEt rerum quia eos." },
                    { 146, 1, null, 10, new DateTime(2022, 2, 3, 8, 18, 27, 143, DateTimeKind.Local).AddTicks(8567), "Occaecati dolor ipsa totam tempore qui hic.\nDicta ipsum et vel voluptas vel omnis." },
                    { 147, 17, null, 1, new DateTime(2022, 11, 12, 23, 21, 14, 293, DateTimeKind.Local).AddTicks(5686), "Dolorem est dolorem consectetur.\nMinus amet id sed sint ea." },
                    { 148, 8, null, 3, new DateTime(2022, 7, 23, 17, 45, 6, 389, DateTimeKind.Local).AddTicks(8001), "Atque aperiam possimus ut totam sint amet perspiciatis consequatur voluptates.\nBeatae adipisci impedit magnam nemo tempora." },
                    { 149, 15, null, 9, new DateTime(2022, 8, 19, 5, 1, 44, 457, DateTimeKind.Local).AddTicks(3228), "Saepe blanditiis numquam quia quibusdam.\nAd quasi iure ab sed necessitatibus ut non rerum nam." },
                    { 150, 5, null, 2, new DateTime(2022, 10, 4, 20, 45, 11, 202, DateTimeKind.Local).AddTicks(5269), "Maxime ratione explicabo natus et repudiandae consequatur.\nDolorem omnis nemo nisi." },
                    { 151, 16, null, 9, new DateTime(2022, 7, 18, 10, 24, 37, 970, DateTimeKind.Local).AddTicks(2697), "Voluptate asperiores neque voluptas quam quia quas.\nMolestias iste sed dolorem sunt eveniet quos qui error unde." },
                    { 152, 13, null, 9, new DateTime(2022, 4, 16, 9, 15, 42, 896, DateTimeKind.Local).AddTicks(3160), "Quis quisquam voluptate reprehenderit.\nReprehenderit et et neque veritatis sunt vero sed dolor." },
                    { 153, 2, null, 6, new DateTime(2022, 5, 3, 17, 31, 2, 74, DateTimeKind.Local).AddTicks(4863), "Cupiditate quo aut incidunt labore doloremque amet.\nAssumenda eos ducimus fuga." },
                    { 154, 11, null, 2, new DateTime(2022, 7, 25, 22, 5, 30, 925, DateTimeKind.Local).AddTicks(1361), "Beatae est est ea illo quae harum distinctio quia illum.\nQuas quos iste cupiditate commodi aliquam labore." },
                    { 155, 3, null, 5, new DateTime(2022, 2, 16, 23, 18, 11, 434, DateTimeKind.Local).AddTicks(8062), "Pariatur officia distinctio ut accusantium voluptate qui quo non dignissimos.\nLaborum beatae autem." },
                    { 156, 6, null, 9, new DateTime(2022, 6, 7, 3, 24, 48, 993, DateTimeKind.Local).AddTicks(8246), "Atque cumque at.\nRecusandae omnis aliquid impedit id exercitationem et." },
                    { 157, 7, null, 6, new DateTime(2022, 11, 8, 12, 48, 39, 331, DateTimeKind.Local).AddTicks(5740), "Eos non in eos doloribus dolores et est.\nDolorem non aliquid numquam repudiandae qui." },
                    { 158, 3, null, 7, new DateTime(2021, 12, 10, 10, 36, 54, 689, DateTimeKind.Local).AddTicks(2746), "Reprehenderit soluta voluptates neque in animi dolorum corrupti eos.\nQuia modi quidem debitis." },
                    { 159, 13, null, 10, new DateTime(2022, 3, 31, 18, 28, 9, 601, DateTimeKind.Local).AddTicks(2012), "Voluptas ut nemo rerum laborum molestiae quidem aliquam quis.\nVoluptatem laborum quaerat quisquam numquam recusandae rem blanditiis." },
                    { 160, 8, null, 10, new DateTime(2022, 2, 20, 1, 51, 49, 536, DateTimeKind.Local).AddTicks(8636), "Sunt dolorem atque quis aut voluptate quia incidunt.\nAd neque et ut delectus quasi." },
                    { 161, 16, null, 2, new DateTime(2022, 9, 16, 20, 52, 30, 314, DateTimeKind.Local).AddTicks(2095), "Dolorem magnam rerum dolor voluptatem omnis tempore laborum qui.\nVoluptate distinctio incidunt quis sed asperiores et." },
                    { 162, 7, null, 10, new DateTime(2022, 6, 14, 18, 37, 52, 810, DateTimeKind.Local).AddTicks(3499), "Neque in est quia quidem id ut nihil.\nEligendi odit et cum sed sit." },
                    { 163, 18, null, 10, new DateTime(2022, 11, 29, 14, 57, 22, 275, DateTimeKind.Local).AddTicks(7922), "Omnis porro sunt voluptatem.\nOdio et rerum." },
                    { 164, 17, null, 3, new DateTime(2022, 1, 27, 16, 2, 42, 788, DateTimeKind.Local).AddTicks(3668), "Repellat occaecati necessitatibus eaque voluptatem qui reiciendis.\nProvident ut fugiat aut." },
                    { 165, 11, null, 9, new DateTime(2022, 6, 16, 7, 11, 56, 740, DateTimeKind.Local).AddTicks(9613), "Aspernatur cumque aut dolor quaerat nobis dolor aut.\nExplicabo commodi ut voluptate in rem." },
                    { 166, 12, null, 7, new DateTime(2022, 4, 24, 3, 29, 11, 974, DateTimeKind.Local).AddTicks(9402), "A omnis atque.\nMinima porro tempore quis quod." },
                    { 167, 15, null, 4, new DateTime(2021, 12, 10, 0, 12, 6, 582, DateTimeKind.Local).AddTicks(8620), "Cum temporibus quam voluptas eos.\nQuaerat qui nesciunt eveniet vero quas expedita atque." },
                    { 168, 17, null, 3, new DateTime(2022, 1, 21, 15, 33, 27, 116, DateTimeKind.Local).AddTicks(8991), "Eaque a adipisci sed consequatur.\nUllam reiciendis cumque vitae officiis at sit deserunt." },
                    { 169, 3, null, 3, new DateTime(2022, 9, 21, 12, 49, 18, 418, DateTimeKind.Local).AddTicks(826), "Eius laborum corporis voluptatem ut suscipit.\nDolor unde nostrum aut asperiores non eos assumenda exercitationem perspiciatis." },
                    { 170, 9, null, 9, new DateTime(2022, 4, 9, 16, 17, 21, 534, DateTimeKind.Local).AddTicks(6909), "Velit aspernatur quo voluptatem natus non.\nNesciunt autem neque suscipit eum quae dolores." },
                    { 171, 3, null, 2, new DateTime(2022, 3, 1, 1, 55, 34, 886, DateTimeKind.Local).AddTicks(7274), "Cupiditate eaque debitis labore quia consequuntur qui placeat et ipsam.\nUt aut magni vel magnam est quaerat aut." },
                    { 172, 10, null, 6, new DateTime(2022, 12, 6, 6, 48, 41, 6, DateTimeKind.Local).AddTicks(3475), "Exercitationem minus error.\nQuia quaerat numquam sit." },
                    { 173, 3, null, 2, new DateTime(2022, 4, 28, 19, 50, 49, 699, DateTimeKind.Local).AddTicks(3476), "Porro voluptate assumenda autem quo cum sunt fuga provident architecto.\nQui odit molestiae ut odio." },
                    { 174, 15, null, 5, new DateTime(2022, 4, 13, 5, 28, 19, 59, DateTimeKind.Local).AddTicks(7539), "Corporis sint ipsum aut hic commodi doloribus.\nSuscipit autem velit rerum." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 175, 2, null, 7, new DateTime(2022, 5, 22, 23, 6, 40, 946, DateTimeKind.Local).AddTicks(1138), "Laboriosam consequatur neque omnis excepturi ullam saepe beatae.\nVero occaecati provident natus aspernatur accusantium dolor voluptatem porro voluptates." },
                    { 176, 4, null, 5, new DateTime(2022, 7, 8, 7, 40, 39, 253, DateTimeKind.Local).AddTicks(4778), "Facere sunt quo et dignissimos blanditiis laboriosam atque vel.\nVoluptates rerum quia doloremque." },
                    { 177, 8, null, 3, new DateTime(2022, 5, 14, 9, 36, 41, 522, DateTimeKind.Local).AddTicks(4229), "Voluptatem quae soluta dolorem.\nA tempore dolorem." },
                    { 178, 19, null, 7, new DateTime(2022, 9, 18, 17, 45, 10, 197, DateTimeKind.Local).AddTicks(9852), "Qui ab vel ea quidem ipsam.\nEt hic quae eligendi minima qui." },
                    { 179, 7, null, 7, new DateTime(2022, 6, 5, 14, 58, 16, 531, DateTimeKind.Local).AddTicks(2098), "Quia quibusdam vero.\nAut deleniti necessitatibus perferendis libero et quia modi." },
                    { 180, 13, null, 4, new DateTime(2021, 12, 25, 9, 16, 30, 668, DateTimeKind.Local).AddTicks(5336), "Quia qui id possimus vitae cum at molestiae rerum.\nId atque laboriosam id quia." },
                    { 181, 17, null, 8, new DateTime(2022, 1, 20, 23, 35, 41, 587, DateTimeKind.Local).AddTicks(1548), "Odio nemo illo itaque.\nRerum et iste est corporis in." },
                    { 182, 8, null, 1, new DateTime(2022, 7, 28, 4, 43, 45, 917, DateTimeKind.Local).AddTicks(102), "Enim nihil numquam et consequatur in.\nAut debitis possimus voluptatem in dicta quaerat qui aut." },
                    { 183, 2, null, 8, new DateTime(2022, 1, 24, 19, 54, 2, 590, DateTimeKind.Local).AddTicks(337), "Illum et in distinctio voluptas sequi ratione.\nAmet aut et molestiae et." },
                    { 184, 8, null, 9, new DateTime(2022, 5, 15, 17, 24, 33, 773, DateTimeKind.Local).AddTicks(446), "Sit a corporis eius et vel repellendus.\nUt accusamus eum occaecati architecto quis neque dignissimos sint." },
                    { 185, 18, null, 4, new DateTime(2022, 10, 27, 8, 6, 37, 188, DateTimeKind.Local).AddTicks(597), "Mollitia aut quam dolores qui velit magni ipsum animi.\nVoluptas voluptatem amet." },
                    { 186, 3, null, 7, new DateTime(2022, 6, 20, 0, 53, 44, 794, DateTimeKind.Local).AddTicks(7742), "Mollitia odit eveniet quidem non impedit.\nMaiores voluptatibus qui non assumenda." },
                    { 187, 13, null, 3, new DateTime(2022, 11, 6, 19, 51, 58, 120, DateTimeKind.Local).AddTicks(4013), "Officia rerum maxime id mollitia expedita iste.\nFacere alias incidunt ullam quae ipsum." },
                    { 188, 10, null, 7, new DateTime(2022, 8, 8, 1, 13, 14, 584, DateTimeKind.Local).AddTicks(7686), "Velit recusandae incidunt aut dolorum animi quas architecto quasi.\nConsequatur maiores ut." },
                    { 189, 10, null, 1, new DateTime(2022, 9, 11, 20, 37, 51, 978, DateTimeKind.Local).AddTicks(5413), "Culpa quod perspiciatis enim libero labore officiis.\nExercitationem assumenda numquam ab amet." },
                    { 190, 5, null, 7, new DateTime(2022, 1, 7, 16, 55, 46, 950, DateTimeKind.Local).AddTicks(2362), "Enim quaerat rem dolorem vel aspernatur omnis facilis aperiam voluptatibus.\nEnim aut nemo aut ut." },
                    { 191, 7, null, 6, new DateTime(2021, 12, 31, 9, 32, 11, 294, DateTimeKind.Local).AddTicks(8990), "Maxime similique totam eligendi.\nTempore suscipit porro cumque nostrum qui rerum nesciunt aut." },
                    { 192, 5, null, 9, new DateTime(2022, 2, 23, 17, 56, 37, 854, DateTimeKind.Local).AddTicks(9213), "Occaecati est ut.\nEt aut debitis." },
                    { 193, 4, null, 1, new DateTime(2022, 4, 14, 3, 23, 51, 742, DateTimeKind.Local).AddTicks(4797), "Voluptatibus porro aut maxime aut facilis.\nQui natus magni." },
                    { 194, 15, null, 4, new DateTime(2022, 4, 23, 21, 16, 10, 483, DateTimeKind.Local).AddTicks(9398), "Non architecto error dolore dolore exercitationem odio.\nQui architecto qui cum ab ipsa beatae non." },
                    { 195, 6, null, 2, new DateTime(2022, 9, 6, 21, 35, 48, 121, DateTimeKind.Local).AddTicks(623), "Velit quas magnam odio molestias.\nEt praesentium fuga ipsum sunt ut alias saepe fuga." },
                    { 196, 7, null, 6, new DateTime(2022, 2, 5, 18, 24, 55, 488, DateTimeKind.Local).AddTicks(5607), "Quas et hic ut autem consectetur necessitatibus expedita impedit.\nOmnis qui ut et vel commodi." },
                    { 197, 7, null, 7, new DateTime(2022, 4, 6, 18, 26, 18, 465, DateTimeKind.Local).AddTicks(6020), "Repudiandae occaecati quisquam officiis ut.\nEt consequatur voluptatem facilis id aut." },
                    { 198, 20, null, 6, new DateTime(2022, 7, 6, 15, 20, 35, 825, DateTimeKind.Local).AddTicks(1225), "Iste sit dolor odio id accusamus hic harum tempore.\nQui nihil et." },
                    { 199, 9, null, 1, new DateTime(2022, 9, 17, 21, 14, 32, 76, DateTimeKind.Local).AddTicks(3408), "Et et qui magni perferendis facilis magnam in.\nQuaerat eum dolor et dolorem earum aut aperiam." },
                    { 200, 6, null, 4, new DateTime(2022, 2, 13, 3, 43, 51, 494, DateTimeKind.Local).AddTicks(6329), "Est necessitatibus ducimus eum sed voluptatem.\nAccusantium ad rerum quaerat asperiores amet." },
                    { 201, 3, null, 4, new DateTime(2022, 5, 5, 17, 30, 51, 222, DateTimeKind.Local).AddTicks(6345), "Amet in quas optio qui et non voluptate.\nCorporis quibusdam blanditiis impedit non assumenda ea qui et." },
                    { 202, 12, null, 7, new DateTime(2022, 3, 26, 15, 49, 41, 18, DateTimeKind.Local).AddTicks(7330), "Porro qui ad velit omnis consectetur voluptas.\nAut voluptatibus provident animi cum nemo." },
                    { 203, 4, null, 4, new DateTime(2022, 10, 12, 5, 57, 8, 227, DateTimeKind.Local).AddTicks(6612), "Velit minima quam et necessitatibus iure.\nVoluptates odio illum et." },
                    { 204, 19, null, 6, new DateTime(2022, 2, 24, 23, 27, 15, 711, DateTimeKind.Local).AddTicks(4725), "Minima soluta odit qui officiis fugit esse non non eaque.\nAut rerum quo minima amet." },
                    { 205, 16, null, 10, new DateTime(2022, 7, 9, 20, 33, 19, 707, DateTimeKind.Local).AddTicks(5529), "Quo et rem sint amet rerum cupiditate.\nDicta dolore dolores dicta voluptatum reiciendis temporibus." },
                    { 206, 5, null, 8, new DateTime(2022, 1, 21, 21, 53, 22, 952, DateTimeKind.Local).AddTicks(2244), "Voluptatem voluptatem labore optio dolores sunt.\nVel porro architecto natus porro enim iusto." },
                    { 207, 15, null, 9, new DateTime(2022, 2, 15, 5, 3, 22, 635, DateTimeKind.Local).AddTicks(2431), "Possimus minus soluta et rerum aliquam natus modi voluptatem nisi.\nEum autem consequatur repudiandae quisquam debitis ut sit repellat." },
                    { 208, 11, null, 2, new DateTime(2022, 5, 10, 20, 1, 35, 788, DateTimeKind.Local).AddTicks(5762), "Dolor veniam iure nihil recusandae accusamus est.\nLaborum nisi minus iste vel et nobis." },
                    { 209, 15, null, 10, new DateTime(2022, 2, 26, 5, 14, 20, 169, DateTimeKind.Local).AddTicks(2258), "Eos impedit dicta esse et dolor iusto et dolor ab.\nAut eius nobis cupiditate et voluptates tenetur deserunt." },
                    { 210, 15, null, 7, new DateTime(2022, 4, 20, 13, 49, 9, 944, DateTimeKind.Local).AddTicks(8426), "Fugiat labore ducimus accusantium est earum consectetur quas.\nEst blanditiis repellat iure deserunt." },
                    { 211, 6, null, 9, new DateTime(2022, 7, 7, 21, 41, 52, 745, DateTimeKind.Local).AddTicks(2381), "Est ratione reiciendis illo ad quasi.\nMolestiae maiores deleniti." },
                    { 212, 9, null, 5, new DateTime(2022, 5, 19, 9, 24, 34, 762, DateTimeKind.Local).AddTicks(7100), "Non amet sequi corporis aperiam exercitationem ab illum nihil.\nAd occaecati exercitationem ea sunt vel qui omnis ratione." },
                    { 213, 18, null, 3, new DateTime(2022, 2, 26, 10, 27, 18, 184, DateTimeKind.Local).AddTicks(6861), "Non nulla nam et magnam harum rerum corrupti est.\nDelectus in inventore quia quo explicabo dolorum consequatur." },
                    { 214, 13, null, 7, new DateTime(2022, 6, 8, 2, 36, 1, 43, DateTimeKind.Local).AddTicks(822), "Quia quo molestias adipisci accusantium.\nVoluptatem voluptatem ut nostrum facilis." },
                    { 215, 18, null, 2, new DateTime(2022, 9, 23, 12, 39, 50, 161, DateTimeKind.Local).AddTicks(6468), "Eveniet dolores praesentium doloribus voluptatem debitis.\nEarum incidunt doloribus officia temporibus." },
                    { 216, 5, null, 7, new DateTime(2022, 7, 25, 15, 1, 36, 941, DateTimeKind.Local).AddTicks(4935), "Sequi autem illum et rerum.\nQuia porro ratione dolor." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 217, 1, null, 4, new DateTime(2022, 9, 27, 9, 35, 5, 728, DateTimeKind.Local).AddTicks(3988), "Et facere officia occaecati modi aut earum quisquam.\nLaudantium ea dolorem excepturi." },
                    { 218, 15, null, 8, new DateTime(2022, 1, 26, 14, 46, 35, 292, DateTimeKind.Local).AddTicks(8766), "Aut fuga nostrum ex voluptas a repellat dolore corrupti.\nNesciunt veritatis labore quia quos repellendus earum voluptates odio." },
                    { 219, 11, null, 5, new DateTime(2022, 11, 30, 2, 43, 55, 854, DateTimeKind.Local).AddTicks(3994), "Cupiditate nesciunt id voluptatibus et alias quia.\nSint beatae officiis blanditiis numquam et." },
                    { 220, 3, null, 4, new DateTime(2022, 4, 26, 5, 29, 6, 471, DateTimeKind.Local).AddTicks(606), "Voluptatem blanditiis vero delectus architecto vel consequatur repudiandae deserunt adipisci.\nCorrupti harum non quam sequi occaecati." },
                    { 221, 2, null, 7, new DateTime(2022, 1, 4, 15, 27, 2, 317, DateTimeKind.Local).AddTicks(5517), "Aut velit et voluptates qui nam.\nLaboriosam cumque quia dolor quia doloribus et." },
                    { 222, 16, null, 3, new DateTime(2022, 3, 30, 10, 24, 11, 107, DateTimeKind.Local).AddTicks(1627), "Voluptates repudiandae debitis aliquam.\nEius et necessitatibus sit." },
                    { 223, 9, null, 1, new DateTime(2022, 3, 13, 18, 35, 27, 916, DateTimeKind.Local).AddTicks(6235), "Velit ex voluptatem corrupti quia facere debitis numquam.\nMaxime odit dolorem officiis eos ullam mollitia reprehenderit saepe non." },
                    { 224, 10, null, 2, new DateTime(2022, 4, 21, 5, 22, 48, 397, DateTimeKind.Local).AddTicks(987), "Ab nulla non repudiandae ex.\nDolor ut quis." },
                    { 225, 14, null, 3, new DateTime(2022, 8, 12, 4, 53, 30, 594, DateTimeKind.Local).AddTicks(3137), "Non et quae autem magni et quidem.\nOfficia adipisci blanditiis voluptate aut at quam aut id." },
                    { 226, 13, null, 1, new DateTime(2022, 2, 7, 12, 24, 3, 81, DateTimeKind.Local).AddTicks(5568), "Culpa voluptate dolor porro eum sint.\nEos cumque eius." },
                    { 227, 19, null, 2, new DateTime(2022, 5, 8, 5, 54, 8, 612, DateTimeKind.Local).AddTicks(1136), "Impedit ut ipsa blanditiis voluptatem.\nQui quos sit sapiente." },
                    { 228, 12, null, 10, new DateTime(2022, 4, 26, 21, 42, 43, 546, DateTimeKind.Local).AddTicks(8874), "Quidem perspiciatis doloremque at quia consectetur doloremque numquam.\nEt quia quos natus sapiente." },
                    { 229, 2, null, 8, new DateTime(2022, 9, 21, 21, 42, 7, 65, DateTimeKind.Local).AddTicks(4540), "Quod modi sapiente veritatis ipsa.\nAut sed est velit et." },
                    { 230, 19, null, 2, new DateTime(2022, 3, 21, 13, 1, 30, 843, DateTimeKind.Local).AddTicks(8101), "Nam officiis quisquam sit dolor veniam ex.\nEt corporis velit commodi." },
                    { 231, 8, null, 2, new DateTime(2022, 7, 25, 0, 43, 23, 604, DateTimeKind.Local).AddTicks(615), "Consequatur sunt eligendi blanditiis et nemo doloremque distinctio ut.\nDicta ea fugit amet." },
                    { 232, 11, null, 6, new DateTime(2022, 11, 13, 4, 8, 15, 780, DateTimeKind.Local).AddTicks(642), "Itaque hic dignissimos et dolorum.\nDolor enim assumenda voluptas." },
                    { 233, 17, null, 2, new DateTime(2022, 2, 12, 9, 50, 37, 205, DateTimeKind.Local).AddTicks(6407), "Velit delectus eos animi vero cumque.\nBeatae dolore perferendis explicabo ad." },
                    { 234, 20, null, 5, new DateTime(2022, 4, 15, 6, 26, 39, 802, DateTimeKind.Local).AddTicks(8607), "Eos impedit consequatur ipsam et.\nAutem sint quo officiis aut hic error nihil." },
                    { 235, 12, null, 7, new DateTime(2022, 3, 30, 17, 52, 26, 825, DateTimeKind.Local).AddTicks(6036), "Aut consequatur laboriosam voluptas blanditiis error eum.\nDebitis sit voluptatem eum natus." },
                    { 236, 9, null, 10, new DateTime(2022, 1, 15, 2, 3, 41, 595, DateTimeKind.Local).AddTicks(2524), "Magni illo architecto qui ab consequatur voluptatum.\nAdipisci voluptas sequi non voluptatem iure voluptatibus." },
                    { 237, 15, null, 10, new DateTime(2022, 5, 4, 18, 17, 16, 446, DateTimeKind.Local).AddTicks(9650), "Maiores dolorum qui.\nQuo iusto incidunt consequatur velit sit officiis." },
                    { 238, 14, null, 8, new DateTime(2022, 1, 9, 0, 35, 23, 401, DateTimeKind.Local).AddTicks(7794), "Placeat quia dignissimos est animi perspiciatis quod incidunt ipsam voluptatem.\nEst sunt vel." },
                    { 239, 8, null, 10, new DateTime(2022, 4, 5, 11, 2, 9, 832, DateTimeKind.Local).AddTicks(1335), "Voluptas placeat est voluptas sint veniam aut quaerat id.\nConsequatur et sint suscipit earum suscipit qui aut sunt." },
                    { 240, 10, null, 2, new DateTime(2022, 5, 8, 9, 53, 23, 538, DateTimeKind.Local).AddTicks(5596), "Illum et nesciunt blanditiis autem voluptatum aut nesciunt ut ea.\nDignissimos rerum quam architecto quos veniam rerum nihil voluptas voluptates." },
                    { 241, 11, null, 10, new DateTime(2022, 6, 27, 12, 35, 44, 191, DateTimeKind.Local).AddTicks(8846), "Vero vero cupiditate maiores ea quia repudiandae itaque.\nNemo atque cumque ab et pariatur quibusdam optio provident." },
                    { 242, 10, null, 5, new DateTime(2022, 9, 9, 7, 9, 54, 825, DateTimeKind.Local).AddTicks(1359), "Eligendi et sequi et dolores.\nNam eaque iusto impedit." },
                    { 243, 7, null, 10, new DateTime(2022, 7, 16, 21, 23, 28, 810, DateTimeKind.Local).AddTicks(5040), "Necessitatibus eveniet delectus ex.\nVero iusto hic eum." },
                    { 244, 9, null, 1, new DateTime(2022, 6, 10, 7, 30, 34, 577, DateTimeKind.Local).AddTicks(1790), "Consectetur dolores porro at sit autem blanditiis excepturi eos molestiae.\nAtque non illo hic." },
                    { 245, 16, null, 8, new DateTime(2022, 4, 12, 1, 38, 37, 95, DateTimeKind.Local).AddTicks(8773), "Inventore officiis molestias pariatur id consequatur dicta dolorum modi.\nRem hic rerum eum rerum quo." },
                    { 246, 8, null, 7, new DateTime(2022, 1, 7, 16, 46, 43, 512, DateTimeKind.Local).AddTicks(1426), "Culpa praesentium eum.\nMolestias nostrum recusandae rerum." },
                    { 247, 17, null, 5, new DateTime(2022, 4, 19, 14, 10, 1, 587, DateTimeKind.Local).AddTicks(2961), "Porro aut quo.\nNemo consectetur at eum." },
                    { 248, 5, null, 8, new DateTime(2022, 8, 7, 7, 3, 32, 644, DateTimeKind.Local).AddTicks(9690), "Nobis voluptatem excepturi eius.\nNon aut et qui omnis ab deleniti saepe et." },
                    { 249, 12, null, 6, new DateTime(2022, 6, 7, 22, 45, 27, 630, DateTimeKind.Local).AddTicks(9916), "Totam eius praesentium sit illo.\nIllo explicabo sunt voluptatum magnam dolores consequatur cum deleniti id." },
                    { 250, 6, null, 6, new DateTime(2022, 2, 7, 8, 47, 13, 133, DateTimeKind.Local).AddTicks(5540), "Ipsum ut consequuntur sunt accusamus soluta beatae voluptatem illum voluptas.\nConsequatur et dolorum dolorem quod ea neque." },
                    { 251, 7, null, 1, new DateTime(2022, 11, 18, 13, 45, 30, 74, DateTimeKind.Local).AddTicks(1767), "Voluptatem eum voluptatem rerum sint sit amet excepturi incidunt dolores.\nFacilis eveniet nihil pariatur." },
                    { 252, 20, null, 10, new DateTime(2022, 5, 8, 12, 43, 52, 639, DateTimeKind.Local).AddTicks(4217), "Et vero tenetur.\nSit eveniet et vel aperiam accusantium ipsa cum reprehenderit cum." },
                    { 253, 2, null, 4, new DateTime(2022, 1, 30, 20, 1, 45, 437, DateTimeKind.Local).AddTicks(6702), "Omnis quia autem mollitia iure porro.\nModi omnis consequatur maiores pariatur adipisci." },
                    { 254, 17, null, 9, new DateTime(2022, 5, 24, 23, 4, 34, 389, DateTimeKind.Local).AddTicks(5186), "Autem iste minima porro illum laboriosam et.\nFuga ipsum ut dolorem." },
                    { 255, 14, null, 9, new DateTime(2022, 7, 31, 16, 48, 30, 642, DateTimeKind.Local).AddTicks(3528), "Quod molestiae repudiandae.\nQuisquam est ad nostrum et." },
                    { 256, 11, null, 6, new DateTime(2022, 9, 22, 1, 4, 8, 338, DateTimeKind.Local).AddTicks(8203), "Exercitationem unde id ut fuga sit sed.\nAutem quis veniam sed eveniet doloremque maiores." },
                    { 257, 11, null, 7, new DateTime(2022, 6, 15, 14, 1, 6, 868, DateTimeKind.Local).AddTicks(3104), "Est iste explicabo culpa laboriosam non quisquam vero animi.\nEligendi quos optio nihil harum dolores rerum." },
                    { 258, 7, null, 6, new DateTime(2022, 11, 12, 10, 49, 45, 986, DateTimeKind.Local).AddTicks(8531), "Excepturi eos qui voluptatum velit consequatur aliquid expedita eligendi ut.\nVeritatis sapiente dolores." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 259, 14, null, 9, new DateTime(2021, 12, 24, 18, 51, 32, 691, DateTimeKind.Local).AddTicks(9301), "Sed veniam et impedit et modi dolorem sequi reiciendis.\nNobis quas enim nam." },
                    { 260, 8, null, 4, new DateTime(2022, 9, 20, 22, 57, 19, 59, DateTimeKind.Local).AddTicks(5970), "Eius qui cumque officia fugit doloribus corrupti delectus voluptatibus.\nEius qui ut nisi laborum illo repudiandae at." },
                    { 261, 2, null, 10, new DateTime(2022, 10, 21, 7, 44, 22, 357, DateTimeKind.Local).AddTicks(2233), "Fuga in consequatur.\nCumque eaque repudiandae." },
                    { 262, 11, null, 4, new DateTime(2022, 8, 30, 19, 21, 41, 311, DateTimeKind.Local).AddTicks(7246), "Provident voluptatem aut quia velit quisquam voluptatem.\nDicta aut molestiae." },
                    { 263, 9, null, 5, new DateTime(2022, 3, 7, 23, 44, 16, 283, DateTimeKind.Local).AddTicks(7611), "Dolor ut velit.\nSint non ut non odit illo." },
                    { 264, 1, null, 7, new DateTime(2022, 7, 18, 9, 31, 17, 796, DateTimeKind.Local).AddTicks(1459), "Eum laboriosam deleniti ut facilis maiores modi delectus.\nVoluptatem sit laborum." },
                    { 265, 15, null, 4, new DateTime(2022, 8, 22, 4, 57, 58, 47, DateTimeKind.Local).AddTicks(198), "Necessitatibus et molestiae.\nNon est fugit qui nihil." },
                    { 266, 5, null, 7, new DateTime(2022, 1, 25, 12, 17, 3, 689, DateTimeKind.Local).AddTicks(9010), "Sed vel nemo tempore ut eum.\nVoluptate voluptatem necessitatibus cum." },
                    { 267, 11, null, 6, new DateTime(2022, 11, 5, 5, 24, 52, 180, DateTimeKind.Local).AddTicks(1699), "Odit nihil eum et expedita sit assumenda.\nSit quam reprehenderit ut ut quo illum vel." },
                    { 268, 7, null, 9, new DateTime(2022, 7, 15, 21, 59, 36, 540, DateTimeKind.Local).AddTicks(2194), "Consequuntur occaecati earum impedit perferendis occaecati non aperiam omnis dignissimos.\nEsse sint recusandae optio rerum ullam vero rerum natus." },
                    { 269, 5, null, 10, new DateTime(2022, 2, 13, 19, 57, 39, 150, DateTimeKind.Local).AddTicks(2427), "Repellat est quod nostrum non velit optio vero eos numquam.\nQuae repudiandae consequatur adipisci ea." },
                    { 270, 12, null, 1, new DateTime(2022, 8, 30, 2, 7, 43, 487, DateTimeKind.Local).AddTicks(7279), "Fugit facilis praesentium id voluptas nostrum voluptatem minus consequuntur.\nDoloremque incidunt quae perferendis aut consequatur tempora molestiae dolores velit." },
                    { 271, 3, null, 5, new DateTime(2022, 4, 20, 0, 53, 41, 31, DateTimeKind.Local).AddTicks(6359), "Sed et non qui quia.\nDebitis delectus quo." },
                    { 272, 12, null, 10, new DateTime(2022, 8, 8, 10, 44, 27, 984, DateTimeKind.Local).AddTicks(8950), "Ab doloremque dolor ut exercitationem asperiores beatae rem modi veritatis.\nIpsa nemo ad non." },
                    { 273, 15, null, 5, new DateTime(2022, 4, 25, 9, 30, 52, 274, DateTimeKind.Local).AddTicks(2907), "Voluptatem ipsa ipsa.\nHarum rerum ut molestiae ullam quo accusamus corrupti eos." },
                    { 274, 1, null, 2, new DateTime(2022, 5, 31, 14, 31, 35, 171, DateTimeKind.Local).AddTicks(2433), "Nihil ea delectus voluptas sint quas quo perferendis.\nAd perferendis quod blanditiis est omnis velit laborum." },
                    { 275, 11, null, 6, new DateTime(2022, 5, 29, 21, 15, 42, 27, DateTimeKind.Local).AddTicks(8766), "Impedit tenetur natus odit aut ipsam.\nId omnis et deleniti aut eos error ut dolorem qui." },
                    { 276, 6, null, 1, new DateTime(2022, 1, 18, 15, 28, 41, 641, DateTimeKind.Local).AddTicks(7891), "Rerum corrupti maiores quaerat beatae.\nAb dolorum et dolor et impedit commodi enim." },
                    { 277, 8, null, 7, new DateTime(2022, 3, 3, 14, 46, 59, 104, DateTimeKind.Local).AddTicks(4575), "Officia numquam animi sed illo.\nEsse rem corporis officia totam praesentium." },
                    { 278, 9, null, 5, new DateTime(2022, 3, 20, 21, 32, 4, 957, DateTimeKind.Local).AddTicks(2605), "Accusantium cupiditate est.\nMollitia autem provident minus nobis iure eum ad quasi voluptatem." },
                    { 279, 5, null, 4, new DateTime(2022, 8, 24, 16, 26, 31, 645, DateTimeKind.Local).AddTicks(4265), "Illo et illo autem vel nihil.\nAccusamus natus rerum debitis sapiente recusandae omnis veniam." },
                    { 280, 19, null, 2, new DateTime(2022, 5, 16, 2, 38, 3, 90, DateTimeKind.Local).AddTicks(5042), "Vero qui omnis quis reprehenderit magnam quo suscipit.\nAutem eveniet ullam natus ut incidunt exercitationem." },
                    { 281, 8, null, 1, new DateTime(2022, 9, 13, 18, 54, 14, 184, DateTimeKind.Local).AddTicks(3854), "Consequatur facere sunt quo iure.\nConsequatur minima et ullam sint totam perferendis est quas nulla." },
                    { 282, 13, null, 1, new DateTime(2022, 7, 24, 14, 21, 45, 343, DateTimeKind.Local).AddTicks(6582), "Voluptatibus reprehenderit qui est.\nRerum eligendi vel libero quibusdam est at hic." },
                    { 283, 13, null, 2, new DateTime(2022, 10, 31, 16, 28, 17, 986, DateTimeKind.Local).AddTicks(7511), "Nemo consectetur ea tempora quas odio.\nOmnis magni repellendus maiores." },
                    { 284, 18, null, 4, new DateTime(2022, 3, 19, 20, 4, 26, 932, DateTimeKind.Local).AddTicks(2323), "Aut nostrum voluptatum qui sint pariatur debitis qui nihil.\nRecusandae numquam a qui." },
                    { 285, 3, null, 3, new DateTime(2022, 2, 25, 0, 25, 48, 620, DateTimeKind.Local).AddTicks(517), "Dolorem tenetur dicta est.\nNam accusamus rem atque quas." },
                    { 286, 1, null, 2, new DateTime(2022, 10, 5, 21, 38, 33, 248, DateTimeKind.Local).AddTicks(7610), "Cum ad molestiae et deserunt repellendus dolorem consequatur dicta.\nUt aliquid ut beatae laboriosam non." },
                    { 287, 8, null, 1, new DateTime(2022, 7, 5, 2, 7, 52, 302, DateTimeKind.Local).AddTicks(4428), "Delectus quod quod quaerat beatae vel quos.\nTempora mollitia ut iure eaque deleniti illo dolorem." },
                    { 288, 10, null, 10, new DateTime(2022, 4, 1, 2, 11, 55, 263, DateTimeKind.Local).AddTicks(1056), "At qui illo et ut ea hic vel tenetur dicta.\nRecusandae quidem consequuntur voluptates aperiam sed ipsum voluptatem et esse." },
                    { 289, 15, null, 5, new DateTime(2022, 5, 26, 4, 57, 2, 29, DateTimeKind.Local).AddTicks(6839), "Magni accusantium a ut.\nEt eveniet vero doloribus quia." },
                    { 290, 15, null, 1, new DateTime(2022, 9, 11, 5, 36, 1, 270, DateTimeKind.Local).AddTicks(6306), "Totam dicta ut fugiat vero distinctio non eos.\nAut consequatur molestias ut cupiditate in." },
                    { 291, 11, null, 3, new DateTime(2022, 4, 16, 6, 13, 48, 580, DateTimeKind.Local).AddTicks(1536), "Similique porro temporibus illo natus error et quia in.\nVoluptate nihil sed dolorum et sed et." },
                    { 292, 2, null, 8, new DateTime(2022, 8, 25, 14, 55, 17, 608, DateTimeKind.Local).AddTicks(6656), "Ratione eaque ea enim.\nSit voluptatum eius ipsam sed tempora voluptas repudiandae." },
                    { 293, 18, null, 3, new DateTime(2022, 4, 9, 21, 19, 9, 823, DateTimeKind.Local).AddTicks(2923), "Veritatis cumque non aut a delectus non perspiciatis sapiente et.\nIn et voluptatem eveniet adipisci." },
                    { 294, 20, null, 8, new DateTime(2022, 6, 16, 0, 10, 20, 619, DateTimeKind.Local).AddTicks(9919), "Sunt enim nam cumque et necessitatibus earum est vel reiciendis.\nQuidem nemo ab qui dolorem et reiciendis laborum culpa at." },
                    { 295, 9, null, 1, new DateTime(2022, 5, 15, 7, 58, 59, 218, DateTimeKind.Local).AddTicks(368), "Veniam sapiente totam enim dolores aut et blanditiis nihil velit.\nAut alias ea." },
                    { 296, 11, null, 4, new DateTime(2022, 3, 28, 18, 8, 54, 552, DateTimeKind.Local).AddTicks(6234), "Architecto eaque dolor eveniet assumenda quidem iste.\nImpedit occaecati ducimus et esse alias sequi architecto minima." },
                    { 297, 4, null, 7, new DateTime(2022, 7, 17, 4, 42, 6, 578, DateTimeKind.Local).AddTicks(4553), "Ducimus qui quibusdam enim dolorem ipsam deleniti deserunt doloremque ipsam.\nVeniam eos corrupti." },
                    { 298, 16, null, 10, new DateTime(2022, 10, 2, 15, 58, 7, 518, DateTimeKind.Local).AddTicks(993), "Nam ipsam incidunt eos quidem sunt.\nQuidem et odio necessitatibus saepe et possimus error dolor." },
                    { 299, 13, null, 9, new DateTime(2022, 9, 4, 16, 49, 55, 154, DateTimeKind.Local).AddTicks(4139), "Dolorem sit neque et et nihil voluptates maiores ut.\nAdipisci eos consequuntur saepe ut eaque molestiae expedita quia ducimus." },
                    { 300, 10, null, 10, new DateTime(2022, 11, 11, 13, 25, 25, 578, DateTimeKind.Local).AddTicks(6203), "Doloremque labore impedit et magni dolores.\nDicta veritatis et aliquam vitae asperiores aut aut ut." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 1, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborum voluptatibus quidem nemo sunt qui." },
                    { 2, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem nulla dolorum modi molestiae minima." },
                    { 3, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odit amet at necessitatibus in cum." },
                    { 4, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut minus et sunt libero quae." },
                    { 5, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asperiores tenetur facilis et sequi totam." },
                    { 6, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impedit quibusdam et doloribus et vel." },
                    { 7, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed et omnis qui sequi molestias." },
                    { 8, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspernatur qui blanditiis non ipsa autem." },
                    { 9, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptates quidem fuga aut veniam excepturi." },
                    { 10, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostrum odit aperiam maxime qui veniam." },
                    { 11, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsa vero consequatur fugiat officiis laudantium." },
                    { 12, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blanditiis et nam aut enim provident." },
                    { 13, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi ipsam ut optio quis inventore." },
                    { 14, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequuntur ut molestiae excepturi ratione nemo." },
                    { 15, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temporibus natus ipsa deleniti in sunt." },
                    { 16, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita consectetur dolores voluptatum est rerum." },
                    { 17, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum quae omnis suscipit dolorem nihil." },
                    { 18, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero aut aut dolor rerum nulla." },
                    { 19, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumque eaque corrupti ullam sed debitis." },
                    { 20, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non atque aperiam commodi veniam omnis." },
                    { 21, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam voluptates cupiditate ipsa ut est." },
                    { 22, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem voluptas voluptate qui qui incidunt." },
                    { 23, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tempore omnis nostrum iure provident qui." },
                    { 24, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritatis quisquam nesciunt eum neque tenetur." },
                    { 25, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam nesciunt tempora enim doloremque amet." },
                    { 26, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est blanditiis ipsa voluptatem sed quia." },
                    { 27, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero quas rerum voluptate alias cupiditate." },
                    { 28, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur quibusdam porro facere asperiores magni." },
                    { 29, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia eaque est sit occaecati est." },
                    { 30, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam repellendus corrupti consequatur repellat aut." },
                    { 31, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natus quos qui aut possimus qui." },
                    { 32, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil ducimus animi doloribus dignissimos est." },
                    { 33, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque reiciendis numquam minus ratione sint." },
                    { 34, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum laboriosam asperiores laborum et tenetur." },
                    { 35, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil modi deserunt repellendus rerum iure." },
                    { 36, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem quos quis aut ex et." },
                    { 37, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occaecati aliquid itaque ex veritatis consequatur." },
                    { 38, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum rerum cumque recusandae et magnam." },
                    { 39, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae ad ut omnis accusamus corporis." },
                    { 40, null, 9, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil eligendi est neque consequuntur possimus." },
                    { 41, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidunt at nihil dolore soluta vitae." },
                    { 42, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex tenetur enim dicta exercitationem odio." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 43, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et voluptatibus et ut quos consequuntur." },
                    { 44, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus est velit et beatae dolore." },
                    { 45, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magni qui omnis accusantium iste ad." },
                    { 46, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quidem odit natus illum placeat nisi." },
                    { 47, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esse at nesciunt autem est aut." },
                    { 48, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non repudiandae nam expedita perferendis consequatur." },
                    { 49, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est voluptates esse quidem molestiae aliquam." },
                    { 50, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque natus temporibus adipisci corporis voluptas." },
                    { 51, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptate vel nulla necessitatibus iusto et." },
                    { 52, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea eos cumque amet doloremque distinctio." },
                    { 53, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum consequatur autem tenetur rerum eos." },
                    { 54, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus et voluptatum alias nulla ex." },
                    { 55, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum maiores non voluptas est tempora." },
                    { 56, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi deleniti neque itaque neque ex." },
                    { 57, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quidem quis quasi aspernatur eveniet repellat." },
                    { 58, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit aut similique tempora quo consequatur." },
                    { 59, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae dolores officia eos enim qui." },
                    { 60, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut rem laborum quisquam possimus consequatur." },
                    { 61, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos commodi veniam accusamus fuga est." },
                    { 62, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inventore porro sequi facere dicta ad." },
                    { 63, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem a minus rerum sunt dolor." },
                    { 64, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui maiores earum sit quos sed." },
                    { 65, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur consequatur ad sed id expedita." },
                    { 66, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem corrupti odit quaerat natus labore." },
                    { 67, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut sit consequuntur numquam accusantium repellendus." },
                    { 68, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusamus laudantium iste fuga sunt ipsa." },
                    { 69, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritatis quisquam veritatis aut perspiciatis architecto." },
                    { 70, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est sequi est corporis explicabo qui." },
                    { 71, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed sed porro ullam asperiores nulla." },
                    { 72, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impedit eos minus est est cupiditate." },
                    { 73, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas amet non possimus consequuntur quis." },
                    { 74, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis occaecati eligendi sapiente et asperiores." },
                    { 75, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo voluptate voluptas voluptates repellat adipisci." },
                    { 76, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab consequatur autem in atque ut." },
                    { 77, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non inventore aspernatur omnis et itaque." },
                    { 78, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloremque nesciunt veritatis maxime facilis ducimus." },
                    { 79, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim corrupti quae ut voluptatem amet." },
                    { 80, null, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perferendis rem rem ut minima quaerat." },
                    { 81, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam delectus eos unde pariatur consequatur." },
                    { 82, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et nemo veniam vel repudiandae pariatur." },
                    { 83, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeat dolores voluptatum sint est cupiditate." },
                    { 84, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis praesentium eum adipisci explicabo et." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 85, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est natus assumenda dolores minima soluta." },
                    { 86, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tempore ducimus perferendis quod et eum." },
                    { 87, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est possimus omnis at hic qui." },
                    { 88, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eaque ab iusto blanditiis harum officiis." },
                    { 89, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor nulla a quisquam non deserunt." },
                    { 90, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellendus incidunt eos eum deserunt qui." },
                    { 91, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut occaecati aut distinctio sed officiis." },
                    { 92, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occaecati qui libero occaecati delectus numquam." },
                    { 93, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit quos sit recusandae sint fugit." },
                    { 94, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pariatur voluptas omnis alias eveniet eos." },
                    { 95, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci quia ut tempora delectus assumenda." },
                    { 96, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui itaque aut porro est ab." },
                    { 97, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem aut rerum qui cumque voluptatem." },
                    { 98, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumque harum ut sint similique ducimus." },
                    { 99, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem ducimus inventore ab qui voluptas." },
                    { 100, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint qui ab consequatur veritatis quae." },
                    { 101, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recusandae in hic architecto dicta ut." },
                    { 102, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et officia quia hic amet iste." },
                    { 103, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut repudiandae aperiam et eligendi non." },
                    { 104, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa accusamus cumque in nulla ex." },
                    { 105, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspernatur itaque ea eos quidem praesentium." },
                    { 106, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos culpa qui quo consectetur in." },
                    { 107, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel rerum alias non sit quisquam." },
                    { 108, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos iure libero maiores explicabo nam." },
                    { 109, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui assumenda provident inventore sint perferendis." },
                    { 110, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perferendis vel quia odit facere ipsum." },
                    { 111, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit et repellendus ducimus itaque aperiam." },
                    { 112, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et id similique ipsa quia placeat." },
                    { 113, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostrum explicabo fugiat est et velit." },
                    { 114, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobis nam ducimus quo voluptatem expedita." },
                    { 115, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas rerum repellat totam deleniti aspernatur." },
                    { 116, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex eum quo maxime in labore." },
                    { 117, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui vel molestiae voluptatem doloribus et." },
                    { 118, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam aut eius quo enim omnis." },
                    { 119, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et deleniti debitis et voluptates ut." },
                    { 120, null, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem eum quod amet impedit dolores." },
                    { 121, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numquam velit dolores quisquam ullam ut." },
                    { 122, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit consequatur et assumenda dolores sit." },
                    { 123, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esse impedit dolores laudantium ut vero." },
                    { 124, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deleniti voluptas expedita magni mollitia voluptas." },
                    { 125, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumque reprehenderit quidem vel est vitae." },
                    { 126, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo expedita dolor perspiciatis ut eius." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 127, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eligendi ea unde fugiat suscipit nemo." },
                    { 128, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellat similique quod molestiae voluptatum consectetur." },
                    { 129, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et alias deserunt dolores odit ut." },
                    { 130, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium rem rerum nemo iusto rerum." },
                    { 131, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum illum nam maiores et voluptas." },
                    { 132, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut adipisci sed quam sunt laudantium." },
                    { 133, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et in est voluptas suscipit ea." },
                    { 134, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pariatur mollitia sint dolorum eaque aliquam." },
                    { 135, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Distinctio et quia doloremque sint quos." },
                    { 136, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut optio neque quas laudantium ut." },
                    { 137, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit dolor soluta est reprehenderit non." },
                    { 138, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harum aut dignissimos numquam voluptatem officiis." },
                    { 139, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quam sed eaque dolorem quidem ut." },
                    { 140, null, 8, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis voluptatem corporis eveniet asperiores placeat." },
                    { 141, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum fugit eius dolores reiciendis et." },
                    { 142, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit natus fuga quia voluptatibus aperiam." },
                    { 143, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delectus aut velit odio dolor saepe." },
                    { 144, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis temporibus eos a maiores quibusdam." },
                    { 145, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id et animi distinctio totam et." },
                    { 146, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae modi dolorem velit magni consequuntur." },
                    { 147, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis excepturi et dolores ab dignissimos." },
                    { 148, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quod eos id soluta tempore nam." },
                    { 149, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos amet sapiente accusamus accusantium sit." },
                    { 150, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspernatur neque mollitia illum hic sed." },
                    { 151, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel officiis sit nemo vel sit." },
                    { 152, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perspiciatis impedit rerum reiciendis cupiditate sit." },
                    { 153, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim rerum excepturi quia beatae et." },
                    { 154, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit accusantium et omnis dolorum aliquam." },
                    { 155, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae tempora et voluptas nesciunt aut." },
                    { 156, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum totam qui dolores ut at." },
                    { 157, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In modi ducimus suscipit minus tempore." },
                    { 158, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil culpa nulla perferendis et cumque." },
                    { 159, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi nulla consequuntur repellat voluptas illum." },
                    { 160, null, 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suscipit odit officiis aperiam rem laborum." },
                    { 161, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magni dicta qui similique eos est." },
                    { 162, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla ipsam non quidem est voluptates." },
                    { 163, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nisi molestiae unde expedita et sunt." },
                    { 164, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur sunt asperiores autem autem occaecati." },
                    { 165, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit occaecati debitis earum non quis." },
                    { 166, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium rerum non placeat labore perferendis." },
                    { 167, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam accusamus soluta tempore aut quaerat." },
                    { 168, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reiciendis mollitia earum explicabo impedit reiciendis." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 169, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est tempora nobis optio iste consectetur." },
                    { 170, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeat sunt impedit dolore nulla dolor." },
                    { 171, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iusto at sed architecto officiis non." },
                    { 172, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia adipisci assumenda incidunt placeat enim." },
                    { 173, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi et pariatur esse porro nihil." },
                    { 174, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum accusantium minus ut qui modi." },
                    { 175, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est reprehenderit quaerat et quia odio." },
                    { 176, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidunt iste doloribus incidunt error veritatis." },
                    { 177, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soluta et porro quia nihil dolor." },
                    { 178, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem saepe ut cupiditate voluptas pariatur." },
                    { 179, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et asperiores quo exercitationem et magni." },
                    { 180, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum sapiente culpa consequatur optio itaque." },
                    { 181, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium ducimus unde soluta nobis blanditiis." },
                    { 182, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deleniti totam totam reiciendis debitis nostrum." },
                    { 183, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit et aut est quod repellat." },
                    { 184, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blanditiis deleniti rerum nisi consectetur commodi." },
                    { 185, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquid enim sapiente asperiores voluptatem ea." },
                    { 186, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum labore est velit est et." },
                    { 187, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut corporis aut earum delectus mollitia." },
                    { 188, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolore in nisi reprehenderit harum non." },
                    { 189, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minima dignissimos alias iusto in quibusdam." },
                    { 190, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam aliquid explicabo debitis voluptatem quaerat." },
                    { 191, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus ut sit iure in atque." },
                    { 192, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id quis recusandae temporibus molestiae eos." },
                    { 193, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis vitae doloribus ad nihil consequatur." },
                    { 194, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quam nulla harum accusamus sunt aut." },
                    { 195, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquid reprehenderit illo placeat labore inventore." },
                    { 196, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut consequuntur impedit commodi corrupti perspiciatis." },
                    { 197, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit earum et veniam illum debitis." },
                    { 198, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et quia consequatur est molestiae cumque." },
                    { 199, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et tempore nostrum ut atque repudiandae." },
                    { 200, null, 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quaerat possimus nihil autem vitae consectetur." },
                    { 201, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iste praesentium vero aliquid accusantium est." },
                    { 202, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut repudiandae omnis illum ea non." },
                    { 203, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde earum expedita est corporis repellendus." },
                    { 204, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus quae dolor asperiores ex officia." },
                    { 205, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenetur enim tempora pariatur officia enim." },
                    { 206, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem nemo ea exercitationem velit qui." },
                    { 207, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus facilis officiis enim ex magni." },
                    { 208, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id ea cumque nihil repellendus optio." },
                    { 209, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint unde cupiditate est cupiditate adipisci." },
                    { 210, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores nemo voluptas rerum fugiat ut." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 211, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum sunt officia voluptatem minima reprehenderit." },
                    { 212, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium iste nulla aspernatur officiis sint." },
                    { 213, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellat nam cumque non eligendi ducimus." },
                    { 214, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A maxime officia aut cum esse." },
                    { 215, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad deleniti eveniet mollitia dolores omnis." },
                    { 216, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam iste dolores ad ut dolorum." },
                    { 217, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere quibusdam est exercitationem optio sed." },
                    { 218, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo sapiente amet eum rerum maiores." },
                    { 219, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quod corrupti numquam suscipit et sunt." },
                    { 220, null, 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In dolor enim voluptates cumque sed." },
                    { 221, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laboriosam cumque quia velit aut labore." },
                    { 222, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non voluptatem dolorem rerum reprehenderit rerum." },
                    { 223, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dicta modi adipisci distinctio molestias magni." },
                    { 224, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum sed ut temporibus delectus laborum." },
                    { 225, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur fugit dolores quis dignissimos aut." },
                    { 226, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus ad doloremque odit esse consequatur." },
                    { 227, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem enim corrupti quis rerum sapiente." },
                    { 228, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et nemo aut placeat sunt blanditiis." },
                    { 229, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odit quos nobis autem iusto officia." },
                    { 230, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae quisquam rerum recusandae similique quae." },
                    { 231, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis officia id aut porro rerum." },
                    { 232, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostrum consequatur voluptatem quae aspernatur temporibus." },
                    { 233, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nesciunt perspiciatis molestiae vel quo reiciendis." },
                    { 234, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem explicabo tempora assumenda perspiciatis dolorum." },
                    { 235, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est dignissimos tempora aliquam vel et." },
                    { 236, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex soluta cumque et ut doloremque." },
                    { 237, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos itaque unde natus ut quia." },
                    { 238, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia non debitis non dicta omnis." },
                    { 239, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui quo accusamus et eaque nostrum." },
                    { 240, null, 7, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "At ut provident nobis molestias commodi." },
                    { 241, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quod dolor quidem id deserunt commodi." },
                    { 242, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae est tempora sit quod aut." },
                    { 243, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius ad odio et impedit ut." },
                    { 244, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur nobis esse autem incidunt nulla." },
                    { 245, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita eaque natus magnam et dicta." },
                    { 246, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non ex sunt minima nisi officia." },
                    { 247, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores repellat quasi pariatur tempora doloremque." },
                    { 248, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim architecto ea hic maxime officia." },
                    { 249, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nesciunt aperiam at qui et voluptas." },
                    { 250, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porro quaerat aperiam aspernatur qui beatae." },
                    { 251, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natus et est rerum autem ut." },
                    { 252, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Architecto nostrum eligendi sit tempora id." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 253, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est quia quis alias blanditiis placeat." },
                    { 254, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde necessitatibus at corrupti provident enim." },
                    { 255, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores quam sed amet dignissimos odio." },
                    { 256, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut qui totam eos necessitatibus pariatur." },
                    { 257, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere corrupti laboriosam et et earum." },
                    { 258, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem voluptatem qui reprehenderit delectus perspiciatis." },
                    { 259, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus pariatur fuga laborum dolore ipsa." },
                    { 260, null, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt ipsum impedit rem vitae facere." },
                    { 261, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occaecati facere magnam quia optio nemo." },
                    { 262, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt vero quibusdam sapiente in sapiente." },
                    { 263, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia et et doloribus earum modi." },
                    { 264, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunt est eaque omnis veritatis voluptatem." },
                    { 265, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus perspiciatis velit unde a repellat." },
                    { 266, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia unde modi quia iste at." },
                    { 267, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiente unde voluptatem illo quisquam minima." },
                    { 268, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuga deserunt sit deserunt id dolorum." },
                    { 269, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est vel quidem at eos totam." },
                    { 270, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labore suscipit possimus ut omnis recusandae." },
                    { 271, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquid explicabo ea officia aut quasi." },
                    { 272, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores sed voluptatibus magnam voluptas enim." },
                    { 273, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritatis voluptatum tempora facere repudiandae est." },
                    { 274, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiente ab adipisci velit omnis reiciendis." },
                    { 275, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea consequatur quos velit incidunt ipsa." },
                    { 276, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel asperiores dolorum omnis quae amet." },
                    { 277, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occaecati ab similique voluptas amet qui." },
                    { 278, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut est facere blanditiis similique aut." },
                    { 279, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet iusto repellendus nihil quisquam quidem." },
                    { 280, null, 3, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus quasi aut optio totam alias." },
                    { 281, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odio et nihil est delectus fuga." },
                    { 282, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minima eos accusantium qui eum voluptas." },
                    { 283, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium autem voluptatem dolor autem velit." },
                    { 284, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fugiat fugiat nam unde repellendus ut." },
                    { 285, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui velit amet eaque nemo nemo." },
                    { 286, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Possimus enim vero debitis autem dolore." },
                    { 287, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum suscipit repellendus adipisci provident culpa." },
                    { 288, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia odit reprehenderit natus voluptatem qui." },
                    { 289, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilis eius in non incidunt id." },
                    { 290, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor id quo modi et fuga." },
                    { 291, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellendus aspernatur est quaerat dolor odit." },
                    { 292, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem hic numquam magnam soluta neque." },
                    { 293, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae doloremque consequatur aut molestiae sed." },
                    { 294, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil ad animi nisi nostrum eius." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 295, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis ducimus aut eos quaerat laboriosam." },
                    { 296, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saepe facere harum optio illum libero." },
                    { 297, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cupiditate harum molestias quia fuga magni." },
                    { 298, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos veniam provident omnis ullam omnis." },
                    { 299, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxime ratione aut et et sint." },
                    { 300, null, 10, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id qui alias soluta enim explicabo." },
                    { 301, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptates illum rerum consequatur illo eveniet." },
                    { 302, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolore magnam dolore et amet a." },
                    { 303, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tempore quo rerum ea molestiae qui." },
                    { 304, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed rerum quam animi ad vitae." },
                    { 305, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut molestias modi placeat perspiciatis esse." },
                    { 306, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxime consequatur deleniti ullam quae eligendi." },
                    { 307, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere vero qui nesciunt sequi non." },
                    { 308, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non magnam aut voluptate sunt sequi." },
                    { 309, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non sunt porro officiis ipsum excepturi." },
                    { 310, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos consectetur possimus similique autem qui." },
                    { 311, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sequi rerum eveniet et suscipit cum." },
                    { 312, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic sequi dicta officiis autem corrupti." },
                    { 313, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reiciendis repudiandae quia officiis est delectus." },
                    { 314, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem sunt voluptatibus neque sint tempore." },
                    { 315, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iure aperiam ab et nemo non." },
                    { 316, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur labore quia ipsa et maiores." },
                    { 317, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur ipsam est distinctio quo necessitatibus." },
                    { 318, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidunt dolores enim omnis quisquam esse." },
                    { 319, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui libero necessitatibus magnam doloribus eveniet." },
                    { 320, null, 1, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suscipit doloremque velit repudiandae quasi inventore." },
                    { 321, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita eveniet distinctio quo nihil eligendi." },
                    { 322, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iste unde molestiae dolores non vel." },
                    { 323, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fugiat quasi et ipsa dolorem enim." },
                    { 324, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saepe iste omnis animi cumque nesciunt." },
                    { 325, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo officiis error ab quam nisi." },
                    { 326, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem dolorum consequatur voluptatum recusandae error." },
                    { 327, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laboriosam nisi veritatis ea molestiae illo." },
                    { 328, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus quia quia officia at numquam." },
                    { 329, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas aperiam repellendus dolor delectus quia." },
                    { 330, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiente eligendi laborum aspernatur voluptate quibusdam." },
                    { 331, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostrum dicta et et placeat voluptatibus." },
                    { 332, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Possimus nihil similique quasi nihil pariatur." },
                    { 333, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestiae et ad maxime non ratione." },
                    { 334, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut mollitia eum sequi ut ullam." },
                    { 335, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur natus est et ea sapiente." },
                    { 336, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci qui iure accusamus consequatur rerum." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 337, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium ea atque sunt sunt eaque." },
                    { 338, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non dolorem dolorem excepturi inventore eveniet." },
                    { 339, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquam quo provident aut id distinctio." },
                    { 340, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea et et et aperiam quis." },
                    { 341, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor assumenda repellat numquam eius delectus." },
                    { 342, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo enim est itaque blanditiis omnis." },
                    { 343, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inventore dolorem quasi dolorem eos dolores." },
                    { 344, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui hic dicta consequatur reprehenderit fuga." },
                    { 345, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic rerum hic sint deleniti qui." },
                    { 346, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui consequatur doloribus ut occaecati dolorum." },
                    { 347, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut eum est est eligendi rerum." },
                    { 348, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas sit aspernatur ut magni illo." },
                    { 349, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem amet nihil earum eveniet nihil." },
                    { 350, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et delectus sed voluptas aut assumenda." },
                    { 351, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusantium molestias ea quo ut neque." },
                    { 352, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maiores fuga molestiae vitae voluptatem odio." },
                    { 353, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maiores cumque beatae aliquid et et." },
                    { 354, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborum rem nihil hic adipisci iusto." },
                    { 355, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem nam sint ullam aliquam enim." },
                    { 356, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeat molestiae id ipsam natus quia." },
                    { 357, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur amet quisquam consequatur tempora eos." },
                    { 358, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut et recusandae rerum maxime aut." },
                    { 359, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunt quod modi autem ut repellendus." },
                    { 360, null, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla ut error et architecto earum." },
                    { 361, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut repudiandae et deserunt libero facere." },
                    { 362, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repudiandae pariatur natus et non ullam." },
                    { 363, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis et ut sint consequatur consequatur." },
                    { 364, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iusto laborum quis nobis temporibus in." },
                    { 365, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nisi excepturi voluptas et sed dolorem." },
                    { 366, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem assumenda nihil cupiditate hic unde." },
                    { 367, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veniam beatae assumenda labore vel consequatur." },
                    { 368, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui nihil distinctio officia velit dolores." },
                    { 369, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum iure temporibus sit consequatur laborum." },
                    { 370, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex et natus eum distinctio cupiditate." },
                    { 371, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia quam assumenda qui ea quia." },
                    { 372, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquid aliquid laboriosam sed reiciendis magni." },
                    { 373, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil quis rerum laudantium mollitia repellendus." },
                    { 374, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis eligendi et officiis similique perferendis." },
                    { 375, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit qui et ut nihil quo." },
                    { 376, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea perspiciatis quis dolor doloribus sed." },
                    { 377, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est facere est inventore non aliquid." },
                    { 378, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem consequuntur mollitia sed distinctio odio." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 379, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem dolores sint et ullam impedit." },
                    { 380, null, 4, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut doloremque inventore aliquid sapiente est." },
                    { 381, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iste facere optio amet cupiditate repudiandae." },
                    { 382, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et atque quidem quas ut architecto." },
                    { 383, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut magnam architecto atque rerum id." },
                    { 384, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non odio repellendus aliquam labore et." },
                    { 385, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa deleniti dolore nihil dolor minima." },
                    { 386, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum omnis aut velit voluptas modi." },
                    { 387, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animi sunt non quis earum repudiandae." },
                    { 388, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut adipisci impedit ratione itaque quam." },
                    { 389, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem ratione corrupti est doloremque blanditiis." },
                    { 390, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quibusdam explicabo earum id aliquid perspiciatis." },
                    { 391, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rem esse inventore unde sint quam." },
                    { 392, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil reprehenderit maiores minima perferendis rerum." },
                    { 393, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esse et minima vel cupiditate consectetur." },
                    { 394, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ratione eius labore accusantium est quod." },
                    { 395, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut molestiae minima dolor voluptas et." },
                    { 396, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt quia ut occaecati repudiandae omnis." },
                    { 397, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius ut libero rerum quod aliquid." },
                    { 398, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut qui tempora eos animi enim." },
                    { 399, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas cumque quod aut maxime accusantium." },
                    { 400, null, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic omnis ut laborum nulla ea." },
                    { 401, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque neque numquam totam optio fugit." },
                    { 402, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temporibus doloremque quidem omnis harum nihil." },
                    { 403, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim excepturi ut nihil voluptas nihil." },
                    { 404, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla minima a quae impedit consequatur." },
                    { 405, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In ut nemo natus praesentium rerum." },
                    { 406, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provident aut beatae fuga maxime id." },
                    { 407, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis suscipit veritatis quae consequuntur ullam." },
                    { 408, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel magni quis dolores error quis." },
                    { 409, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saepe cupiditate ducimus autem non ut." },
                    { 410, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeat repellendus fugiat libero adipisci quis." },
                    { 411, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil aut exercitationem nisi aut ut." },
                    { 412, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illum corporis aut minima sit similique." },
                    { 413, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellat impedit ratione quas pariatur minus." },
                    { 414, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab eos quisquam laudantium et nam." },
                    { 415, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia odio veritatis et quibusdam libero." },
                    { 416, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amet voluptatem molestiae earum velit rerum." },
                    { 417, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pariatur qui dolores porro qui soluta." },
                    { 418, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed accusantium placeat est omnis fugit." },
                    { 419, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea eos repudiandae qui quod laudantium." },
                    { 420, null, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quidem mollitia possimus qui inventore amet." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 421, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id saepe dolor accusamus atque quo." },
                    { 422, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam aliquid porro qui suscipit non." },
                    { 423, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est autem ex eveniet et voluptatem." },
                    { 424, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus sunt iusto facere reiciendis id." },
                    { 425, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iusto asperiores et placeat cupiditate iure." },
                    { 426, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illo architecto voluptas voluptatibus voluptas eius." },
                    { 427, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assumenda libero dolores repellat dolor enim." },
                    { 428, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusamus eaque sed alias temporibus nobis." },
                    { 429, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit aut exercitationem illo distinctio eum." },
                    { 430, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo corrupti in harum error nostrum." },
                    { 431, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenetur quos autem laudantium nostrum fugit." },
                    { 432, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea dolorem quia voluptatem dolorem vel." },
                    { 433, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem odit ipsum ut cum libero." },
                    { 434, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia provident est aspernatur totam et." },
                    { 435, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asperiores repellendus voluptas non nam laboriosam." },
                    { 436, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ratione voluptas id molestiae ducimus eum." },
                    { 437, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae placeat eius aut quisquam nam." },
                    { 438, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum tempore maiores aliquid occaecati et." },
                    { 439, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex dicta explicabo ratione accusantium est." },
                    { 440, null, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel placeat repellat ab ut quidem." },
                    { 441, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illum necessitatibus laboriosam cum dolor voluptatem." },
                    { 442, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur et eos saepe iusto magni." },
                    { 443, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non perferendis quos excepturi quia qui." },
                    { 444, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eaque animi qui cum ut fuga." },
                    { 445, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit maxime ut omnis nihil non." },
                    { 446, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum blanditiis explicabo ducimus et quae." },
                    { 447, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut commodi voluptatem in necessitatibus aut." },
                    { 448, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestias expedita nobis odio eos fugiat." },
                    { 449, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit quibusdam exercitationem recusandae ducimus odit." },
                    { 450, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur suscipit quis error rerum non." },
                    { 451, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas beatae enim aut laborum a." },
                    { 452, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius vitae excepturi corrupti asperiores neque." },
                    { 453, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est excepturi et consequuntur dolorem possimus." },
                    { 454, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborum non soluta cupiditate enim quibusdam." },
                    { 455, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero ratione rerum eveniet unde suscipit." },
                    { 456, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellat quia voluptatem impedit mollitia non." },
                    { 457, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim explicabo fugit explicabo odio voluptatem." },
                    { 458, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquam voluptates delectus odio vero odio." },
                    { 459, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit ea vero accusamus laudantium deserunt." },
                    { 460, null, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut veritatis corporis asperiores velit minus." },
                    { 461, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatae eius aut rerum voluptatem voluptatem." },
                    { 462, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia et ab eum fugiat provident." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 463, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In suscipit delectus itaque nesciunt culpa." },
                    { 464, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non vel explicabo exercitationem enim aut." },
                    { 465, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et ab consequatur voluptas et beatae." },
                    { 466, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occaecati aliquid laborum aut quo illo." },
                    { 467, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborum illum non excepturi veritatis quaerat." },
                    { 468, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porro deleniti et laborum aut ab." },
                    { 469, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis ex aut et cumque autem." },
                    { 470, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem et delectus adipisci et aut." },
                    { 471, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hic optio ab neque quia quidem." },
                    { 472, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saepe sapiente similique possimus nostrum voluptatem." },
                    { 473, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et enim nihil error fugiat autem." },
                    { 474, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde distinctio iusto possimus sed quas." },
                    { 475, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut quod ut consequatur ea et." },
                    { 476, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit corporis nihil numquam temporibus sint." },
                    { 477, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nam et eos sed iure ad." },
                    { 478, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harum deleniti doloribus non repudiandae nulla." },
                    { 479, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero nisi aut quod amet aut." },
                    { 480, null, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illo fugit voluptates assumenda nam quos." },
                    { 481, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veniam aperiam magnam repudiandae suscipit excepturi." },
                    { 482, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas ratione odio odio voluptatum impedit." },
                    { 483, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia iusto neque est similique eos." },
                    { 484, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labore culpa ea qui adipisci et." },
                    { 485, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesentium quia eaque sint repellendus tenetur." },
                    { 486, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veniam et dolore id ab id." },
                    { 487, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam hic aut ab dolorem id." },
                    { 488, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero dolor eaque perspiciatis voluptate rerum." },
                    { 489, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas quod itaque eveniet atque velit." },
                    { 490, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo qui quod laborum sint porro." },
                    { 491, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus est sequi excepturi sunt dignissimos." },
                    { 492, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptates sit sequi qui ipsum et." },
                    { 493, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eligendi quas aut hic rem temporibus." },
                    { 494, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et aperiam consequatur repellat alias dolor." },
                    { 495, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ratione omnis voluptate sit eaque perspiciatis." },
                    { 496, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut est ducimus quia sequi temporibus." },
                    { 497, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit nihil repellendus quas delectus suscipit." },
                    { 498, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam est omnis ullam autem fuga." },
                    { 499, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestias quibusdam eum necessitatibus et aut." },
                    { 500, null, 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque totam dignissimos vel omnis necessitatibus." },
                    { 501, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunt quisquam facilis sit voluptatem error." },
                    { 502, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem magnam accusantium commodi voluptatem dolorum." },
                    { 503, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeat est est nemo ea molestiae." },
                    { 504, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas distinctio sed et natus minus." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 505, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus ab sed maxime soluta saepe." },
                    { 506, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas quis placeat deserunt aut labore." },
                    { 507, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nisi quia tempore porro voluptas et." },
                    { 508, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iure asperiores provident delectus voluptas ut." },
                    { 509, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritatis est consequuntur nemo eum nihil." },
                    { 510, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amet qui commodi dicta nemo eaque." },
                    { 511, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea et qui et officiis reiciendis." },
                    { 512, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perspiciatis sint incidunt quis repellendus tenetur." },
                    { 513, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et accusamus maiores pariatur qui eos." },
                    { 514, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et est quis rerum sit voluptatum." },
                    { 515, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quibusdam omnis ut asperiores consequatur quam." },
                    { 516, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem non laborum sed quo molestiae." },
                    { 517, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aperiam magni ea incidunt qui quia." },
                    { 518, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem eum autem et officiis et." },
                    { 519, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expedita tenetur voluptatibus ea laudantium non." },
                    { 520, null, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provident cumque earum assumenda est esse." },
                    { 521, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quam itaque architecto perferendis consequatur amet." },
                    { 522, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia non accusantium repudiandae illum quam." },
                    { 523, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam tempore mollitia saepe aut et." },
                    { 524, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id et sunt voluptas pariatur et." },
                    { 525, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam dignissimos omnis fuga eveniet inventore." },
                    { 526, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animi iste quidem repudiandae sint et." },
                    { 527, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum est nam quaerat cumque provident." },
                    { 528, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem possimus blanditiis explicabo dolorem ea." },
                    { 529, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est minima dolores nihil tempora eius." },
                    { 530, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem sint tempore quam porro omnis." },
                    { 531, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et necessitatibus ab ut et dolorem." },
                    { 532, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas ut quas repellendus modi quis." },
                    { 533, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excepturi asperiores est numquam quas ad." },
                    { 534, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amet accusantium quia optio ad maiores." },
                    { 535, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Possimus repellat non repellat et quae." },
                    { 536, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fugiat sunt et et ut commodi." },
                    { 537, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunt qui voluptas rerum a reprehenderit." },
                    { 538, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aperiam qui et quia dolorum voluptatem." },
                    { 539, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur occaecati inventore ut sed odio." },
                    { 540, null, 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo nobis laborum adipisci nobis inventore." },
                    { 541, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor tempore quia impedit reprehenderit doloribus." },
                    { 542, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numquam excepturi nam enim vel odio." },
                    { 543, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut nemo et quo ut dignissimos." },
                    { 544, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque iste voluptatem magnam fuga temporibus." },
                    { 545, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo eum id quam ipsum voluptas." },
                    { 546, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perferendis voluptatem quidem placeat in officiis." }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "IsDeletedOnlyForSender", "ReceiverId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 547, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et dolores voluptatibus exercitationem quae consequatur." },
                    { 548, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde est dolore est amet saepe." },
                    { 549, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed dolore eum hic maxime aut." },
                    { 550, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit voluptas quos inventore saepe nihil." },
                    { 551, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In aut in itaque vel rem." },
                    { 552, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et eius voluptate dolorem quae et." },
                    { 553, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mollitia dolorem unde rerum sit quidem." },
                    { 554, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deleniti ut laudantium in aliquam eius." },
                    { 555, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neque quibusdam nobis ut exercitationem dicta." },
                    { 556, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellat assumenda blanditiis sit repellat sint." },
                    { 557, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia voluptas nisi doloribus voluptatem vel." },
                    { 558, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natus voluptatem rerum eos quia iure." },
                    { 559, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et dolores non exercitationem quas quia." },
                    { 560, null, 4, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsam enim labore et ratione optio." }
                });

            migrationBuilder.InsertData(
                table: "UserContacts",
                columns: new[] { "ContactUserId", "UserId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 7, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 7, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 8, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 6, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 5 },
                    { 3, 6 },
                    { 7, 6 },
                    { 9, 6 },
                    { 2, 7 },
                    { 10, 7 },
                    { 1, 8 },
                    { 4, 8 },
                    { 7, 8 },
                    { 4, 9 },
                    { 7, 9 },
                    { 8, 9 },
                    { 3, 10 },
                    { 8, 10 },
                    { 9, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUser_MembersId",
                table: "ChatUser",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_ReceiverId",
                table: "PrivateMessages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_SenderId",
                table: "PrivateMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_ContactUserId",
                table: "UserContacts",
                column: "ContactUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChatUser");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PrivateMessages");

            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
