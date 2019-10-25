using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using vOpenUy.Demo.Authorization.Roles;
using vOpenUy.Demo.Authorization.Users;
using vOpenUy.Demo.MultiTenancy;

namespace vOpenUy.Demo.EntityFrameworkCore
{
    public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }
    }
}
