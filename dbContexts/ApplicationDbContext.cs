using DSR_KAZAR_N1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DSR_KAZAR_N1.dbContexts
{
    public class ApplicationDbContext : IdentityDbContext <UporabnikZGesli, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
    }
}