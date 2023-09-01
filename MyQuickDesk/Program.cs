using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyQuickDesk.DAL.ApplicationUser;
using MyQuickDesk.DAL.DatabaseContext;
using MyQuickDesk.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyQuickDesk.DAL.Repository;
using MyQuickDesk.DAL.DatabaseContext;
using MyQuickDesk.DAL.ApplicationUser;
using System.Data;
using System.Globalization;

namespace MyQuickDesk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<MyQuickDeskContext>
                (
                    option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyQuickDeskConnectionString"))
                );

            builder.Services.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MyQuickDeskContext>();

            


            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
            builder.Services.AddScoped<IDeskRepository, DeskRepository>();
            builder.Services.AddScoped<IRoomRepository, RoomRepository>();
            builder.Services.AddScoped<IParkingRepository, ParkingRepository>();
            builder.Services.AddScoped<IUserContext, UserContext>();
            builder.Services.AddScoped<AdminRepository>();

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                  new CultureInfo("en-US"),
                  new CultureInfo("pl-PL"),

                };

                options.DefaultRequestCulture = new RequestCulture("en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            builder.Services.AddMvc()
                .AddViewLocalization()
                .AddDataAnnotationsLocalization();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }

    }
}