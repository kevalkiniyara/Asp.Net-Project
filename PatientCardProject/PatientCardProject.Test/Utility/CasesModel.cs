using PatientCardProject.Models;
using System;
using System.Collections.Generic;

namespace PatientCardProject.Test.Utility
{
    public static class CasesModel
    {
        public static CaseModel InvalidModel()
        {
            return new CaseModel()
            {
                ID=2,
                PatientId = 0,
                ConsulatedBy = 0,
                HealthCenterId = 0,
                Fee = 500,
                RegisterDate = DateTime.Now
            };
        }
        public static CaseModel GetCaseModel()
        {
            return new CaseModel()
            {
                ID = 1,
                CaseNumber = "C001",
                PatientId = 0,
                ConsulatedBy = 0,
                HealthCenterId = 0,
                Fee = 500,
                RegisterDate=DateTime.Now
            };
        }
        public static List<CaseModel> GetCaseModels()
        {
            return new List<CaseModel>()
            {
                GetCaseModel()
            };
        }
    }
}
