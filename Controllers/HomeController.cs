using Case_Management_Week2.Data;
using Case_Management_Week2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Case_Management_Week2.Controllers
{
    public class HomeController : Controller
    {
   

        [HttpGet]
        public IActionResult Index()
        {
            return View(CaseData.originalCases);
        }
     
        
          [HttpGet]
          public IActionResult dismissCase([FromRoute] int? id)
        {
            if (id.HasValue)
            {
                for (int i = 0; i < CaseData.originalCases.Count; i++)
                {
                    if (CaseData.originalCases[i].getId() == id.Value)
                    {
                        CaseData.originalCases.RemoveAt(i);
                        break;
                    }
                }
            }

            return RedirectToAction("Index");
        
          }

        //return new ContentResult { Content = id.ToString() };
    }
}
