using Microsoft.EntityFrameworkCore;
using PatientCardProject.Test.Utility;
using Xunit;

namespace PatientCardProject.Test
{
    public class CaseContextTest
    {
        [Fact]
        public void CaseContext_Test()
        {
            var option = new DbContextOptionsBuilder<CasesContext>().UseInMemoryDatabase("Database").Options;
            var context = new CasesContext(option);
            context.CaseModels.Add(CasesModel.GetCaseModel());
            Assert.NotNull(context);
        }
    }
}
