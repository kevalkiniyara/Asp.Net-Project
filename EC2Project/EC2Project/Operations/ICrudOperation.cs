using EC2Project.Models;
using System.Collections.Generic;

namespace EC2Project.Operations
{
    public interface ICrudOperation
    {
        void Create(CaseModel model);

        List<CaseModel> GetModels();

        CaseModel UpdateModel(CaseModel model);

        void DeleteModel(int id);

        CaseModel FindById(int id);

    }
}
