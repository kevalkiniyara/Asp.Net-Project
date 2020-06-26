using PatientCardProject.Models;
using PatientCardProject.Operations;
using Microsoft.AspNetCore.Mvc;

namespace PatientCardProject.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PatientListsController : Controller
    {
        private readonly ICrudOperation _operation;

        public PatientListsController(ICrudOperation operation)
        {
            _operation = operation;
        }

        [HttpPost]
        public IActionResult Create([FromBody]CaseModel model)
        {
            if (ModelState.IsValid)
                _operation.Create(model);
            return Ok();
        }

        public IActionResult GetModel()
        {
            return Ok(_operation.GetModels());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
                _operation.DeleteModel(id);
            return RedirectToAction("GetModel");
        }
        [HttpPut("{id}")]
        public IActionResult EditModel(int id,[FromBody]CaseModel model)
        {
            if (ModelState.IsValid)
            _operation.UpdateModel(id,model);
            return RedirectToAction("GetModel");
        }
    }
}