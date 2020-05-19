using prjModelValidate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjModelValidate.Controllers
{
    public class HomeController : Controller
    {
        dbStudentEntities db = new dbStudentEntities();
        
        public ActionResult Index()
        {
            var students = db.tStudent.ToList();
            return View(students);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tStudent stu)
        {
            if (ModelState.IsValid)
            {
                db.tStudent.Add(stu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stu);
        }

        public ActionResult Delete(string id)
        {
            var stu = db.tStudent.Where(m => m.fStuId == id).FirstOrDefault();
            db.tStudent.Remove(stu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}