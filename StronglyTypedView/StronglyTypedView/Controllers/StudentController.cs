using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedView.Models;

namespace StronglyTypedView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
			Student student = new Student
			{
				ID = 1,
				FirstName = "Sandeep",
				LastName = "Nalla",
				City = "Coppell"
			};
			return View(student);
        }
    }
}