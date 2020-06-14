using EC2Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EC2Project
{
    public class CasesContext:DbContext
    {
        public CasesContext(DbContextOptions<CasesContext> options):base(options)
        {

        }
        public DbSet<CaseModel> CaseModels { get; set; }
    }
}
