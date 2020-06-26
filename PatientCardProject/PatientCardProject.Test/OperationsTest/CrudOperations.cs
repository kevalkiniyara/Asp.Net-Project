using Microsoft.EntityFrameworkCore;
using Moq;
using PatientCardProject.Operations;
using PatientCardProject.Test.Utility;
using Xunit;

namespace PatientCardProject.Test.OperationsTest
{
    public class CrudOperations
    {
        private readonly Mock<CasesContext> _mockCasesContext;
        private readonly Mock<CrudOperation> _operation;

        public CrudOperations()
        {
            _mockCasesContext = new Mock<CasesContext>();
            _operation = new Mock<CrudOperation>();
        }

        [Fact]
        public void Create_StoreInDatabase_ValidResult()
        {
            var option = new DbContextOptionsBuilder<CasesContext>().UseInMemoryDatabase("Database").Options;
            var context = new CasesContext(option);

            var database = new CrudOperation(context);
            database.Create(CasesModel.GetCaseModel());

            Assert.NotNull(database);
            _mockCasesContext.VerifyAll();
        }

        [Fact]
        public void FindByID_GetId_ValidResult()
        {
            var option = new DbContextOptionsBuilder<CasesContext>().UseInMemoryDatabase("Database").Options;
            var context = new CasesContext(option);

            var database = new CrudOperation(context);
            database.FindById(1016);

            Assert.NotNull(database);
            _mockCasesContext.VerifyAll();
        }

        [Fact]
        public void Delete_DeleteFromDatabase_ValidResult()
        {
            var option = new DbContextOptionsBuilder<CasesContext>().UseInMemoryDatabase("Database").Options;
            var context = new CasesContext(option);

            var database = new CrudOperation(context);
            database.DeleteModel(1);

            Assert.NotNull(database);
            _mockCasesContext.VerifyAll();
        }

        [Fact]
        public void GetModel_GetFromDatabase_ValidResult()
        {
            var option = new DbContextOptionsBuilder<CasesContext>().UseInMemoryDatabase("Database").Options;
            var context = new CasesContext(option);

            var database = new CrudOperation(context);
            database.GetModels();

            Assert.NotNull(database);
            _mockCasesContext.VerifyAll();
        }

        [Fact]
        public void UpdateModel_UpdateDatabase_ValidResult()
        {
            var option = new DbContextOptionsBuilder<CasesContext>().UseInMemoryDatabase("Database").Options;
            var context = new CasesContext(option);

            var database = new CrudOperation(context);
            database.UpdateModel(2,CasesModel.GetCaseModel());

            Assert.NotNull(database);
            _mockCasesContext.VerifyAll();
        }
    }
}
