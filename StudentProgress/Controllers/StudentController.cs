using StudentProgress.Models;
using StudentProgress.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProgress.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            Student st = new Student()
            {
                StudentId = 9001,
                StudentName = "Karun",
                Standard = "10th",
                NameOfTheExam="Final",
                s1=80,
                s2=90,
                s3=98,
                s4=89,
                s5=69,
                s6=9
            };
            StudentVM svm = new StudentVM(st);
            return View(svm);

        }
    }
}