using EC2Project.Models;
using EC2Project.Operations;
using Microsoft.AspNetCore.Mvc;

namespace EC2Project.Controllers
{
    public class ManageCasesController : Controller
    {
        private readonly ICrudOperation _operation;

        public ManageCasesController(ICrudOperation operation)
        {
            _operation = operation;
        }
       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CaseModel model)
        {
            if (ModelState.IsValid)
            {
                _operation.Create(model);
                return RedirectToAction("GetModel");
            }
            return View();
        }

        public IActionResult GetModel()
        {
            return View(_operation.GetModels());
        }

        public IActionResult Delete(int id)
        {
            _operation.DeleteModel(id);
            return RedirectToAction("GetModel");
        }
        
        public IActionResult EditModel(int id)
        {
            return View(_operation.FindById(id));
        }

        [HttpPost]
        public IActionResult EditModel(CaseModel model)
        {
            if(ModelState.IsValid)
            {
                _operation.UpdateModel(model);
                return RedirectToAction("GetModel");
            }
            return View();
        }
    }
}