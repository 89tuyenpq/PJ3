using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<PostOfficeContext>();

                // Migrate the database
                await context.Database.MigrateAsync();

                // Check if any data exists
                if (!context.Offices.Any())
                {
                    // Thêm dữ liệu mẫu cho văn phòng
                    context.Offices.AddRange(
                        new Office { Name = "Văn phòng Hà Nội", Address = "Hà Nội, Việt Nam" },
                        new Office { Name = "Văn phòng TP.HCM", Address = "TP.HCM, Việt Nam" }
                    );
                }

                if (!context.Services.Any())
                {
                    // Thêm dữ liệu mẫu cho dịch vụ
                    context.Services.AddRange(
                        new Service { Name = "Gửi thư", Description = "Dịch vụ gửi thư nhanh chóng" },
                        new Service { Name = "Gửi gói hàng", Description = "Dịch vụ gửi gói hàng đến nơi cần" }
                    );
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                await context.SaveChangesAsync();
            }
        }
    }
}
