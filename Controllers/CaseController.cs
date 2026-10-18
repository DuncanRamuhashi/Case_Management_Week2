using Case_Management_Week2.Data;
using Case_Management_Week2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Case_Management_Week2.Controllers
{
    public class CaseController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromRoute] int? id)
        {
            if (id != null)
            {

                foreach (var c in CaseData.originalCases)
                {
                    if (c.getId() == id)
                    {
                        CaseData.courtCase = new CourtCase(c.getId());

                        CaseData.courtCase.assignOriginalCase(c);

                        break;
                    }
                }
            }
            //i If no case number is provided or no matching case is found, return a default view    
            return View(CaseData.courtCase);
        }

        [HttpPost]
        public IActionResult addCharge([FromForm] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Content("The charge name was not received.");
            }
            else {
                if (CaseData.courtCase == null)
                {
                    return Content("Index");
                }
                else {
                    if (CaseData.courtCase.getCharges() == null)
                    {
                        CaseData.courtCase.addCharge(new Charge(1, name));
                    }
                    else
                    {
                        CaseData.courtCase.addCharge(new Charge(CaseData.courtCase.getCharges().Count + 1, name));
                    }
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult addDefendant([FromForm] string idNumber, [FromForm] string name)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(idNumber))
            {
                return Content("The defendant name or ID number was not received.");
            }
            else
            {
                if (CaseData.courtCase == null)
                {
                    return Content("Index");
                }
                else
                {


                    CaseData.courtCase.addDefendant(idNumber, new Defendant(idNumber, name));

                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult assignCourt([FromForm] string courtName, [FromForm] string location)
        {
            if (string.IsNullOrWhiteSpace(courtName) || string.IsNullOrWhiteSpace(location))
            {
                return Content("The court name or location was not received.");
            }
            else
            {
                if (CaseData.courtCase == null)
                {
                    return Content("Index");
                }
                else
                {
                    CaseData.courtCase.assignCourt(1, courtName, location);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult assignJudge([FromForm] string judgeName)
        {
            if (string.IsNullOrWhiteSpace(judgeName))
            {
                return Content("The judge name was not received.");
            }
            else
            {
                if (CaseData.courtCase == null)
                {
                    return Content("Index");
                }
                else
                {
                    CaseData.courtCase.assignJudge("9232323233232", judgeName);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult assignProsecutor([FromForm] string prosecutorName)
        {
            if (string.IsNullOrWhiteSpace(prosecutorName))
            {
                return Content("The prosecutor name was not received.");
            }
            else
            {
                if (CaseData.courtCase == null)
                {
                    return Content("Index");
                }
                else
                {
                    CaseData.courtCase.assignProsecutor("123456789", prosecutorName);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult updateStatus()
        {
          CaseData.courtCase.updateStatus("Closed");
            return RedirectToAction("Index");
        }
    }
}
