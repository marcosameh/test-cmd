using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deploy_External_Template.Model;
using Deploy_External_Template.DAL.DataBase;
using Deploy_External_Template.BL.Repository;
using System.Diagnostics;
using Deploy_External_Template.BL.Interface;

namespace Deploy_External_Template.Controllers
{
    public class DepartmentController : Controller
    {
        // Tightly Coupled
        //private DepartmentRep obj ;




        private IDepartmentRep obj;

        //public DepartmentController(DepartmentRep x)
        //{
        //    this.obj = x;

        //}

        //Loosly coupled
        public DepartmentController(IDepartmentRep x)
        {
            this.obj = x;
        }


        public IActionResult Index()
        {

            var data = obj.Get();
           
            return View(data);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(DepartmentVM dep)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    obj.Add(dep);
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                EventLog log = new EventLog();
                log.Source = "Admin Dashboard";
                log.WriteEntry(ex.Message, EventLogEntryType.Error);

                return View(dep);
            }

        }
        public IActionResult Edit(int id)
        {
            var data=obj.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentVM dep)
        {
            obj.Edit(dep);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            var data = obj.GetById(id);
            return View(data);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            obj.Delete(id);
            return RedirectToAction("index");
        }
        

    }
}
