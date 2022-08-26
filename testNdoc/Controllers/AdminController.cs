//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace testNdoc.Controllers
//{
//    public class AdminController : Controller
//    {

//        NDocContext db;
//      private readonly IWebHostEnvironment _web;

//        // GET: AdminController
       

//        public AdminController(IWebHostEnvironment web)
//        {

//            db = new NDocContext();
           

//            //doc = new List<Document>
//            //{
//            //    new Document{Id=1,Name="фдлвдф"}
//            //};


//        }
        


//        //public ActionResult Index()
//        //{
//        //    //return View(db.Sections?.OrderBy(x => x.Name));

//        //}



//        //[HttpPost]
//        //public async Task<IActionResult> AddFile(IFormFile[] filesupload)
//        //{
//        //    if (filesupload == null || filesupload.Length == 0)
//        //    {
//        //        ViewData["Message"] = "Выберите как минимум один файл";

//        //    }
//        //    else
//        //    {
//        //        foreach (IFormFile img in filesupload)
//        //        {
//        //            var saveimg = Path.Combine(_web.WebRootPath, "Files",
//        //                img.FileName);
//        //            var fileselected = new FileStream(saveimg, FileMode.Create);
//        //            await img.CopyToAsync(fileselected);
//        //            ViewData["Message"] = "Выбранные файлы сохранены" + filesupload.Length + "Сохранено";
//        //        }
//        //    }

//        //    return View();
//        //}


//        [HttpGet]
//        public ActionResult CreateDocuments(int sectionId)
//        {
//            Document model = new Document() { SectionId = sectionId };
//            return PartialView();
//        }

//        [HttpGet]
//        public ActionResult CreateDocument()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult CreateDocument(Document document)
//        {
           
//                db.Documents.Add(document);
//                db.SaveChanges();
//                return RedirectToAction("Create");
            
        
//        }

//        [HttpGet]
//        public ActionResult TableDocument()
//        {
//            var model = db.Documents.OrderBy(x => x.Name);
//            return PartialView("TableDocument", model);

//        }

//        // GET: AdminController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: AdminController/Create
//        [HttpGet]

//        public ActionResult Create()
//        {
//            return View();
//        }
//        [HttpPost]
//        public ActionResult Create(Section section)
//        {
//            db.Sections.Add(section);
//            db.SaveChanges();

//            return RedirectToAction("Create");
//        }

//        [HttpGet]
//        public ActionResult TableSection()
//        {
//            var model = db.Sections.OrderBy(x => x.Name);
//            return PartialView("_TableSection", model);

//        }

//        // GET: AdminController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: AdminController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: AdminController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: AdminController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
