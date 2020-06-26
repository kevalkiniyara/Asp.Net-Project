using Moq;
using PatientCardProject.Controllers;
using PatientCardProject.Operations;
using PatientCardProject.Test.Utility;
using Xunit;

namespace PatientCardProject.Test.ControllersTest
{

    public class PatientLists
    {
        private readonly Mock<ICrudOperation> _mockICrudOperation;
        private readonly PatientListsController _controller;

        public PatientLists()
        {
            _mockICrudOperation = new Mock<ICrudOperation>();
            _controller = new PatientListsController(_mockICrudOperation.Object);
        }

        [Fact]
        public void Create_ToRegisterCase_ValidResult()
        {
            _controller.Create(CasesModel.GetCaseModel());
            Assert.NotNull(_controller);
        }

        [Fact]
        public void GetModel_PatientCaseList_CaseListValidResult()
        {
            _controller.GetModel();
            Assert.NotNull(_controller);
        }

        [Fact]
        public void Delete_DeletePatientId_ValidResult()
        {
            _controller.Delete(It.IsAny<int>());
            Assert.NotNull(_controller);
        }

        [Fact]
        public void EditModel_UpdateCaseDetail_ValidResult()
        {
            _controller.EditModel(It.IsAny<int>(), CasesModel.GetCaseModel());
            Assert.NotNull(_controller);
        }
    }
}
