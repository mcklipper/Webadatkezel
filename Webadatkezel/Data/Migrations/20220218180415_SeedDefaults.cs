using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webadatkezel.Data.Migrations
{
    public partial class SeedDefaults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES " +
                "(N'cbe454f5-e3ef-4c06-bb9e-4149e9148158', N'egripatrik@gmail.com', N'EGRIPATRIK@GMAIL.COM', N'egripatrik@gmail.com', N'EGRIPATRIK@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEPoJhhJ/S6CxWRX57NjtMDvjqmxu8rjQ1q72Mffxp5N7RXwEH77Z4ptj0NqSUrJ8zg==', N'BFHDT7P6MCCYNS4BT4SMT2U2X53KJKAF', N'3025d0c3-61e1-4de0-a269-cb8a37f380dc', NULL, 0, 0, NULL, 1, 0)"
            );

            migrationBuilder.Sql(
                "INSERT INTO Products (UserId, Name, Price, Comment, DateOfPurchase, Quantity) VALUES " +
                "('cbe454f5-e3ef-4c06-bb9e-4149e9148158', 'papucs', 3000, '', '2016-02-01', 20);"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
