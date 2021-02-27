using Assesment_247.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_247.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Menu(FormModel fmodel)
        {


            StringBuilder forminfo = new StringBuilder();

            forminfo.Append("Name " + "  " +  fmodel.Name  + "<br>");

            forminfo.Append("Calories  " +  " " + fmodel.Calories  + "<br>");

            forminfo.Append("Ingredient1    " +  " " +  fmodel.Ingredient1  + "<br>");
             
            forminfo.Append("Ingredient2  " +  " " +  fmodel.Ingredient2  + "<br>");



            if (fmodel.Ingredient1 == "blue")
            {
                var result = new string(fmodel.Ingredient1.ToCharArray().Reverse().ToArray());
                ViewBag.reverse = result;
            }



            ViewBag.data = forminfo;


            return View(fmodel);
        










        }
    }
}
