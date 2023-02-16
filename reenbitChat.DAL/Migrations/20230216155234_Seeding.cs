using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reenbitChat.DAL.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastSeen", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhotoUrl", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "21fa4f9b-9172-4941-813e-cfd4b4f8f48d", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Ivory.Parker54@gmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=48", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Rupert" },
                    { 2, 0, "69419c05-4a80-4468-9fad-f66b4ef8bec8", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Obie3@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=998", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Vella" },
                    { 3, 0, "b1890cb6-b30a-42a4-9f84-cb3d1fe6a544", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Lennie_Glover8@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=93", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Marilie" },
                    { 4, 0, "4896d4a2-9f3d-40d2-a572-ac379bbfbfe7", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Candelario_Olson@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=185", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sylvan" },
                    { 5, 0, "0b2ec3fc-4b7c-4a1e-98c8-25e832a2815c", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Edward.Raynor@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=790", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Chase" },
                    { 6, 0, "36f48a10-12fc-4df4-936d-89348a138693", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Brando70@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=1043", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Hilario" },
                    { 7, 0, "c0e7b9c0-4b39-4bd5-a7e5-46f3159b6a12", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Gianni26@yahoo.com", null, null, null, false, "https://picsum.photos/480/480/?image=914", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Krystel" },
                    { 8, 0, "fdb58ddf-180a-4625-b486-9a7f9c9359e5", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Eva.Hane11@gmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=712", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kale" },
                    { 9, 0, "fd081ca4-4b77-4af2-b6ee-6ab7ac633268", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Nikita31@hotmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=291", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fleta" },
                    { 10, 0, "5e6976c2-d871-4f58-8a17-94fea889821f", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Milan_Becker@gmail.com", null, null, null, false, "https://picsum.photos/480/480/?image=59", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Wilber" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ImageUrl", "IsGroup", "IsPublic", "Name" },
                values: new object[,]
                {
                    { 1, "https://picsum.photos/640/480/?image=960", true, true, "Satterfield - Orn" },
                    { 2, "https://picsum.photos/640/480/?image=211", true, true, "Wiza and Sons" },
                    { 3, "https://picsum.photos/640/480/?image=996", true, true, "Boyer - Kunze" },
                    { 4, "https://picsum.photos/640/480/?image=1053", true, true, "Mraz, Swaniawski and Heaney" },
                    { 5, "https://picsum.photos/640/480/?image=453", true, true, "Stoltenberg - Davis" },
                    { 6, "https://picsum.photos/640/480/?image=752", true, true, "Wiza and Sons" },
                    { 7, "https://picsum.photos/640/480/?image=27", true, true, "Windler LLC" },
                    { 8, "https://picsum.photos/640/480/?image=908", true, true, "Dickinson Group" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SendMessages" },
                    { 2, "AddNewAdmins" },
                    { 3, "DeleteMessages" },
                    { 4, "RemoveUsers" },
                    { 5, "AddUsers" },
                    { 6, "ChangeChatInfo" },
                    { 7, "PinMessages" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { 1, "Member", 0 },
                    { 2, "Admin", 1 },
                    { 3, "Owner", 2 }
                });

            migrationBuilder.InsertData(
                table: "ChatMember",
                columns: new[] { "Id", "ChatId", "RoleId", "UnreadMessagesCount", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 3, 0, 8 },
                    { 2, 1, 1, 0, 6 },
                    { 3, 1, 1, 0, 2 },
                    { 4, 1, 1, 0, 5 },
                    { 5, 1, 1, 0, 10 },
                    { 6, 1, 1, 0, 2 },
                    { 7, 1, 1, 0, 1 },
                    { 8, 1, 1, 0, 6 },
                    { 9, 1, 1, 0, 3 },
                    { 10, 2, 3, 0, 9 },
                    { 11, 2, 1, 0, 5 },
                    { 12, 2, 1, 0, 10 },
                    { 13, 2, 1, 0, 3 },
                    { 14, 2, 1, 0, 2 },
                    { 15, 2, 1, 0, 6 },
                    { 16, 2, 1, 0, 8 },
                    { 17, 3, 3, 0, 9 },
                    { 18, 3, 1, 0, 1 },
                    { 19, 3, 1, 0, 1 },
                    { 20, 3, 1, 0, 8 },
                    { 21, 3, 1, 0, 4 },
                    { 22, 3, 1, 0, 4 },
                    { 23, 3, 1, 0, 8 },
                    { 24, 3, 1, 0, 10 },
                    { 25, 3, 1, 0, 6 },
                    { 26, 4, 3, 0, 3 },
                    { 27, 4, 1, 0, 1 },
                    { 28, 4, 1, 0, 2 },
                    { 29, 4, 1, 0, 4 },
                    { 30, 4, 1, 0, 8 },
                    { 31, 4, 1, 0, 4 },
                    { 32, 5, 3, 0, 7 },
                    { 33, 5, 1, 0, 8 },
                    { 34, 5, 1, 0, 3 },
                    { 35, 5, 1, 0, 6 },
                    { 36, 5, 1, 0, 3 },
                    { 37, 5, 1, 0, 10 },
                    { 38, 5, 1, 0, 8 },
                    { 39, 6, 3, 0, 3 },
                    { 40, 6, 1, 0, 5 },
                    { 41, 6, 1, 0, 2 },
                    { 42, 6, 1, 0, 10 }
                });

            migrationBuilder.InsertData(
                table: "ChatMember",
                columns: new[] { "Id", "ChatId", "RoleId", "UnreadMessagesCount", "UserId" },
                values: new object[,]
                {
                    { 43, 6, 1, 0, 1 },
                    { 44, 6, 1, 0, 7 },
                    { 45, 7, 3, 0, 3 },
                    { 46, 7, 1, 0, 2 },
                    { 47, 7, 1, 0, 1 },
                    { 48, 7, 1, 0, 1 },
                    { 49, 7, 1, 0, 5 },
                    { 50, 7, 1, 0, 4 },
                    { 51, 7, 1, 0, 1 },
                    { 52, 7, 1, 0, 7 },
                    { 53, 7, 1, 0, 8 },
                    { 54, 8, 3, 0, 5 },
                    { 55, 8, 1, 0, 9 },
                    { 56, 8, 1, 0, 2 },
                    { 57, 8, 1, 0, 8 },
                    { 58, 8, 1, 0, 1 },
                    { 59, 8, 1, 0, 7 },
                    { 60, 8, 1, 0, 4 },
                    { 61, 8, 1, 0, 4 },
                    { 62, 8, 1, 0, 6 },
                    { 63, 8, 1, 0, 6 }
                });

            migrationBuilder.InsertData(
                table: "PermissionRole",
                columns: new[] { "DefaultPermissionsId", "RolesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "ChatMemberPermission",
                columns: new[] { "MembersId", "PermissionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 17, 2 },
                    { 17, 3 },
                    { 17, 4 },
                    { 17, 5 },
                    { 17, 6 },
                    { 17, 7 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChatMemberPermission",
                columns: new[] { "MembersId", "PermissionsId" },
                values: new object[,]
                {
                    { 25, 1 },
                    { 26, 1 },
                    { 26, 2 },
                    { 26, 3 },
                    { 26, 4 },
                    { 26, 5 },
                    { 26, 6 },
                    { 26, 7 },
                    { 27, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 31, 1 },
                    { 32, 1 },
                    { 32, 2 },
                    { 32, 3 },
                    { 32, 4 },
                    { 32, 5 },
                    { 32, 6 },
                    { 32, 7 },
                    { 33, 1 },
                    { 34, 1 },
                    { 35, 1 },
                    { 36, 1 },
                    { 37, 1 },
                    { 38, 1 },
                    { 39, 1 },
                    { 39, 2 },
                    { 39, 3 },
                    { 39, 4 },
                    { 39, 5 },
                    { 39, 6 },
                    { 39, 7 },
                    { 40, 1 },
                    { 41, 1 },
                    { 42, 1 },
                    { 43, 1 },
                    { 44, 1 },
                    { 45, 1 },
                    { 45, 2 },
                    { 45, 3 },
                    { 45, 4 }
                });

            migrationBuilder.InsertData(
                table: "ChatMemberPermission",
                columns: new[] { "MembersId", "PermissionsId" },
                values: new object[,]
                {
                    { 45, 5 },
                    { 45, 6 },
                    { 45, 7 },
                    { 46, 1 },
                    { 47, 1 },
                    { 48, 1 },
                    { 49, 1 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 1 },
                    { 53, 1 },
                    { 54, 1 },
                    { 54, 2 },
                    { 54, 3 },
                    { 54, 4 },
                    { 54, 5 },
                    { 54, 6 },
                    { 54, 7 },
                    { 55, 1 },
                    { 56, 1 },
                    { 57, 1 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 1 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 1, 1, null, false, null, 46, new DateTime(2022, 12, 29, 10, 40, 23, 564, DateTimeKind.Local).AddTicks(7491), "Magnam ducimus odio explicabo.\nAperiam voluptas in cumque itaque." },
                    { 2, 1, null, false, null, 31, new DateTime(2022, 2, 26, 9, 4, 20, 970, DateTimeKind.Local).AddTicks(33), "Dicta incidunt soluta fuga soluta in quisquam.\nIn aut eos nam adipisci rem." },
                    { 3, 5, null, false, null, 36, new DateTime(2022, 3, 29, 9, 36, 26, 901, DateTimeKind.Local).AddTicks(974), "Sapiente repudiandae qui.\nSed aperiam qui molestias itaque suscipit et incidunt." },
                    { 4, 6, null, false, null, 38, new DateTime(2022, 10, 7, 15, 1, 26, 454, DateTimeKind.Local).AddTicks(9656), "Tenetur fuga id ut labore laudantium fuga voluptatem dolorem.\nAt nisi placeat repellat nemo ut." },
                    { 5, 3, null, false, null, 10, new DateTime(2022, 2, 20, 18, 48, 33, 34, DateTimeKind.Local).AddTicks(1078), "Vitae ut commodi reprehenderit non iste facere qui sit deleniti.\nEst quis voluptas consequatur." },
                    { 6, 1, null, false, null, 60, new DateTime(2022, 9, 21, 7, 58, 8, 287, DateTimeKind.Local).AddTicks(3656), "Dolores ad laudantium officiis optio ea.\nMinima doloribus laborum voluptas." },
                    { 7, 6, null, false, null, 14, new DateTime(2022, 4, 5, 2, 10, 2, 72, DateTimeKind.Local).AddTicks(199), "Consequatur sed occaecati ad pariatur.\nAdipisci debitis enim praesentium." },
                    { 8, 3, null, false, null, 18, new DateTime(2022, 12, 14, 3, 22, 8, 859, DateTimeKind.Local).AddTicks(2484), "Voluptatem officiis vero enim accusantium sint.\nUt eveniet aut ut pariatur voluptas." },
                    { 9, 4, null, false, null, 49, new DateTime(2022, 2, 25, 11, 2, 20, 714, DateTimeKind.Local).AddTicks(5328), "Veritatis quos id dignissimos quidem nesciunt.\nVoluptatem temporibus officiis ut animi architecto ipsum neque sit corporis." },
                    { 10, 3, null, false, null, 63, new DateTime(2022, 2, 19, 10, 44, 57, 856, DateTimeKind.Local).AddTicks(3594), "Alias corporis facilis iure ad qui maiores iure.\nIn rerum dignissimos." },
                    { 11, 5, null, false, null, 29, new DateTime(2023, 1, 28, 4, 2, 4, 856, DateTimeKind.Local).AddTicks(809), "Fugiat expedita quae ut enim.\nSimilique ipsum necessitatibus quia omnis mollitia eum." },
                    { 12, 7, null, false, null, 44, new DateTime(2022, 11, 20, 23, 28, 9, 436, DateTimeKind.Local).AddTicks(9208), "Praesentium cupiditate molestias aut tempora et ut.\nPlaceat rerum culpa soluta consequatur iure dolor." },
                    { 13, 4, null, false, null, 53, new DateTime(2022, 9, 11, 2, 22, 28, 444, DateTimeKind.Local).AddTicks(7918), "Sed cum quasi.\nEligendi temporibus qui fugit perferendis sed." },
                    { 14, 3, null, false, null, 26, new DateTime(2022, 5, 21, 14, 41, 42, 226, DateTimeKind.Local).AddTicks(9219), "Delectus aut atque ullam culpa adipisci dolorum.\nAdipisci vel velit aperiam." },
                    { 15, 7, null, false, null, 37, new DateTime(2022, 7, 29, 18, 21, 47, 549, DateTimeKind.Local).AddTicks(9056), "Consequatur asperiores sit error ut praesentium quia aut rerum.\nAccusantium officiis ut quaerat non." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 16, 2, null, false, null, 55, new DateTime(2022, 11, 18, 11, 54, 53, 92, DateTimeKind.Local).AddTicks(2365), "Et iste accusantium ut sit fugit dolor et.\nRem aut qui consequatur nobis soluta qui commodi." },
                    { 17, 3, null, false, null, 7, new DateTime(2022, 9, 3, 15, 47, 46, 22, DateTimeKind.Local).AddTicks(9718), "Neque quasi et enim alias rem.\nIllum aliquid aut officia." },
                    { 18, 7, null, false, null, 47, new DateTime(2022, 2, 26, 12, 45, 28, 649, DateTimeKind.Local).AddTicks(5178), "Ipsam sed amet explicabo et eius ut.\nUt iste distinctio sit ullam quia quod molestiae." },
                    { 19, 1, null, false, null, 35, new DateTime(2022, 6, 24, 2, 8, 14, 611, DateTimeKind.Local).AddTicks(9348), "Ea aperiam accusantium possimus exercitationem officia quia dolorem.\nUt quae quos in ut enim modi animi quasi." },
                    { 20, 4, null, false, null, 11, new DateTime(2022, 8, 14, 7, 15, 22, 259, DateTimeKind.Local).AddTicks(5069), "Ipsa tempore velit animi laboriosam maxime et nam earum.\nCulpa nihil voluptas perferendis quod quidem." },
                    { 21, 4, null, false, null, 32, new DateTime(2022, 5, 26, 10, 31, 29, 961, DateTimeKind.Local).AddTicks(6798), "Quo nulla neque molestiae et.\nDoloribus quisquam voluptas." },
                    { 22, 1, null, false, null, 27, new DateTime(2022, 9, 14, 6, 57, 43, 934, DateTimeKind.Local).AddTicks(7927), "Dignissimos quia sit quidem iure provident iusto velit qui.\nModi aut perspiciatis suscipit laborum ad dolorem rerum modi omnis." },
                    { 23, 7, null, false, null, 6, new DateTime(2022, 6, 4, 11, 10, 33, 223, DateTimeKind.Local).AddTicks(4574), "Quam alias fugiat.\nDignissimos iste ipsam et praesentium." },
                    { 24, 8, null, false, null, 51, new DateTime(2022, 7, 6, 1, 50, 57, 999, DateTimeKind.Local).AddTicks(8680), "Officia et qui numquam autem dolor.\nQui repellendus dolores quia adipisci optio iure." },
                    { 25, 7, null, false, null, 26, new DateTime(2022, 9, 30, 3, 20, 21, 331, DateTimeKind.Local).AddTicks(5754), "Temporibus maxime ullam aut minima repellat saepe ipsum.\nProvident vel ut dolores et." },
                    { 26, 2, null, false, null, 33, new DateTime(2022, 5, 22, 21, 30, 35, 625, DateTimeKind.Local).AddTicks(825), "Qui eligendi vitae eveniet animi placeat et ex.\nCumque non earum quia tempore reprehenderit aperiam deserunt et." },
                    { 27, 3, null, false, null, 16, new DateTime(2022, 5, 27, 0, 23, 52, 603, DateTimeKind.Local).AddTicks(9018), "Et praesentium ratione soluta tempore ullam ad.\nSed pariatur ut." },
                    { 28, 6, null, false, null, 5, new DateTime(2022, 3, 4, 10, 32, 58, 389, DateTimeKind.Local).AddTicks(9584), "Molestiae soluta eos ducimus totam aut ut est.\nIllo asperiores nisi voluptatem perferendis quia labore ut blanditiis est." },
                    { 29, 4, null, false, null, 32, new DateTime(2022, 10, 26, 23, 14, 1, 253, DateTimeKind.Local).AddTicks(1853), "In iusto nobis ducimus qui.\nDoloremque provident exercitationem alias." },
                    { 30, 3, null, false, null, 18, new DateTime(2022, 12, 4, 13, 40, 40, 571, DateTimeKind.Local).AddTicks(8992), "Quisquam debitis tempore.\nQui facilis soluta esse nemo quo." },
                    { 31, 2, null, false, null, 14, new DateTime(2022, 6, 30, 10, 23, 41, 961, DateTimeKind.Local).AddTicks(7139), "Temporibus et et magnam.\nUt animi qui a quaerat consequatur dolore delectus dolores sed." },
                    { 32, 2, null, false, null, 1, new DateTime(2022, 12, 17, 23, 11, 50, 178, DateTimeKind.Local).AddTicks(7735), "Ut expedita molestias sunt at qui dolores.\nExcepturi ipsum ipsum illo explicabo modi nihil et eveniet repellendus." },
                    { 33, 1, null, false, null, 34, new DateTime(2022, 11, 24, 10, 52, 45, 5, DateTimeKind.Local).AddTicks(8121), "Quas aut ut est voluptatum corporis.\nDelectus molestiae non et accusamus quo eaque minima." },
                    { 34, 4, null, false, null, 40, new DateTime(2022, 9, 7, 7, 10, 59, 642, DateTimeKind.Local).AddTicks(5133), "Aliquid libero aliquam id repudiandae perferendis.\nEst aut sapiente quo in ipsum perferendis aut quia." },
                    { 35, 2, null, false, null, 7, new DateTime(2022, 5, 25, 11, 0, 39, 976, DateTimeKind.Local).AddTicks(9888), "Quam ab quisquam repudiandae iusto provident veritatis accusantium.\nSed consectetur voluptas est qui nisi veniam non est." },
                    { 36, 8, null, false, null, 9, new DateTime(2022, 4, 30, 8, 19, 36, 332, DateTimeKind.Local).AddTicks(9516), "Sint saepe doloribus hic fuga.\nId et nihil expedita et." },
                    { 37, 8, null, false, null, 48, new DateTime(2022, 9, 12, 5, 20, 3, 519, DateTimeKind.Local).AddTicks(8288), "Omnis sit sequi a vero quidem ut dolores velit ipsa.\nVitae perspiciatis dolorem odio sequi repudiandae totam praesentium voluptatem." },
                    { 38, 3, null, false, null, 60, new DateTime(2022, 2, 19, 6, 58, 22, 816, DateTimeKind.Local).AddTicks(498), "Commodi itaque repellendus voluptates tempora ipsa velit velit libero.\nUt totam magni doloremque." },
                    { 39, 6, null, false, null, 43, new DateTime(2022, 9, 20, 21, 39, 45, 746, DateTimeKind.Local).AddTicks(6958), "Est excepturi omnis labore ipsa ex occaecati et nihil dolorum.\nModi consectetur minima quia et et quia voluptatem." },
                    { 40, 2, null, false, null, 52, new DateTime(2022, 9, 2, 16, 43, 22, 377, DateTimeKind.Local).AddTicks(3651), "Occaecati consequuntur id.\nPerspiciatis esse a." },
                    { 41, 1, null, false, null, 48, new DateTime(2022, 6, 14, 16, 31, 9, 467, DateTimeKind.Local).AddTicks(6075), "Veritatis velit sed dolores suscipit est aut natus.\nOmnis aliquid non quo error sed quod." },
                    { 42, 4, null, false, null, 22, new DateTime(2022, 9, 27, 6, 11, 3, 835, DateTimeKind.Local).AddTicks(5569), "Natus modi blanditiis voluptas sed tempora cum enim optio aut.\nDolorum rerum maiores quisquam aliquam omnis animi." },
                    { 43, 4, null, false, null, 39, new DateTime(2022, 6, 25, 20, 35, 58, 515, DateTimeKind.Local).AddTicks(5940), "Quis voluptas aliquam distinctio laboriosam esse voluptas possimus dolores.\nHarum corrupti vel quo vero qui nobis ducimus ad dignissimos." },
                    { 44, 6, null, false, null, 15, new DateTime(2022, 4, 25, 0, 8, 29, 414, DateTimeKind.Local).AddTicks(4452), "Ut similique voluptatem sint quisquam et dolores.\nNihil sit error blanditiis ut quia corporis enim voluptates." },
                    { 45, 1, null, false, null, 28, new DateTime(2022, 3, 27, 8, 35, 5, 428, DateTimeKind.Local).AddTicks(2973), "Quia nemo saepe consectetur eum dolor dolorem.\nEt corrupti magni commodi ipsum enim ut quisquam laboriosam." },
                    { 46, 8, null, false, null, 51, new DateTime(2023, 1, 12, 16, 49, 6, 571, DateTimeKind.Local).AddTicks(3412), "Voluptatem vel nostrum ut doloremque asperiores.\nVeritatis tempore ducimus nesciunt est aut porro sint quis." },
                    { 47, 8, null, false, null, 26, new DateTime(2022, 2, 25, 6, 41, 9, 319, DateTimeKind.Local).AddTicks(7623), "Fugit cumque error et sit asperiores necessitatibus fuga quas.\nDolores totam sunt et saepe reprehenderit ut labore dolore iusto." },
                    { 48, 3, null, false, null, 41, new DateTime(2022, 4, 8, 20, 12, 29, 389, DateTimeKind.Local).AddTicks(6673), "Eius minus excepturi sit quia.\nAlias et ullam non veniam labore." },
                    { 49, 4, null, false, null, 52, new DateTime(2022, 7, 27, 21, 27, 58, 424, DateTimeKind.Local).AddTicks(1125), "Sint perferendis corrupti animi a.\nExpedita nesciunt eaque explicabo." },
                    { 50, 4, null, false, null, 23, new DateTime(2022, 10, 28, 7, 14, 31, 852, DateTimeKind.Local).AddTicks(2961), "Qui dolor sint non dolore accusamus dolorum asperiores.\nConsequuntur voluptates tempora beatae." },
                    { 51, 2, null, false, null, 1, new DateTime(2022, 7, 12, 7, 25, 41, 34, DateTimeKind.Local).AddTicks(5400), "Minus ex error sequi aut laudantium sequi quia quas esse.\nEaque rem ipsum illum ullam provident alias necessitatibus." },
                    { 52, 4, null, false, null, 26, new DateTime(2023, 2, 8, 11, 25, 34, 145, DateTimeKind.Local).AddTicks(146), "Ut minus neque quia.\nReprehenderit quis aperiam rem velit delectus quidem." },
                    { 53, 4, null, false, null, 61, new DateTime(2023, 1, 21, 0, 42, 47, 642, DateTimeKind.Local).AddTicks(6588), "Recusandae repudiandae laboriosam laudantium ullam vel.\nConsequuntur velit accusantium voluptatem deserunt qui consequatur corporis eum ut." },
                    { 54, 5, null, false, null, 29, new DateTime(2022, 9, 23, 10, 8, 9, 365, DateTimeKind.Local).AddTicks(7882), "Voluptas odio repudiandae amet sed dolores laborum commodi et assumenda.\nPerferendis sit sunt molestias nesciunt adipisci soluta dignissimos." },
                    { 55, 1, null, false, null, 11, new DateTime(2022, 11, 30, 17, 50, 55, 378, DateTimeKind.Local).AddTicks(262), "Dolorem magnam qui provident et odit exercitationem molestiae repellendus.\nExcepturi aliquid vel voluptatem in recusandae." },
                    { 56, 8, null, false, null, 8, new DateTime(2022, 2, 23, 4, 8, 53, 301, DateTimeKind.Local).AddTicks(5705), "Id alias facere culpa commodi molestias voluptatibus.\nQuia quod omnis qui qui voluptatem temporibus consequuntur culpa consequuntur." },
                    { 57, 8, null, false, null, 37, new DateTime(2023, 1, 11, 21, 39, 13, 408, DateTimeKind.Local).AddTicks(9042), "Aut et qui dolores.\nEveniet ducimus ut quia eaque omnis illum aut dolorum voluptatem." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 58, 8, null, false, null, 20, new DateTime(2022, 2, 17, 1, 18, 6, 90, DateTimeKind.Local).AddTicks(540), "Nesciunt architecto qui ullam sint.\nAsperiores deserunt laborum rerum eos vel culpa qui vitae." },
                    { 59, 1, null, false, null, 50, new DateTime(2022, 6, 22, 19, 17, 16, 762, DateTimeKind.Local).AddTicks(9693), "Placeat sed dicta maiores ut laborum libero modi.\nRepudiandae autem rerum." },
                    { 60, 6, null, false, null, 16, new DateTime(2022, 5, 21, 3, 56, 33, 729, DateTimeKind.Local).AddTicks(1868), "Numquam eos beatae vitae ipsa quod officiis.\nRem quo magnam quia reprehenderit ut quia quas provident." },
                    { 61, 1, null, false, null, 22, new DateTime(2022, 7, 12, 0, 38, 57, 832, DateTimeKind.Local).AddTicks(4646), "Quam quo rerum vel exercitationem in expedita.\nIure non dolorum nihil voluptatem cumque ratione deleniti repellendus." },
                    { 62, 7, null, false, null, 23, new DateTime(2022, 9, 21, 14, 41, 6, 790, DateTimeKind.Local).AddTicks(8228), "Doloremque quidem voluptatum cumque temporibus voluptatem sed aut.\nQuidem animi perspiciatis impedit." },
                    { 63, 4, null, false, null, 37, new DateTime(2022, 6, 10, 23, 3, 16, 606, DateTimeKind.Local).AddTicks(8150), "Quisquam repellendus quia.\nAliquam blanditiis voluptas cumque veritatis." },
                    { 64, 6, null, false, null, 51, new DateTime(2022, 3, 1, 11, 52, 11, 996, DateTimeKind.Local).AddTicks(5559), "Eaque quod pariatur repellat quaerat aut magnam.\nNon doloremque delectus quisquam eius id odit quam." },
                    { 65, 2, null, false, null, 19, new DateTime(2022, 9, 23, 8, 9, 3, 358, DateTimeKind.Local).AddTicks(5820), "Ducimus asperiores rem maxime voluptas eum.\nNihil laudantium iste minus aut impedit animi unde." },
                    { 66, 5, null, false, null, 31, new DateTime(2022, 5, 2, 1, 23, 30, 719, DateTimeKind.Local).AddTicks(5608), "Consequuntur rem velit enim dolorum nulla deleniti quisquam et.\nAutem ad ratione ab qui in facere et." },
                    { 67, 3, null, false, null, 40, new DateTime(2022, 5, 23, 7, 5, 59, 311, DateTimeKind.Local).AddTicks(9355), "Quia temporibus deserunt consequatur ut quia.\nDolores iste minus rem quisquam." },
                    { 68, 5, null, false, null, 56, new DateTime(2022, 7, 28, 23, 16, 37, 412, DateTimeKind.Local).AddTicks(3173), "Quod voluptatem tempore libero fuga.\nVoluptatem ut atque labore in." },
                    { 69, 3, null, false, null, 51, new DateTime(2022, 3, 24, 8, 25, 59, 126, DateTimeKind.Local).AddTicks(5789), "Saepe et suscipit eius voluptatem explicabo est est eos.\nEx quos commodi assumenda." },
                    { 70, 1, null, false, null, 32, new DateTime(2022, 12, 30, 14, 41, 45, 151, DateTimeKind.Local).AddTicks(2698), "Amet natus non aliquam nemo quia.\nIncidunt enim quibusdam quos id." },
                    { 71, 8, null, false, null, 25, new DateTime(2022, 10, 15, 22, 33, 58, 658, DateTimeKind.Local).AddTicks(6312), "Minima dolores incidunt fugit esse nulla perferendis et et.\nOptio qui saepe aperiam amet blanditiis quas blanditiis impedit vel." },
                    { 72, 5, null, false, null, 10, new DateTime(2022, 7, 22, 7, 2, 29, 540, DateTimeKind.Local).AddTicks(3626), "Quo nesciunt non quia recusandae atque incidunt dolorum itaque.\nQuia nostrum dignissimos." },
                    { 73, 5, null, false, null, 52, new DateTime(2022, 9, 14, 18, 3, 25, 576, DateTimeKind.Local).AddTicks(9585), "Et voluptas rerum libero et ut.\nAccusamus asperiores itaque eius." },
                    { 74, 3, null, false, null, 38, new DateTime(2022, 4, 30, 11, 19, 52, 282, DateTimeKind.Local).AddTicks(2776), "Aliquid animi neque aut.\nAccusantium ab illo sapiente doloremque provident quidem est." },
                    { 75, 2, null, false, null, 51, new DateTime(2022, 5, 31, 13, 35, 58, 378, DateTimeKind.Local).AddTicks(4752), "Qui earum quos et voluptates earum molestiae sunt dolorum alias.\nEligendi cumque voluptas provident suscipit illum reprehenderit vero quibusdam fugiat." },
                    { 76, 7, null, false, null, 41, new DateTime(2022, 7, 27, 10, 38, 2, 742, DateTimeKind.Local).AddTicks(1948), "Sint ut quae.\nSed qui sapiente dolorum aut ea eum voluptate molestiae perferendis." },
                    { 77, 4, null, false, null, 20, new DateTime(2022, 7, 29, 0, 44, 17, 296, DateTimeKind.Local).AddTicks(8212), "Enim earum error nihil est.\nVel et eaque." },
                    { 78, 7, null, false, null, 11, new DateTime(2022, 10, 22, 4, 23, 52, 255, DateTimeKind.Local).AddTicks(3121), "Vel consectetur debitis sint corrupti aut voluptas est.\nPariatur voluptas totam et mollitia." },
                    { 79, 8, null, false, null, 53, new DateTime(2022, 8, 2, 20, 32, 38, 715, DateTimeKind.Local).AddTicks(9980), "Tenetur eos accusamus deleniti molestias sunt autem atque.\nIusto minima hic et eos aliquam quisquam dolor." },
                    { 80, 6, null, false, null, 4, new DateTime(2022, 10, 28, 4, 44, 59, 344, DateTimeKind.Local).AddTicks(5234), "Dolor omnis autem aliquam autem.\nDolor nulla tenetur est et." },
                    { 81, 4, null, false, null, 34, new DateTime(2022, 8, 30, 19, 1, 20, 982, DateTimeKind.Local).AddTicks(4027), "Error aspernatur ut est aliquid dolorum facere exercitationem pariatur.\nOdit ipsum nesciunt." },
                    { 82, 5, null, false, null, 57, new DateTime(2023, 1, 30, 19, 2, 25, 608, DateTimeKind.Local).AddTicks(1996), "Distinctio soluta illum.\nQui impedit beatae repudiandae maxime laboriosam recusandae aut voluptates." },
                    { 83, 4, null, false, null, 52, new DateTime(2022, 7, 23, 3, 19, 29, 434, DateTimeKind.Local).AddTicks(4753), "Magni placeat quibusdam sit et consequatur reiciendis officiis.\nReiciendis quo maiores nesciunt qui." },
                    { 84, 6, null, false, null, 43, new DateTime(2022, 6, 6, 18, 18, 36, 804, DateTimeKind.Local).AddTicks(9524), "Veniam sint consequatur delectus sunt sed ut voluptatem.\nDolorem voluptas voluptas doloribus aut." },
                    { 85, 2, null, false, null, 12, new DateTime(2022, 4, 6, 6, 47, 43, 644, DateTimeKind.Local).AddTicks(3689), "Et iusto ea.\nDucimus est ut dolorum omnis est esse qui dolor consequuntur." },
                    { 86, 7, null, false, null, 9, new DateTime(2023, 2, 2, 23, 46, 1, 977, DateTimeKind.Local).AddTicks(7350), "Libero ipsa accusantium.\nExpedita eligendi fugiat quia et et cumque." },
                    { 87, 4, null, false, null, 33, new DateTime(2022, 5, 9, 13, 50, 42, 267, DateTimeKind.Local).AddTicks(554), "Unde delectus qui pariatur ipsa.\nVeniam dolorum ipsum." },
                    { 88, 6, null, false, null, 14, new DateTime(2022, 8, 10, 5, 45, 1, 841, DateTimeKind.Local).AddTicks(7941), "Molestiae adipisci nihil nihil sit.\nOdio voluptatibus harum soluta animi omnis dignissimos voluptatem quas." },
                    { 89, 3, null, false, null, 60, new DateTime(2022, 10, 12, 5, 4, 52, 571, DateTimeKind.Local).AddTicks(7982), "Molestiae et nobis praesentium non nemo consequatur repellendus.\nArchitecto repellendus ullam officia non inventore." },
                    { 90, 7, null, false, null, 49, new DateTime(2022, 3, 25, 0, 3, 41, 311, DateTimeKind.Local).AddTicks(7562), "Eos aut eaque deleniti aut consequatur voluptas nisi.\nEa ipsa fugiat velit." },
                    { 91, 4, null, false, null, 11, new DateTime(2022, 12, 22, 5, 29, 55, 15, DateTimeKind.Local).AddTicks(1055), "Ut quasi ex aut velit tenetur corporis quia vitae aspernatur.\nConsequatur aut ratione nobis cupiditate quia." },
                    { 92, 6, null, false, null, 54, new DateTime(2022, 4, 10, 13, 6, 43, 367, DateTimeKind.Local).AddTicks(8394), "Est omnis ut qui.\nSed voluptas fugiat magnam veritatis voluptatem aut harum in voluptas." },
                    { 93, 5, null, false, null, 44, new DateTime(2022, 3, 11, 19, 24, 55, 300, DateTimeKind.Local).AddTicks(7024), "Eligendi perferendis magni corporis.\nRepellat nesciunt exercitationem molestiae earum reprehenderit atque et veniam." },
                    { 94, 4, null, false, null, 56, new DateTime(2022, 4, 11, 23, 42, 59, 539, DateTimeKind.Local).AddTicks(9152), "Non sunt harum neque omnis explicabo.\nCumque neque dolores maiores totam porro." },
                    { 95, 1, null, false, null, 35, new DateTime(2022, 11, 21, 17, 42, 24, 302, DateTimeKind.Local).AddTicks(227), "Quis suscipit non.\nVero et reprehenderit nihil et adipisci molestiae." },
                    { 96, 3, null, false, null, 11, new DateTime(2022, 10, 30, 12, 8, 7, 646, DateTimeKind.Local).AddTicks(9622), "Recusandae enim maiores qui autem eaque.\nVelit aliquam et nostrum voluptatibus." },
                    { 97, 4, null, false, null, 32, new DateTime(2023, 2, 5, 2, 3, 16, 53, DateTimeKind.Local).AddTicks(3178), "Aut quibusdam voluptas quidem dolor voluptas aliquid sunt.\nAd aut voluptatem velit voluptatum perspiciatis quis." },
                    { 98, 5, null, false, null, 8, new DateTime(2022, 9, 5, 11, 50, 45, 121, DateTimeKind.Local).AddTicks(5686), "Deleniti ut tempore eveniet adipisci sit.\nHic rem fugit eaque." },
                    { 99, 3, null, false, null, 43, new DateTime(2022, 4, 28, 21, 2, 31, 357, DateTimeKind.Local).AddTicks(962), "Sit necessitatibus nihil iste labore vel dolorem dolorem asperiores.\nInventore possimus quia quo consequatur aut quae." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 100, 4, null, false, null, 61, new DateTime(2022, 9, 27, 12, 3, 34, 410, DateTimeKind.Local).AddTicks(1190), "Quidem nostrum reprehenderit.\nDicta odio aut sunt numquam et." },
                    { 101, 4, null, false, null, 47, new DateTime(2022, 4, 6, 19, 52, 40, 401, DateTimeKind.Local).AddTicks(9239), "Voluptates voluptatem provident enim blanditiis qui et eum labore officia.\nSapiente debitis accusamus saepe culpa cumque dolor neque omnis." },
                    { 102, 4, null, false, null, 27, new DateTime(2022, 3, 5, 9, 39, 4, 848, DateTimeKind.Local).AddTicks(3011), "Quos eaque tempora consectetur quia laudantium aliquid.\nEt labore dolorem minima veniam itaque tenetur incidunt error." },
                    { 103, 8, null, false, null, 25, new DateTime(2022, 4, 14, 15, 22, 45, 853, DateTimeKind.Local).AddTicks(3578), "Accusamus ut magnam molestiae.\nConsequatur minus maiores iure porro magnam eos quia necessitatibus voluptatibus." },
                    { 104, 6, null, false, null, 50, new DateTime(2022, 5, 28, 0, 0, 29, 149, DateTimeKind.Local).AddTicks(2686), "Et aut et.\nQuod facilis quidem similique in saepe repellendus aut eos." },
                    { 105, 6, null, false, null, 13, new DateTime(2022, 2, 24, 20, 24, 56, 770, DateTimeKind.Local).AddTicks(8771), "Rerum eaque placeat nihil sit cupiditate totam ab sunt.\nQui iure rem." },
                    { 106, 7, null, false, null, 24, new DateTime(2022, 7, 8, 9, 16, 18, 847, DateTimeKind.Local).AddTicks(3293), "Nihil quasi cumque ut quia fugit repellat minima.\nVeritatis delectus molestiae consequatur voluptate." },
                    { 107, 2, null, false, null, 46, new DateTime(2022, 12, 15, 1, 17, 12, 126, DateTimeKind.Local).AddTicks(2677), "Dolorum sed omnis voluptas ipsum ut.\nEius fugiat saepe sed." },
                    { 108, 7, null, false, null, 35, new DateTime(2022, 7, 23, 17, 37, 16, 972, DateTimeKind.Local).AddTicks(8678), "Vel id fuga occaecati.\nMolestiae necessitatibus labore ut saepe neque facere." },
                    { 109, 4, null, false, null, 57, new DateTime(2022, 4, 17, 17, 1, 19, 309, DateTimeKind.Local).AddTicks(767), "Explicabo facilis quos quis et id recusandae consequatur perferendis error.\nOfficia impedit aliquam quia et facere perspiciatis." },
                    { 110, 2, null, false, null, 25, new DateTime(2022, 10, 8, 22, 8, 15, 147, DateTimeKind.Local).AddTicks(2970), "Nostrum voluptate maxime quaerat neque voluptas odit deleniti.\nConsequatur blanditiis tempora incidunt aspernatur." },
                    { 111, 4, null, false, null, 48, new DateTime(2022, 4, 1, 6, 37, 45, 93, DateTimeKind.Local).AddTicks(1822), "Est mollitia et laudantium accusamus inventore.\nAsperiores est nisi nobis nam autem." },
                    { 112, 6, null, false, null, 9, new DateTime(2022, 3, 28, 15, 37, 52, 396, DateTimeKind.Local).AddTicks(4994), "Molestias corporis repellendus enim in.\nAut similique repellendus commodi ut." },
                    { 113, 3, null, false, null, 43, new DateTime(2022, 12, 25, 22, 43, 42, 373, DateTimeKind.Local).AddTicks(5023), "Molestiae quasi dolores modi minima.\nDeleniti velit saepe vero voluptas occaecati blanditiis quod." },
                    { 114, 8, null, false, null, 50, new DateTime(2022, 5, 4, 5, 26, 46, 969, DateTimeKind.Local).AddTicks(6456), "Suscipit molestiae quaerat at et odio beatae rerum minima.\nCorporis eos vero tempore tenetur qui et voluptatem explicabo eum." },
                    { 115, 4, null, false, null, 7, new DateTime(2022, 11, 5, 8, 15, 1, 173, DateTimeKind.Local).AddTicks(6113), "Omnis aut ut quaerat qui.\nSit voluptatem qui." },
                    { 116, 1, null, false, null, 35, new DateTime(2022, 3, 3, 19, 21, 5, 752, DateTimeKind.Local).AddTicks(2013), "Id accusantium esse.\nSapiente nobis quisquam qui debitis soluta facilis porro nihil." },
                    { 117, 1, null, false, null, 5, new DateTime(2023, 1, 2, 15, 26, 47, 324, DateTimeKind.Local).AddTicks(4316), "Enim eum tenetur.\nAnimi laboriosam autem vitae totam nostrum recusandae officiis sit." },
                    { 118, 6, null, false, null, 8, new DateTime(2023, 1, 3, 18, 57, 7, 136, DateTimeKind.Local).AddTicks(5609), "Tempora mollitia non voluptas in consequatur at iure esse alias.\nNeque est eius ducimus recusandae sapiente qui aut." },
                    { 119, 1, null, false, null, 58, new DateTime(2022, 5, 26, 18, 10, 18, 277, DateTimeKind.Local).AddTicks(399), "Voluptate ut pariatur doloremque omnis doloremque at nesciunt facere quaerat.\nVoluptatem numquam consectetur." },
                    { 120, 6, null, false, null, 54, new DateTime(2022, 7, 22, 8, 7, 17, 568, DateTimeKind.Local).AddTicks(5881), "Distinctio unde minus consequatur vel non qui.\nMolestiae quibusdam dolorem in." },
                    { 121, 5, null, false, null, 27, new DateTime(2022, 12, 3, 21, 18, 36, 87, DateTimeKind.Local).AddTicks(5414), "Deserunt quia numquam totam quisquam et autem ex et.\nEt error in corporis est nihil labore magni accusamus." },
                    { 122, 6, null, false, null, 59, new DateTime(2022, 12, 7, 6, 55, 36, 91, DateTimeKind.Local).AddTicks(3299), "Eaque molestiae tempora laudantium quas aut id et quos neque.\nEt asperiores vel." },
                    { 123, 1, null, false, null, 47, new DateTime(2022, 9, 13, 15, 7, 48, 78, DateTimeKind.Local).AddTicks(8434), "Occaecati porro tenetur.\nMolestiae animi esse velit et optio aut omnis soluta." },
                    { 124, 1, null, false, null, 7, new DateTime(2022, 10, 9, 22, 14, 9, 400, DateTimeKind.Local).AddTicks(8363), "Consequatur tempora sit quibusdam.\nSunt occaecati ab quisquam facere." },
                    { 125, 6, null, false, null, 52, new DateTime(2022, 4, 2, 20, 29, 30, 951, DateTimeKind.Local).AddTicks(8912), "Natus et enim ut.\nEst nemo excepturi rerum voluptatum." },
                    { 126, 6, null, false, null, 22, new DateTime(2022, 12, 26, 21, 31, 58, 89, DateTimeKind.Local).AddTicks(2080), "Laborum expedita reiciendis.\nMaiores labore sunt laboriosam est temporibus." },
                    { 127, 2, null, false, null, 52, new DateTime(2022, 3, 3, 18, 31, 57, 491, DateTimeKind.Local).AddTicks(875), "Ipsam reiciendis voluptas et.\nEt nulla odit qui maxime sed molestias saepe dolor." },
                    { 128, 5, null, false, null, 33, new DateTime(2022, 11, 10, 18, 34, 12, 759, DateTimeKind.Local).AddTicks(3965), "Odio aperiam eaque.\nQui aut repellat." },
                    { 129, 8, null, false, null, 7, new DateTime(2022, 8, 20, 18, 58, 13, 940, DateTimeKind.Local).AddTicks(4119), "Ex esse sit labore rerum qui tempore.\nNon aut ducimus possimus repudiandae qui et." },
                    { 130, 2, null, false, null, 19, new DateTime(2022, 10, 14, 7, 32, 47, 863, DateTimeKind.Local).AddTicks(1321), "Aut voluptate ab rerum quam officia ipsam ullam sed.\nEos amet quia odit aperiam eaque tempora provident consequatur ratione." },
                    { 131, 5, null, false, null, 38, new DateTime(2023, 2, 6, 0, 24, 54, 789, DateTimeKind.Local).AddTicks(9636), "Velit consequatur error recusandae qui dicta corrupti hic reiciendis.\nMagni dolores commodi fuga perferendis sed corporis officiis eaque quod." },
                    { 132, 7, null, false, null, 6, new DateTime(2022, 9, 10, 22, 18, 35, 585, DateTimeKind.Local).AddTicks(2993), "Officia est optio illum qui enim asperiores ducimus numquam molestias.\nConsequatur totam qui eaque consectetur vel rerum iure consequatur magni." },
                    { 133, 5, null, false, null, 30, new DateTime(2022, 5, 22, 9, 2, 31, 779, DateTimeKind.Local).AddTicks(5878), "Voluptatibus expedita impedit voluptas laborum nihil consequatur et et.\nCorrupti sit libero enim." },
                    { 134, 6, null, false, null, 35, new DateTime(2022, 4, 13, 1, 56, 30, 828, DateTimeKind.Local).AddTicks(9482), "Cum dolores dicta eveniet iste assumenda ut.\nVeritatis aut quisquam voluptatem distinctio ullam." },
                    { 135, 7, null, false, null, 5, new DateTime(2023, 1, 27, 13, 15, 21, 641, DateTimeKind.Local).AddTicks(1098), "Omnis quae maiores.\nTenetur quia et fugiat suscipit at." },
                    { 136, 3, null, false, null, 23, new DateTime(2022, 5, 6, 7, 57, 13, 884, DateTimeKind.Local).AddTicks(6281), "Dolor eligendi explicabo velit maxime.\nVoluptatem dolores itaque voluptatem distinctio sit numquam necessitatibus." },
                    { 137, 7, null, false, null, 40, new DateTime(2022, 5, 16, 4, 39, 41, 51, DateTimeKind.Local).AddTicks(5714), "Dolor atque est et qui omnis minus hic perferendis.\nQuia quam voluptate quasi nostrum nostrum est ab nam repellendus." },
                    { 138, 2, null, false, null, 22, new DateTime(2022, 3, 9, 7, 56, 6, 485, DateTimeKind.Local).AddTicks(5469), "Quia aut maiores unde atque molestiae ut voluptas sit.\nReprehenderit illum voluptatum molestias saepe enim quo." },
                    { 139, 7, null, false, null, 26, new DateTime(2022, 11, 12, 20, 49, 59, 188, DateTimeKind.Local).AddTicks(5311), "Omnis sapiente magni consectetur ad.\nQuisquam sunt dignissimos ratione quae." },
                    { 140, 2, null, false, null, 61, new DateTime(2022, 10, 29, 5, 59, 25, 273, DateTimeKind.Local).AddTicks(6658), "In omnis excepturi facere nulla reiciendis in tempora harum.\nNeque possimus enim eveniet adipisci deleniti." },
                    { 141, 2, null, false, null, 33, new DateTime(2023, 1, 26, 8, 48, 51, 345, DateTimeKind.Local).AddTicks(8244), "Ea cumque non dolorem hic placeat dignissimos nihil omnis ipsam.\nMolestiae incidunt et aut voluptate commodi accusamus dolor et molestias." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 142, 2, null, false, null, 9, new DateTime(2022, 8, 9, 19, 59, 26, 175, DateTimeKind.Local).AddTicks(4833), "Et distinctio maiores qui.\nVeniam sint vel ipsa qui in magnam." },
                    { 143, 8, null, false, null, 36, new DateTime(2022, 7, 21, 23, 26, 41, 325, DateTimeKind.Local).AddTicks(2253), "Optio praesentium sit dolor.\nDistinctio minus quia consequuntur velit veniam." },
                    { 144, 4, null, false, null, 25, new DateTime(2022, 4, 1, 2, 24, 26, 509, DateTimeKind.Local).AddTicks(7300), "Provident voluptas temporibus odit magnam nulla commodi id.\nEos cumque ut vel praesentium repellendus quia." },
                    { 145, 2, null, false, null, 25, new DateTime(2022, 6, 4, 13, 8, 19, 843, DateTimeKind.Local).AddTicks(7957), "Aperiam non velit quas veritatis quos et accusantium.\nDeserunt aut distinctio corporis et consequatur." },
                    { 146, 1, null, false, null, 29, new DateTime(2023, 1, 10, 7, 35, 38, 27, DateTimeKind.Local).AddTicks(2566), "Recusandae exercitationem sit.\nNesciunt ab voluptatem quia repellat est enim expedita porro reiciendis." },
                    { 147, 1, null, false, null, 46, new DateTime(2022, 3, 19, 17, 12, 52, 826, DateTimeKind.Local).AddTicks(9488), "Molestias dignissimos eos id aspernatur.\nEligendi atque pariatur voluptatem facere." },
                    { 148, 1, null, false, null, 43, new DateTime(2022, 4, 7, 14, 39, 21, 752, DateTimeKind.Local).AddTicks(9634), "Dolores perferendis nihil pariatur consequatur et impedit velit provident eius.\nAsperiores repellendus cumque placeat illum beatae dicta quo." },
                    { 149, 7, null, false, null, 27, new DateTime(2022, 7, 25, 13, 23, 27, 417, DateTimeKind.Local).AddTicks(8043), "Fugit cumque ipsum magnam aut.\nAut repellat tempora recusandae aperiam vel est." },
                    { 150, 3, null, false, null, 29, new DateTime(2022, 2, 19, 19, 41, 19, 186, DateTimeKind.Local).AddTicks(904), "Vero maiores cupiditate atque sit deleniti occaecati hic.\nCum qui perspiciatis iste rerum excepturi tempora." },
                    { 151, 1, null, false, null, 9, new DateTime(2022, 11, 11, 18, 16, 27, 53, DateTimeKind.Local).AddTicks(3941), "Ut sed nam aut sit accusantium velit.\nInventore est ducimus debitis." },
                    { 152, 2, null, false, null, 39, new DateTime(2022, 9, 1, 12, 39, 8, 85, DateTimeKind.Local).AddTicks(8361), "Numquam non velit est nulla autem libero incidunt quisquam non.\nQui et suscipit beatae vitae magnam magni maiores." },
                    { 153, 2, null, false, null, 38, new DateTime(2022, 12, 8, 18, 37, 7, 116, DateTimeKind.Local).AddTicks(3178), "Veritatis dolor tenetur ut aut et impedit inventore ut.\nDolore dolor et cum quia dignissimos similique vel dolore." },
                    { 154, 4, null, false, null, 2, new DateTime(2023, 2, 5, 23, 51, 37, 495, DateTimeKind.Local).AddTicks(9557), "Maiores iusto dolor fugiat.\nUt nesciunt fugiat non deleniti esse." },
                    { 155, 8, null, false, null, 60, new DateTime(2022, 5, 3, 15, 13, 57, 658, DateTimeKind.Local).AddTicks(8861), "Nam sit molestiae enim.\nEst est neque voluptatem debitis ad tenetur sint quod error." },
                    { 156, 3, null, false, null, 61, new DateTime(2022, 6, 27, 18, 22, 57, 792, DateTimeKind.Local).AddTicks(1764), "Quis reiciendis ad sunt.\nUt cupiditate rerum." },
                    { 157, 8, null, false, null, 60, new DateTime(2022, 6, 24, 18, 31, 32, 645, DateTimeKind.Local).AddTicks(8133), "Voluptatem non animi ea nam qui dignissimos quasi.\nModi eum occaecati natus omnis delectus." },
                    { 158, 6, null, false, null, 21, new DateTime(2022, 2, 28, 17, 5, 53, 838, DateTimeKind.Local).AddTicks(4649), "Quod dolor at ipsum necessitatibus a id nobis sint laborum.\nVoluptas qui incidunt incidunt temporibus explicabo." },
                    { 159, 2, null, false, null, 26, new DateTime(2022, 11, 12, 15, 8, 27, 208, DateTimeKind.Local).AddTicks(6873), "Illum modi aut.\nSuscipit suscipit repellendus consectetur eos et eum minus officia." },
                    { 160, 7, null, false, null, 15, new DateTime(2022, 7, 21, 2, 5, 35, 931, DateTimeKind.Local).AddTicks(5412), "Quae aliquid voluptatem porro aut enim voluptatem accusantium iste veniam.\nQuam tenetur est molestiae rerum aut commodi ullam nesciunt aspernatur." },
                    { 161, 1, null, false, null, 47, new DateTime(2022, 10, 22, 5, 8, 48, 765, DateTimeKind.Local).AddTicks(3890), "Ipsum itaque deserunt vel qui maiores architecto aut.\nVoluptatibus molestiae sint iusto possimus corrupti." },
                    { 162, 5, null, false, null, 52, new DateTime(2022, 12, 28, 17, 24, 40, 717, DateTimeKind.Local).AddTicks(1171), "Voluptas non in iusto qui reprehenderit quos natus accusamus.\nDoloremque quos pariatur laudantium porro sed." },
                    { 163, 8, null, false, null, 40, new DateTime(2023, 1, 12, 13, 15, 14, 210, DateTimeKind.Local).AddTicks(1871), "Dolorum alias itaque earum assumenda et.\nDeserunt recusandae voluptates sint." },
                    { 164, 1, null, false, null, 26, new DateTime(2022, 3, 13, 1, 24, 31, 330, DateTimeKind.Local).AddTicks(9241), "Hic aut placeat rerum blanditiis nesciunt qui id quibusdam.\nA id nisi ut ipsum earum." },
                    { 165, 5, null, false, null, 29, new DateTime(2023, 1, 11, 21, 9, 0, 314, DateTimeKind.Local).AddTicks(4577), "Corrupti deserunt numquam sed.\nMagni ut nesciunt explicabo." },
                    { 166, 5, null, false, null, 23, new DateTime(2022, 12, 23, 0, 55, 53, 864, DateTimeKind.Local).AddTicks(5164), "Modi quod vel nostrum rem aliquam vel rerum.\nIn qui dignissimos eveniet." },
                    { 167, 6, null, false, null, 30, new DateTime(2022, 8, 12, 6, 1, 33, 993, DateTimeKind.Local).AddTicks(3160), "Totam magni itaque sed dolorem perspiciatis vero.\nSit nihil qui incidunt sint sit qui voluptatibus repudiandae." },
                    { 168, 3, null, false, null, 36, new DateTime(2022, 12, 1, 22, 37, 59, 805, DateTimeKind.Local).AddTicks(958), "Dolore voluptatem est nemo tenetur dolor illo.\nUt ut labore commodi." },
                    { 169, 8, null, false, null, 44, new DateTime(2022, 11, 23, 19, 4, 27, 562, DateTimeKind.Local).AddTicks(4948), "Consequatur exercitationem omnis.\nEst quibusdam et expedita eius aperiam." },
                    { 170, 3, null, false, null, 49, new DateTime(2023, 2, 3, 2, 21, 8, 873, DateTimeKind.Local).AddTicks(1718), "Id eius et provident natus quasi excepturi qui maiores.\nSaepe ut adipisci porro." },
                    { 171, 6, null, false, null, 54, new DateTime(2022, 9, 12, 3, 14, 56, 321, DateTimeKind.Local).AddTicks(6501), "Dolor autem et eos rerum excepturi enim ut consequuntur fugit.\nIpsa soluta qui voluptas aut." },
                    { 172, 3, null, false, null, 28, new DateTime(2022, 3, 7, 17, 38, 42, 964, DateTimeKind.Local).AddTicks(2594), "Rem placeat odit nihil molestiae inventore sed ut.\nQuia voluptatem dolor facere qui mollitia ab." },
                    { 173, 6, null, false, null, 27, new DateTime(2023, 2, 4, 3, 47, 12, 111, DateTimeKind.Local).AddTicks(7096), "Quos incidunt quasi qui ratione recusandae repudiandae dolor consectetur.\nOdio cupiditate maxime." },
                    { 174, 4, null, false, null, 51, new DateTime(2022, 11, 20, 10, 51, 14, 999, DateTimeKind.Local).AddTicks(4750), "Sint et vel et et neque dignissimos.\nPerferendis enim et voluptatem corrupti et voluptatem atque reiciendis sunt." },
                    { 175, 2, null, false, null, 62, new DateTime(2022, 9, 2, 23, 3, 23, 452, DateTimeKind.Local).AddTicks(7169), "Voluptatem voluptatibus dolorem necessitatibus et sapiente aut libero omnis dolores.\nQui rem est nisi ex provident quo tempore eveniet sapiente." },
                    { 176, 8, null, false, null, 45, new DateTime(2022, 10, 15, 9, 27, 0, 491, DateTimeKind.Local).AddTicks(6758), "Illum ut et minus corrupti itaque voluptates natus qui.\nQuisquam dolores aut illum culpa nobis atque minus inventore." },
                    { 177, 1, null, false, null, 29, new DateTime(2022, 10, 6, 13, 57, 59, 736, DateTimeKind.Local).AddTicks(7290), "Quae aut minima dolorum.\nQuaerat ratione voluptatum esse iure." },
                    { 178, 1, null, false, null, 10, new DateTime(2022, 4, 18, 4, 7, 10, 332, DateTimeKind.Local).AddTicks(253), "Ullam consectetur sit.\nQui doloribus quasi omnis deleniti molestias voluptatem." },
                    { 179, 3, null, false, null, 22, new DateTime(2022, 9, 19, 18, 57, 42, 288, DateTimeKind.Local).AddTicks(4717), "Ab qui officia deserunt autem error tenetur facilis et.\nConsectetur cum ut iste." },
                    { 180, 8, null, false, null, 11, new DateTime(2022, 12, 24, 23, 34, 24, 975, DateTimeKind.Local).AddTicks(724), "Rerum voluptatem voluptatem qui dicta harum et recusandae.\nQuia dignissimos natus tenetur dolores assumenda iste et debitis similique." },
                    { 181, 4, null, false, null, 57, new DateTime(2022, 12, 30, 20, 59, 3, 800, DateTimeKind.Local).AddTicks(3846), "Ut quam libero commodi labore expedita quaerat aut.\nArchitecto ut aperiam odio laboriosam est fugiat et est repellat." },
                    { 182, 6, null, false, null, 30, new DateTime(2022, 11, 24, 15, 19, 13, 620, DateTimeKind.Local).AddTicks(9817), "Expedita nesciunt officia cumque et magnam sed aperiam.\nUt numquam adipisci alias." },
                    { 183, 7, null, false, null, 51, new DateTime(2022, 9, 21, 0, 59, 22, 415, DateTimeKind.Local).AddTicks(9838), "Soluta facere nulla accusantium laudantium.\nQui tempore fugiat quam eveniet expedita harum ut." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 184, 3, null, false, null, 58, new DateTime(2022, 4, 23, 4, 5, 38, 789, DateTimeKind.Local).AddTicks(9092), "Excepturi id facere veniam saepe.\nConsequatur consequatur autem ut dolorum." },
                    { 185, 3, null, false, null, 49, new DateTime(2022, 2, 21, 12, 44, 15, 820, DateTimeKind.Local).AddTicks(5867), "Voluptas accusantium consequatur nulla dolor blanditiis delectus eos eius.\nAd qui sint cum numquam voluptate sed illum." },
                    { 186, 7, null, false, null, 51, new DateTime(2022, 2, 28, 20, 52, 38, 833, DateTimeKind.Local).AddTicks(9236), "Iste ut sit.\nEius tenetur et." },
                    { 187, 4, null, false, null, 34, new DateTime(2023, 2, 2, 16, 33, 0, 80, DateTimeKind.Local).AddTicks(5933), "Culpa alias non.\nAutem reprehenderit ducimus voluptatum ea ratione sed." },
                    { 188, 2, null, false, null, 22, new DateTime(2022, 9, 13, 9, 7, 2, 24, DateTimeKind.Local).AddTicks(9843), "Necessitatibus labore numquam qui quo aut.\nQuia ut corrupti aut et et libero." },
                    { 189, 7, null, false, null, 61, new DateTime(2022, 12, 27, 7, 13, 30, 638, DateTimeKind.Local).AddTicks(3695), "Vero a cum tempora necessitatibus aut.\nVoluptate vel voluptatibus consectetur ut consectetur et in doloremque nisi." },
                    { 190, 1, null, false, null, 54, new DateTime(2022, 3, 19, 17, 55, 12, 998, DateTimeKind.Local).AddTicks(7996), "Maiores eligendi sit ea error officiis asperiores.\nExcepturi perspiciatis et sit exercitationem a expedita et et iste." },
                    { 191, 7, null, false, null, 2, new DateTime(2022, 9, 28, 3, 38, 29, 640, DateTimeKind.Local).AddTicks(8984), "Quis modi quod similique rerum.\nIncidunt doloremque dicta fuga." },
                    { 192, 6, null, false, null, 37, new DateTime(2022, 8, 19, 10, 18, 46, 889, DateTimeKind.Local).AddTicks(109), "Et molestiae unde aperiam quaerat nulla tempora vel corrupti.\nEt quo animi sit qui." },
                    { 193, 1, null, false, null, 47, new DateTime(2022, 9, 13, 17, 5, 54, 586, DateTimeKind.Local).AddTicks(2624), "Est voluptas ullam ex consequatur omnis corporis.\nDoloribus nulla totam et nemo ullam et cum similique reprehenderit." },
                    { 194, 2, null, false, null, 53, new DateTime(2022, 6, 13, 4, 1, 53, 668, DateTimeKind.Local).AddTicks(3586), "Aut voluptatem temporibus et neque veniam iure asperiores impedit praesentium.\nIllum nulla et sunt nam id ducimus voluptatem." },
                    { 195, 3, null, false, null, 58, new DateTime(2022, 5, 23, 11, 5, 54, 180, DateTimeKind.Local).AddTicks(9154), "Voluptatibus sunt quo minus vel cum.\nCommodi autem quos ex odit eveniet a." },
                    { 196, 7, null, false, null, 11, new DateTime(2023, 2, 6, 13, 37, 34, 468, DateTimeKind.Local).AddTicks(2820), "In id delectus earum non laboriosam laudantium temporibus laudantium repellat.\nOfficiis ullam eaque eum omnis nihil voluptates eum." },
                    { 197, 6, null, false, null, 48, new DateTime(2022, 8, 16, 19, 21, 50, 210, DateTimeKind.Local).AddTicks(9239), "Ratione quia eius.\nSint adipisci qui id." },
                    { 198, 5, null, false, null, 8, new DateTime(2022, 10, 16, 20, 52, 12, 113, DateTimeKind.Local).AddTicks(3614), "Deleniti omnis tenetur dicta incidunt vel.\nCulpa omnis quae vitae autem deleniti dolorum excepturi omnis." },
                    { 199, 1, null, false, null, 7, new DateTime(2022, 10, 21, 12, 32, 36, 338, DateTimeKind.Local).AddTicks(235), "Ea non impedit at ut consequatur fuga non deserunt.\nBeatae deserunt officia vel culpa voluptas aspernatur ut." },
                    { 200, 6, null, false, null, 9, new DateTime(2022, 8, 9, 14, 12, 2, 602, DateTimeKind.Local).AddTicks(5332), "Ipsam ea quis eius quia enim aspernatur iste provident architecto.\nNumquam quasi et dolorem aut explicabo." },
                    { 201, 6, null, false, null, 27, new DateTime(2023, 1, 1, 17, 7, 7, 166, DateTimeKind.Local).AddTicks(7836), "Voluptate ab earum temporibus consequatur.\nTempora officia asperiores ut dicta enim." },
                    { 202, 8, null, false, null, 61, new DateTime(2022, 11, 16, 16, 49, 11, 881, DateTimeKind.Local).AddTicks(643), "Nihil consequuntur repellendus.\nNon provident est beatae." },
                    { 203, 4, null, false, null, 9, new DateTime(2022, 12, 12, 19, 46, 9, 655, DateTimeKind.Local).AddTicks(7610), "Voluptatem non laudantium.\nIusto sit rem modi dicta iure molestias quaerat autem." },
                    { 204, 3, null, false, null, 61, new DateTime(2022, 4, 26, 5, 57, 56, 44, DateTimeKind.Local).AddTicks(8311), "Ipsam et earum ex dolorem repellendus eos minus in.\nAspernatur earum possimus quod aliquam." },
                    { 205, 1, null, false, null, 54, new DateTime(2022, 8, 23, 10, 46, 3, 31, DateTimeKind.Local).AddTicks(6688), "Nihil non sunt eos sunt.\nConsequatur fugiat culpa vel aut." },
                    { 206, 6, null, false, null, 26, new DateTime(2022, 8, 9, 16, 56, 16, 908, DateTimeKind.Local).AddTicks(6255), "Earum voluptatem illum officiis sit amet nihil dolorem a odio.\nVitae quia autem omnis." },
                    { 207, 6, null, false, null, 63, new DateTime(2022, 5, 1, 5, 18, 36, 686, DateTimeKind.Local).AddTicks(7273), "Esse impedit eveniet nihil illo enim tempore consequatur dolorem.\nOmnis dolorem in." },
                    { 208, 3, null, false, null, 35, new DateTime(2022, 4, 13, 13, 51, 47, 382, DateTimeKind.Local).AddTicks(1393), "Accusamus molestiae sint voluptas dolores quidem distinctio facilis libero omnis.\nQuidem natus vel." },
                    { 209, 4, null, false, null, 36, new DateTime(2022, 10, 18, 7, 44, 27, 953, DateTimeKind.Local).AddTicks(9616), "Nihil dolores ipsam rerum.\nOptio dolores doloribus eligendi in qui iusto itaque non omnis." },
                    { 210, 4, null, false, null, 35, new DateTime(2022, 11, 9, 5, 38, 46, 953, DateTimeKind.Local).AddTicks(552), "Voluptatibus vero sit numquam.\nUllam qui eligendi placeat ullam quia debitis consequatur." },
                    { 211, 6, null, false, null, 5, new DateTime(2022, 5, 19, 22, 20, 33, 995, DateTimeKind.Local).AddTicks(7032), "Aspernatur velit vero nesciunt aliquam reprehenderit.\nEst laboriosam recusandae molestias et et incidunt nihil alias quae." },
                    { 212, 7, null, false, null, 40, new DateTime(2022, 8, 10, 15, 42, 56, 604, DateTimeKind.Local).AddTicks(514), "Cupiditate tenetur numquam voluptas debitis.\nNon omnis et aut nam nostrum inventore nobis reiciendis." },
                    { 213, 1, null, false, null, 15, new DateTime(2022, 9, 28, 8, 6, 32, 455, DateTimeKind.Local).AddTicks(120), "Eum quibusdam tempora expedita iure nostrum rerum quod.\nLaborum id cum et consequatur reprehenderit." },
                    { 214, 8, null, false, null, 45, new DateTime(2023, 1, 27, 16, 48, 12, 12, DateTimeKind.Local).AddTicks(4481), "Placeat rerum explicabo provident esse voluptatem.\nCorrupti explicabo autem." },
                    { 215, 3, null, false, null, 55, new DateTime(2022, 6, 20, 15, 39, 30, 295, DateTimeKind.Local).AddTicks(1500), "Omnis est consectetur et quisquam et repellendus aut dolor est.\nQui doloribus et omnis." },
                    { 216, 3, null, false, null, 1, new DateTime(2022, 5, 26, 7, 24, 48, 126, DateTimeKind.Local).AddTicks(2715), "Voluptatum id facilis.\nNostrum voluptatibus laudantium accusantium." },
                    { 217, 8, null, false, null, 16, new DateTime(2022, 6, 10, 19, 33, 56, 431, DateTimeKind.Local).AddTicks(4828), "Qui asperiores aut iusto voluptates aperiam et laborum odit.\nVelit in ducimus." },
                    { 218, 5, null, false, null, 10, new DateTime(2022, 8, 6, 8, 29, 52, 228, DateTimeKind.Local).AddTicks(6617), "Ratione sunt praesentium ut aperiam et necessitatibus.\nVel magnam magni adipisci quos nemo." },
                    { 219, 7, null, false, null, 37, new DateTime(2022, 9, 14, 1, 19, 16, 822, DateTimeKind.Local).AddTicks(5264), "Et ut assumenda et velit omnis tempora officia cupiditate possimus.\nAutem omnis qui ut iure dolores quam aut." },
                    { 220, 3, null, false, null, 34, new DateTime(2023, 1, 5, 11, 34, 52, 465, DateTimeKind.Local).AddTicks(3144), "Modi facilis itaque ullam reiciendis id.\nQuaerat et sequi dolorem." },
                    { 221, 3, null, false, null, 27, new DateTime(2022, 5, 19, 4, 20, 57, 147, DateTimeKind.Local).AddTicks(2180), "Iure non quibusdam.\nAut accusamus neque minima." },
                    { 222, 1, null, false, null, 5, new DateTime(2022, 7, 4, 11, 0, 40, 105, DateTimeKind.Local).AddTicks(5500), "Iste in dolor ex non.\nEst sunt voluptatum aspernatur itaque saepe atque harum id." },
                    { 223, 1, null, false, null, 24, new DateTime(2022, 7, 3, 2, 58, 9, 952, DateTimeKind.Local).AddTicks(3113), "Consequatur molestias deserunt maiores distinctio ea voluptatem.\nSit esse et dolor est a." },
                    { 224, 8, null, false, null, 16, new DateTime(2022, 4, 16, 2, 43, 16, 0, DateTimeKind.Local).AddTicks(9440), "Delectus voluptatem laboriosam ipsa.\nEt sequi nihil voluptatem quos quaerat quisquam et autem." },
                    { 225, 6, null, false, null, 61, new DateTime(2022, 6, 28, 16, 26, 19, 911, DateTimeKind.Local).AddTicks(1741), "Porro fugit similique soluta commodi adipisci quam sed error.\nNisi voluptas quod enim blanditiis sint." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 226, 4, null, false, null, 46, new DateTime(2022, 9, 11, 15, 38, 12, 520, DateTimeKind.Local).AddTicks(1877), "Commodi molestias quia nihil tenetur quo officia.\nDolore id tenetur eius quos." },
                    { 227, 7, null, false, null, 6, new DateTime(2022, 4, 28, 19, 22, 49, 197, DateTimeKind.Local).AddTicks(7351), "Facilis est sed.\nNesciunt deserunt sed ut." },
                    { 228, 2, null, false, null, 17, new DateTime(2022, 4, 6, 8, 23, 55, 193, DateTimeKind.Local).AddTicks(1641), "Nihil et id fugiat voluptatibus.\nEx consequatur aperiam similique." },
                    { 229, 5, null, false, null, 4, new DateTime(2022, 11, 24, 10, 34, 47, 513, DateTimeKind.Local).AddTicks(2080), "Tenetur enim magnam cupiditate sit necessitatibus modi assumenda libero illo.\nOmnis ut quasi harum possimus consequatur voluptatem dolores culpa dolores." },
                    { 230, 4, null, false, null, 21, new DateTime(2022, 11, 26, 2, 11, 29, 577, DateTimeKind.Local).AddTicks(709), "Inventore modi aspernatur.\nUnde consequatur ipsum velit sunt et repellendus." },
                    { 231, 5, null, false, null, 23, new DateTime(2022, 12, 10, 12, 45, 8, 424, DateTimeKind.Local).AddTicks(1367), "Ut quisquam corporis molestias in aliquid.\nEt quidem consequatur." },
                    { 232, 7, null, false, null, 63, new DateTime(2022, 11, 26, 16, 3, 35, 224, DateTimeKind.Local).AddTicks(9894), "Qui odio animi ratione.\nRerum explicabo qui quos." },
                    { 233, 3, null, false, null, 37, new DateTime(2022, 8, 1, 23, 4, 7, 92, DateTimeKind.Local).AddTicks(1526), "Dolorem labore ipsum pariatur corrupti repudiandae ducimus soluta.\nQuia ipsam est id incidunt rerum." },
                    { 234, 1, null, false, null, 47, new DateTime(2022, 7, 19, 14, 47, 22, 241, DateTimeKind.Local).AddTicks(2914), "Voluptatem consequatur accusantium similique minus.\nVoluptas laudantium voluptas nostrum." },
                    { 235, 6, null, false, null, 59, new DateTime(2023, 1, 18, 7, 49, 37, 283, DateTimeKind.Local).AddTicks(8518), "Quia excepturi fugiat est.\nSint sint voluptates officia architecto aliquid fugit dolorum ipsam." },
                    { 236, 7, null, false, null, 31, new DateTime(2022, 6, 14, 2, 27, 56, 794, DateTimeKind.Local).AddTicks(9497), "Sed animi unde.\nAutem necessitatibus in vel officia repellat esse." },
                    { 237, 1, null, false, null, 38, new DateTime(2022, 2, 16, 22, 34, 28, 310, DateTimeKind.Local).AddTicks(435), "Aliquam exercitationem ipsam ratione numquam.\nAliquid enim hic." },
                    { 238, 1, null, false, null, 7, new DateTime(2022, 10, 20, 23, 40, 32, 293, DateTimeKind.Local).AddTicks(4431), "Atque culpa impedit ad molestiae voluptatem recusandae id tempore.\nExercitationem sequi molestias rem amet commodi similique voluptate eum vero." },
                    { 239, 5, null, false, null, 32, new DateTime(2023, 2, 12, 10, 33, 3, 404, DateTimeKind.Local).AddTicks(408), "Doloribus reiciendis repellendus et reiciendis eaque earum.\nHarum sunt laudantium earum quod est similique sint." },
                    { 240, 6, null, false, null, 34, new DateTime(2022, 12, 1, 7, 44, 30, 766, DateTimeKind.Local).AddTicks(2721), "Officiis aspernatur non.\nInventore inventore sit a." },
                    { 241, 6, null, false, null, 25, new DateTime(2022, 10, 13, 22, 41, 54, 240, DateTimeKind.Local).AddTicks(8118), "Ut molestiae ab.\nDolor quisquam sunt assumenda atque recusandae enim commodi et." },
                    { 242, 2, null, false, null, 40, new DateTime(2022, 9, 12, 21, 16, 59, 690, DateTimeKind.Local).AddTicks(8096), "Qui molestias fugit itaque.\nAperiam repellat et et quia." },
                    { 243, 3, null, false, null, 8, new DateTime(2022, 4, 2, 8, 40, 17, 343, DateTimeKind.Local).AddTicks(2275), "Rem error consequuntur nulla.\nMaxime ea officiis esse." },
                    { 244, 2, null, false, null, 26, new DateTime(2022, 7, 1, 23, 0, 20, 163, DateTimeKind.Local).AddTicks(6743), "Praesentium odio quod quasi ipsum in.\nAut nulla est itaque repellendus." },
                    { 245, 1, null, false, null, 21, new DateTime(2022, 10, 26, 2, 32, 50, 278, DateTimeKind.Local).AddTicks(1401), "Aut dolores at pariatur eos autem ipsam maxime quis fuga.\nEveniet non fuga aliquid." },
                    { 246, 3, null, false, null, 13, new DateTime(2022, 3, 24, 9, 39, 52, 437, DateTimeKind.Local).AddTicks(1731), "Quam deserunt maiores totam tenetur blanditiis ab sunt est.\nFacilis quo sequi consequatur natus veritatis ex est." },
                    { 247, 7, null, false, null, 30, new DateTime(2023, 2, 8, 13, 42, 1, 659, DateTimeKind.Local).AddTicks(4961), "Nesciunt ex nihil quae impedit modi ab.\nEos aspernatur possimus qui ut hic corrupti doloribus voluptatem." },
                    { 248, 4, null, false, null, 22, new DateTime(2023, 1, 28, 13, 47, 37, 334, DateTimeKind.Local).AddTicks(32), "Voluptates id nisi quia sit aspernatur aut recusandae quas.\nEst cum et." },
                    { 249, 2, null, false, null, 34, new DateTime(2022, 4, 5, 7, 44, 2, 664, DateTimeKind.Local).AddTicks(844), "Pariatur dolores reiciendis aut magnam doloribus.\nAccusantium est enim quos." },
                    { 250, 8, null, false, null, 29, new DateTime(2022, 10, 2, 16, 49, 43, 821, DateTimeKind.Local).AddTicks(6810), "Voluptatem nulla aspernatur voluptates.\nEius soluta quod." },
                    { 251, 2, null, false, null, 34, new DateTime(2022, 3, 19, 14, 4, 49, 345, DateTimeKind.Local).AddTicks(6173), "Voluptas autem voluptatibus cum culpa et odio suscipit et odio.\nEa dignissimos autem quam rerum architecto optio aut accusantium." },
                    { 252, 2, null, false, null, 27, new DateTime(2022, 12, 30, 4, 56, 58, 303, DateTimeKind.Local).AddTicks(5849), "Dolore aut et occaecati distinctio quod accusantium numquam et et.\nTemporibus praesentium qui asperiores." },
                    { 253, 6, null, false, null, 11, new DateTime(2022, 7, 26, 6, 17, 7, 230, DateTimeKind.Local).AddTicks(4135), "Omnis quaerat vel labore dicta maiores nulla dolores provident cumque.\nPraesentium laborum libero quam blanditiis dolorem et quis eveniet." },
                    { 254, 6, null, false, null, 45, new DateTime(2022, 8, 12, 4, 17, 56, 796, DateTimeKind.Local).AddTicks(742), "Enim voluptatem sunt incidunt.\nPraesentium earum sed velit consequuntur ea itaque optio laudantium dolore." },
                    { 255, 5, null, false, null, 51, new DateTime(2022, 6, 30, 8, 37, 52, 126, DateTimeKind.Local).AddTicks(5284), "Impedit veniam error ipsum voluptatem nulla sint quibusdam incidunt commodi.\nSuscipit ea ad officia aliquid tempore repellat." },
                    { 256, 3, null, false, null, 3, new DateTime(2023, 2, 14, 9, 11, 19, 408, DateTimeKind.Local).AddTicks(2318), "Consequatur ipsam expedita veniam minima ea accusantium nostrum eveniet sunt.\nEst qui consequatur nisi." },
                    { 257, 6, null, false, null, 30, new DateTime(2022, 12, 30, 16, 24, 38, 818, DateTimeKind.Local).AddTicks(1687), "Id culpa autem aut sint.\nUt ullam exercitationem sed tempore nisi nulla ratione." },
                    { 258, 6, null, false, null, 63, new DateTime(2022, 2, 21, 18, 10, 50, 785, DateTimeKind.Local).AddTicks(2781), "Voluptatibus qui ratione.\nEt placeat nesciunt." },
                    { 259, 4, null, false, null, 11, new DateTime(2022, 8, 6, 1, 17, 40, 382, DateTimeKind.Local).AddTicks(862), "Sunt illo sed qui.\nId est consequatur asperiores." },
                    { 260, 2, null, false, null, 32, new DateTime(2022, 4, 26, 14, 40, 48, 436, DateTimeKind.Local).AddTicks(9997), "Ea quis et aut officiis dolor.\nCumque occaecati dolore accusamus laudantium." },
                    { 261, 2, null, false, null, 61, new DateTime(2022, 8, 31, 10, 24, 0, 464, DateTimeKind.Local).AddTicks(1244), "Error iure sunt aut quidem dolore magni in sequi perferendis.\nMaxime quia ut deserunt nobis et nihil vitae." },
                    { 262, 7, null, false, null, 15, new DateTime(2022, 8, 17, 15, 2, 18, 507, DateTimeKind.Local).AddTicks(6224), "Qui voluptas consequatur aut provident ipsum.\nVoluptates consequatur et incidunt consequatur quasi rem consequatur et." },
                    { 263, 5, null, false, null, 31, new DateTime(2022, 9, 1, 17, 15, 44, 59, DateTimeKind.Local).AddTicks(7145), "Architecto adipisci quo exercitationem dolorem necessitatibus omnis.\nRepellat sit sapiente accusantium vero doloribus dolorem." },
                    { 264, 2, null, false, null, 47, new DateTime(2022, 4, 13, 16, 26, 38, 890, DateTimeKind.Local).AddTicks(525), "Ratione non dolore quia autem placeat dicta impedit repellendus aperiam.\nQuidem rerum impedit occaecati officiis." },
                    { 265, 1, null, false, null, 38, new DateTime(2022, 10, 1, 0, 55, 40, 874, DateTimeKind.Local).AddTicks(8100), "Quis reiciendis saepe voluptatem vel saepe.\nEos et aut in voluptates vero voluptas sit iure." },
                    { 266, 3, null, false, null, 33, new DateTime(2023, 1, 22, 4, 13, 53, 982, DateTimeKind.Local).AddTicks(7398), "Neque sunt et assumenda.\nMaxime ut a impedit expedita nihil tempora magni molestias aut." },
                    { 267, 8, null, false, null, 34, new DateTime(2022, 10, 14, 12, 37, 11, 748, DateTimeKind.Local).AddTicks(3786), "Quidem quos et.\nQuibusdam blanditiis molestiae placeat." }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsDeletedOnlyForSender", "IsSeen", "ReplyMessageId", "SenderId", "SentAt", "Text" },
                values: new object[,]
                {
                    { 268, 6, null, false, null, 63, new DateTime(2022, 7, 27, 12, 41, 51, 933, DateTimeKind.Local).AddTicks(4365), "Voluptatem velit vitae molestiae aut sed facilis.\nQuia corrupti occaecati beatae sint rem pariatur veritatis veniam." },
                    { 269, 1, null, false, null, 63, new DateTime(2022, 12, 9, 6, 31, 43, 750, DateTimeKind.Local).AddTicks(146), "Et eaque et ipsum.\nSoluta eos voluptas." },
                    { 270, 6, null, false, null, 57, new DateTime(2022, 5, 7, 17, 14, 50, 69, DateTimeKind.Local).AddTicks(323), "Placeat sint dignissimos quibusdam nostrum aperiam.\nRatione odio consequatur." },
                    { 271, 5, null, false, null, 31, new DateTime(2022, 4, 19, 18, 5, 37, 657, DateTimeKind.Local).AddTicks(9839), "Dignissimos delectus quia unde et cum omnis rem voluptates.\nAtque vel numquam et est accusamus nesciunt." },
                    { 272, 5, null, false, null, 9, new DateTime(2022, 11, 29, 5, 32, 24, 46, DateTimeKind.Local).AddTicks(4015), "Eligendi repellat laudantium earum quasi sit aut.\nEarum aut enim eius provident quis tempore reprehenderit qui modi." },
                    { 273, 1, null, false, null, 48, new DateTime(2022, 3, 7, 6, 43, 40, 260, DateTimeKind.Local).AddTicks(5226), "Nisi quo aperiam tempora fugit repellat et blanditiis laborum omnis.\nVoluptatem qui aperiam omnis similique et nobis pariatur." },
                    { 274, 8, null, false, null, 3, new DateTime(2022, 11, 12, 10, 30, 12, 471, DateTimeKind.Local).AddTicks(2321), "Dolore maiores quia.\nSed blanditiis molestiae eius molestiae." },
                    { 275, 7, null, false, null, 10, new DateTime(2022, 3, 9, 3, 39, 9, 530, DateTimeKind.Local).AddTicks(562), "Repellat nemo iure alias officia praesentium rerum.\nSapiente dolorum amet non velit quo sit omnis culpa." },
                    { 276, 7, null, false, null, 14, new DateTime(2023, 1, 29, 3, 43, 4, 802, DateTimeKind.Local).AddTicks(6234), "Possimus ut sit.\nOdit dolores quae." },
                    { 277, 3, null, false, null, 63, new DateTime(2022, 2, 26, 19, 38, 12, 796, DateTimeKind.Local).AddTicks(1517), "Ullam nisi neque repellendus.\nBeatae tenetur magnam doloribus soluta culpa qui et." },
                    { 278, 5, null, false, null, 38, new DateTime(2022, 11, 16, 11, 24, 12, 224, DateTimeKind.Local).AddTicks(8100), "Est accusamus natus recusandae odit.\nPorro nihil non dolor repellendus." },
                    { 279, 7, null, false, null, 25, new DateTime(2022, 4, 24, 6, 28, 30, 448, DateTimeKind.Local).AddTicks(4586), "Similique iure odit animi et laboriosam temporibus.\nQui quos vero." },
                    { 280, 6, null, false, null, 51, new DateTime(2023, 1, 15, 14, 45, 59, 135, DateTimeKind.Local).AddTicks(8806), "Maxime ea eaque in similique tempora et harum autem rerum.\nItaque voluptatem perspiciatis aperiam." },
                    { 281, 6, null, false, null, 18, new DateTime(2022, 4, 8, 17, 27, 49, 733, DateTimeKind.Local).AddTicks(8293), "Minima molestiae reiciendis cum adipisci aut consequatur nam natus.\nEt qui consectetur laudantium hic incidunt." },
                    { 282, 5, null, false, null, 24, new DateTime(2022, 6, 17, 6, 35, 31, 823, DateTimeKind.Local).AddTicks(7358), "Dolor libero debitis atque rerum ad.\nMolestiae labore iusto quis exercitationem perferendis laborum et ullam modi." },
                    { 283, 7, null, false, null, 1, new DateTime(2022, 5, 12, 0, 41, 36, 504, DateTimeKind.Local).AddTicks(7424), "Sunt excepturi voluptatem ex et illo eos provident.\nIllum quo numquam odio est aperiam perspiciatis alias." },
                    { 284, 8, null, false, null, 51, new DateTime(2022, 5, 7, 6, 50, 17, 126, DateTimeKind.Local).AddTicks(9709), "Perferendis nesciunt sit omnis vitae cum quo qui mollitia.\nNostrum voluptatem consequuntur vitae maxime exercitationem ipsa expedita provident veritatis." },
                    { 285, 2, null, false, null, 29, new DateTime(2022, 12, 18, 8, 32, 34, 85, DateTimeKind.Local).AddTicks(7438), "Quo tempore labore eligendi.\nOptio impedit hic voluptate et quo praesentium." },
                    { 286, 5, null, false, null, 36, new DateTime(2022, 9, 11, 15, 25, 9, 478, DateTimeKind.Local).AddTicks(7611), "Nostrum excepturi alias alias provident omnis.\nUnde possimus nemo modi dolorem molestias natus et aliquam." },
                    { 287, 2, null, false, null, 12, new DateTime(2023, 1, 21, 0, 39, 12, 294, DateTimeKind.Local).AddTicks(5816), "Perferendis laboriosam incidunt aliquid voluptatem quia.\nBlanditiis ipsam molestias explicabo dolorum consequuntur debitis." },
                    { 288, 5, null, false, null, 5, new DateTime(2023, 1, 30, 22, 6, 56, 380, DateTimeKind.Local).AddTicks(1715), "Earum veritatis voluptatem corrupti dignissimos totam rerum facere.\nTempore ab quia dolor porro eaque." },
                    { 289, 1, null, false, null, 18, new DateTime(2022, 10, 31, 8, 42, 6, 549, DateTimeKind.Local).AddTicks(3576), "Quisquam molestiae est et consequatur consequatur autem laudantium qui.\nConsequatur similique pariatur consequuntur doloremque minus." },
                    { 290, 5, null, false, null, 3, new DateTime(2022, 9, 27, 3, 30, 59, 750, DateTimeKind.Local).AddTicks(4076), "Odio totam dicta dignissimos cupiditate officia tempora occaecati exercitationem dolor.\nCupiditate est vero distinctio maxime enim non est soluta." },
                    { 291, 4, null, false, null, 53, new DateTime(2022, 4, 14, 18, 33, 13, 793, DateTimeKind.Local).AddTicks(4337), "Sequi sed voluptatem alias non repellat iste vero ea architecto.\nNulla tempora suscipit et labore." },
                    { 292, 6, null, false, null, 19, new DateTime(2022, 4, 19, 4, 26, 21, 550, DateTimeKind.Local).AddTicks(3260), "Magnam provident ducimus facere facere.\nEveniet rerum exercitationem veritatis rerum." },
                    { 293, 4, null, false, null, 3, new DateTime(2022, 9, 14, 20, 5, 38, 920, DateTimeKind.Local).AddTicks(6466), "Aliquam aut hic aut omnis.\nQuam laboriosam incidunt et et." },
                    { 294, 8, null, false, null, 26, new DateTime(2022, 3, 31, 8, 48, 36, 796, DateTimeKind.Local).AddTicks(9479), "Ut nisi est dicta qui dignissimos vel.\nDolores blanditiis voluptatem exercitationem rerum ex." },
                    { 295, 6, null, false, null, 4, new DateTime(2022, 9, 4, 14, 30, 26, 890, DateTimeKind.Local).AddTicks(5614), "Quia expedita omnis ut magnam cumque reprehenderit aperiam.\nDucimus ratione quia tempora." },
                    { 296, 7, null, false, null, 43, new DateTime(2022, 6, 19, 21, 34, 25, 713, DateTimeKind.Local).AddTicks(4963), "Corporis repudiandae sit inventore reprehenderit sunt eius quos alias.\nAccusantium rem doloremque." },
                    { 297, 5, null, false, null, 11, new DateTime(2022, 4, 19, 15, 56, 6, 833, DateTimeKind.Local).AddTicks(6519), "Autem libero nobis deleniti aut.\nRecusandae cumque sequi exercitationem sit reiciendis." },
                    { 298, 5, null, false, null, 60, new DateTime(2022, 12, 23, 5, 30, 17, 172, DateTimeKind.Local).AddTicks(9875), "Sunt delectus corporis alias aliquam est consequuntur provident mollitia.\nNemo dolorum quia aut voluptatum laboriosam sed." },
                    { 299, 8, null, false, null, 59, new DateTime(2022, 4, 12, 6, 53, 36, 947, DateTimeKind.Local).AddTicks(2291), "Sint aut sed aut voluptatem quisquam reprehenderit rerum rem impedit.\nUnde itaque provident nesciunt et nemo sed." },
                    { 300, 3, null, false, null, 35, new DateTime(2022, 4, 18, 2, 22, 14, 834, DateTimeKind.Local).AddTicks(6286), "Vitae velit sapiente rerum tempore nemo nihil ullam.\nMolestias enim in beatae." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 45, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 4 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 5 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 6 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "ChatMemberPermission",
                keyColumns: new[] { "MembersId", "PermissionsId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionRole",
                keyColumns: new[] { "DefaultPermissionsId", "RolesId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ChatMember",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
