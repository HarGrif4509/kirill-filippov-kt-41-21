using Microsoft.EntityFrameworkCore;

namespace FilippovKirillKt_41_21.Database
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
    }
}
