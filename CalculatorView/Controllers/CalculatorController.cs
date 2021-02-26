using CalculatorView.Models;
using CalculatorView.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorView.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult calculate()
        {

            CalculatorModel calcmodel = new CalculatorModel();

            calcmodel.num1 = Convert.ToInt32(Request.Form["num1"].ToString());


            calcmodel.num2 = Convert.ToInt32(Request.Form["num1"].ToString());

            CalculatorBusinessService cb = new CalculatorBusinessService();

            double add = cb.addnumber(calcmodel);



            StringBuilder stbuilder = new StringBuilder();
     

            stbuilder.Append("<b> calculate </b>" + add + "<br/>");


            ViewBag.answer = stbuilder;



            return View("Index");
        }

      
    }
}
