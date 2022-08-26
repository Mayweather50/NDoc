using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using testNdoc.Models;

namespace testNdoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        public HomeController(IWebHostEnvironment environment)
        {
            hostingEnvironment = environment;
        }
        [HttpPost]
        public IActionResult Index(IFormFile vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.FileName != null)
                {
                    var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, GetUniqueFileName(vm.FileName));
                    vm.FileName.CopyTo(new FileStream(filePath, FileMode.Create));
                    return Json(new { status = "success", message = "Successfully saved" });
                }
            }
            else
            {
                // handle what to do when model validation fails
            }
            return Json(new { status = "error", message = "something wrong!" });
        }

        private string GetUniqueFileName(IFormFile fileName)
        {
            throw new NotImplementedException();
        }

      

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
