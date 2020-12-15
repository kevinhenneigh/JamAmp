using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamAmp.Controllers
{
    public class AmpController : Controller
    {
        public IActionResult AmpIndex()
        {
            return View();
        }
    }
}
