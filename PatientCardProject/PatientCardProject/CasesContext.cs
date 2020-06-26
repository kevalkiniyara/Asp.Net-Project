using PatientCardProject.Models;
using Microsoft.EntityFrameworkCore;

namespace PatientCardProject
{
    public class CasesContext:DbContext
    {
        public CasesContext(DbContextOptions<CasesContext> options):base(options)
        {

        }
        public DbSet<CaseModel> CaseModels { get; set; }
    }
}
