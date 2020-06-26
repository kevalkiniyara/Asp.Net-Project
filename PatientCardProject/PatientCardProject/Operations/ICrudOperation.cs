using PatientCardProject.Models;
using System.Collections.Generic;

namespace PatientCardProject.Operations
{
    public interface ICrudOperation
    {
        void Create(CaseModel model);

        List<CaseModel> GetModels();

        CaseModel UpdateModel(int id,CaseModel model);

        void DeleteModel(int id);

        CaseModel FindById(int id);

    }
}
