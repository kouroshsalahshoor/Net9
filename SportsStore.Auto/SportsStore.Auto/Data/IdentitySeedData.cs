using Microsoft.AspNetCore.Identity;
using SportsStore.Auto.Client.Utilities;
using System.Security.Principal;

namespace SportsStore.Auto.Data
{
    public class IdentitySeedData
    {
        public static void CreateAdminAccount(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            CreateAdminAccountAsync(serviceProvider, configuration).Wait();
        }
        public static async Task CreateAdminAccountAsync(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            serviceProvider = serviceProvider.CreateScope().ServiceProvider;
            UserManager<ApplicationUser> userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = configuration["Data:AdminUser:Name"] ?? "admin";
            string email = configuration["Data:AdminUser:Email"] ?? "admin@example.com";
            string password = configuration["Data:AdminUser:Password"] ?? "1";
            //string role = configuration["Data:AdminUser:Role"] ?? Constants.Role_Admins;
            if (await userManager.FindByNameAsync(username) == null)
            {
                if (await roleManager.FindByNameAsync(Constants.Role_Admins) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(Constants.Role_Admins));
                    await roleManager.CreateAsync(new IdentityRole(Constants.Role_Users));
                }
                ApplicationUser user = new ApplicationUser
                {
                    UserName = username,
                    Email = email
                };
                IdentityResult result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Constants.Role_Admins);
                }
            }
        }
    }
}