using System;
using System.Collections.Generic;
using System.Linq;
using PatientCardProject.Models;

namespace PatientCardProject.Operations
{
    public class CrudOperation : ICrudOperation
    {
        private readonly CasesContext _context;

        public CrudOperation(CasesContext context)
        {
            _context = context;
        }
        public void Create(CaseModel model)
        {
            var modelDetail = _context.CaseModels.Add(new CaseModel
            {
                CaseNumber = model.CaseNumber,
                PatientId = model.PatientId,
                HealthCenterId = model.HealthCenterId,
                ConsulatedBy = model.ConsulatedBy,
                Fee = model.Fee,
                RegisterDate = DateTime.Now
            });
            _context.SaveChanges();
        }

        public CaseModel FindById(int id)
        {
            var employeeId = _context.CaseModels.Find(id);
            return employeeId;
        }

        public void DeleteModel(int id)
        {
           
            var caseId = _context.CaseModels.Where(x=>x.ID==id).First();
            _context.CaseModels.Remove(caseId);
            _context.SaveChanges();
        }

        public List<CaseModel> GetModels()
        {
            var modelDetail = (from c in _context.CaseModels
                               select new CaseModel
                               {
                                   ID = c.ID,
                                   CaseNumber = c.CaseNumber,
                                   Fee = c.Fee,
                                   RegisterDate = c.RegisterDate,
                                   PatientId=c.PatientId,
                                   ConsulatedBy =c.ConsulatedBy,
                                   HealthCenterId=c.HealthCenterId
                               }).ToList();
            return modelDetail;
        }

        public CaseModel UpdateModel(int id,CaseModel model)
        {
            var modelDetail = _context.CaseModels.Where(x => x.ID ==id).FirstOrDefault();
            if (model != null)
            {
                modelDetail.CaseNumber = model.CaseNumber;
                modelDetail.PatientId = model.PatientId;
                modelDetail.HealthCenterId = model.HealthCenterId;
                modelDetail.ConsulatedBy = model.ConsulatedBy;
                modelDetail.Fee = model.Fee;
            }
            _context.SaveChanges();
            return modelDetail;
        }
    }
}
