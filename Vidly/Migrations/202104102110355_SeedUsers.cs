namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'2178df5a-d8ec-499b-a33f-75066e15c0c5', N'test@test.com', 0, N'AGT1Rl/pr4P5JqXfpcxLIYz+peyHYVBoPs6dDuymEAdPNMP/Fk0GVLBvOCkHdDFYDg==', N'ad118498-6c4e-44d1-ab91-9bc7c55d8898', NULL, 0, 0, NULL, 1, 0, N'test@test.com')
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'4ef888aa-863d-402c-86ac-d45d7a38eff1', N'guest@vidly.com', 0, N'AJI6/KRMsk9ixSB93SOGFnCHgQCmnaqr3FWio1VyEiBI32deqqrZP66hhG9T2C0rjg==', N'45f2755b-cdf6-4825-8014-1b988dad3e14', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'6a6575db-c1a7-46b9-9068-7214dc5c4efe', N'admin@vidly.com', 0, N'AGBft8uXudCorAL7p6pBY/FSG8laYwkLmUpjT/bcCD/TLC4k0IBsurb6gqq6TOsPFQ==', N'e2880848-5df6-4107-8545-6269a21d7ce7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd51826b9-fb24-4cd1-a4e6-c00bcf3e2160', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6a6575db-c1a7-46b9-9068-7214dc5c4efe', N'd51826b9-fb24-4cd1-a4e6-c00bcf3e2160')
            ");
        }

        public override void Down()
        {
        }
    }
}
