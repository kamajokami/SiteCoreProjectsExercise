using Microsoft.EntityFrameworkCore;
using SiteCoreProjectsExercise.Models;

namespace SiteCoreProjectsExercise.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }
        

    }
}
