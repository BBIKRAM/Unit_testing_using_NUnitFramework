using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTesting.ModelAccess;
using UnitTesting.Models;

namespace UnitTesting.Controllers
{
    public class DepartmentController : Controller
    {

        DepartmentAccess _services;

        public DepartmentController()
        {
            _services = new DepartmentAccess();
        }

        // GET: Department
        public ActionResult Index()
        {
            var Depts = _services.GetDepartments();
            return View("Index", Depts);
        }



        // GET: Department/Create
        public ActionResult Create()
        {
            var Dept = new Department();
            return View("Create",Dept);
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(Department dept)
        {
            try
            {
                _services.CreateDepartment(dept);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(dept);
            }
        }
        //[HttpPost]
        public ActionResult Delete(int id)
        {
                _services.DeleteDepartment(id);
                return RedirectToAction("Index");
        }
        
        public ActionResult Edit(int id)
        {
            var data = _services.get_Department_Details(id);
            return View("Create",data);
            
        }

        [HttpPost]
        public ActionResult  Edit(Department dept)
        {
            _services.UpdateDepartment(dept);
            return RedirectToAction("Index");
        }

    }
}