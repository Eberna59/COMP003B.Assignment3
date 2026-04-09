using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace COMP003B.Assignment3.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register(string eventCode)
        {
            EventRegistration registration = new EventRegistration();
            {
                eventCode = eventCode
            };

            return View(registration);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new EventRegistration());
        }

        [HttpPost]
        public IActionResult Register(EventRegistration registration)
        {
            if (ModelState.IsValid)
            {
                return View("Success",  registration);
            }

            return View(registration);

        }

        [HttpGet]
        public IActionResult Success(EventRegistration registration)
        {
            return View(registration);
        }
    }
}
