using System;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestDbContext())
            {
                var role = new Role
                {
                    RoleName = "管理员"
                };

                context.Roles.Add(role);

                context.SaveChanges();
            }
        }
    }
}
