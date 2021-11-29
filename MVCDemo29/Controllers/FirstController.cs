using MVCDemo29.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo29.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string txtNo1, string txtNo2)
        {
            int no1 = int.Parse(txtNo1);
            int no2 = int.Parse(txtNo2);
            int res = no1 + no2;
            ViewBag.res = res;
            return View();
        }

        public ActionResult Add1()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Add1(string txtNo1, string txtNo2)
        {
            int no1 = int.Parse(txtNo1);
            int no2 = int.Parse(txtNo2);
            int res = no1 + no2;
            ViewBag.res = res;
            return View();

        }
        public ActionResult Add2()
        {
            return View();
        }
        [HttpPost]
        public ContentResult Add2Post()
        {
            int no1 = int.Parse(Request["txtNo1"]);
            int no2 = int.Parse(Request["txtNo2"]);
            int res = no1 + no2;
            return Content(res.ToString());
        }

        public ActionResult Add3()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Add3(FormCollection formCollection)
        {
            int no1 = int.Parse(formCollection["txtNo1"]);
            int no2 = int.Parse(formCollection["txtNo2"]);
            int res = no1 + no2;
            return Content(res.ToString());
            
        }

        public ActionResult Add4()
        {
            Numbers numbers = new Numbers();

            return View(numbers);
        }

        [HttpPost]
        public ActionResult Add4(Numbers numbers)
        {
            int no1 = numbers.No1;
            int no2 = numbers.No2;
            int res = no1 + no2;
            return Content(res.ToString());

             
        }
    }
}