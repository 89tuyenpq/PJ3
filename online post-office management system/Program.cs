using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_Post_Office_Management_System.Data;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình kết nối cơ sở dữ liệu
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Thêm dịch vụ Identity với các tùy chọn bảo mật
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    // Cấu hình khóa tài khoản
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // Cấu hình yêu cầu mật khẩu
    options.Password.RequireDigit = true; // Phải có ít nhất một ký tự số
    options.Password.RequireLowercase = true; // Phải có ít nhất một ký tự thường
    options.Password.RequireUppercase = true; // Phải có ít nhất một ký tự hoa
    options.Password.RequireNonAlphanumeric = true; // Phải có ít nhất một ký tự đặc biệt
    options.Password.RequiredLength = 8; // Độ dài tối thiểu của mật khẩu
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// Cấu hình Identity
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login"; // Đường dẫn đến trang đăng nhập
    options.LogoutPath = "/Identity/Account/Logout"; // Đường dẫn đến trang đăng xuất
});

// Thêm dịch vụ cho MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Đảm bảo ứng dụng đã khởi tạo đầy đủ trước khi gọi CreateRoles
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await CreateRoles(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Middleware cho xác thực
app.UseAuthorization();  // Middleware cho ủy quyền

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Phương thức tạo vai trò
static async Task CreateRoles(IServiceProvider serviceProvider)
{
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    string[] roleNames = { "Admin", "User" }; // Các vai trò cần tạo
    IdentityResult roleResult;

    foreach (var roleName in roleNames)
    {
        var roleExist = await roleManager.RoleExistsAsync(roleName);
        if (!roleExist)
        {
            // Tạo vai trò mới
            roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }
}

app.Run();
