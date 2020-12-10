using RemPeople.DomainObjectInterfaces;
using RemPeople.DomainObjects;
using RemPeople.DomainObjectsController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemPeople.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            IPersonnel personnel = new SecondTypePersonnel
            {
                DailySalary = 12,
                DaysWorked = 32,
                IDNumber = 23,
                Name = "kadir",
                Surname = "23"
            };
            PersonnelController personnelController = new PersonnelController(personnel);
            var test = personnelController.CalculateSalary();


            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
