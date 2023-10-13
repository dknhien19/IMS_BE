using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Data.Extensions;

public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region CompanyType
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 1,
            Name = "Doanh nghiệp tư nhân",
            Description = "Doanh nghiệp tư nhân",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 2,
            Name = "Công ty trách nhiệm hữu hạn một thành viên",
            Description = "Công ty trách nhiệm hữu hạn một thành viên",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 3,
            Name = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
            Description = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 4,
            Name = "Công ty cổ phần",
            Description = "Công ty cổ phần",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 5,
            Name = "Công ty hợp danh",
            Description = "Công ty hợp danh",
        });
        #endregion

        #region Service
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 1,
            Name = "Thuê Chỗ",
            Description = "Thuê Chỗ",
        });
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 2,
            Name = "Thêm 1U",
            Description = "Thêm 1U",
        });
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 3,
            Name = "Công suất 100",
            Description = "Công suất 100",
        });
        #endregion

        #region User
        var hasher = new PasswordHasher<User>();

        List<Guid> seedGuids = new List<Guid>();
        for (int i = 1; i <= 5; i++)
        {
            seedGuids.Add(GenerateSeededGuid(i));
        }

        #region Roles
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(1),
            Name = "Customer",
            Description = "Customer",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(2),
            Name = "IT",
            Description = "IT Staff",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(3),
            Name = "Sale",
            Description = "Sale",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(4),
            Name = "Manager",
            Description = "Manager",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(5),
            Name = "Admin",
            Description = "Admin",
            isDeactive = false,
        });
        #endregion

        for (var i = 2; i <= 5; i++)
        {
            var username = "";
            switch (i)
            {
                case 2:
                    username = "it";
                    break;
                case 3:
                    username = "sale";
                    break;
                case 4:
                    username = "manager";
                    break;
                case 5:
                    username = "admin";
                    break;
            }

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = seedGuids[i - 1],
                UserName = username,
                NormalizedUserName = username,
                Email = username + "@gmail.com",
                NormalizedEmail = username + "@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                Fullname = "Fullname" + i,
                Address = "Address" + i,
                PhoneNumber = "000000000" + i,
                CurrenNoticeCount = 0,
                IsDeleted = false,
            });

            #region UserRole
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                RoleId = GenerateSeededGuid(i),
                UserId = GenerateSeededGuid(i),
            });
            #endregion
        }
        #endregion
    }

    private static Guid GenerateSeededGuid(int seed)
    {
        var r = new Random(seed);
        var guid = new byte[16];
        r.NextBytes(guid);

        return new Guid(guid);
    }
}
