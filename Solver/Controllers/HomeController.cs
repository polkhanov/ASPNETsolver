using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solver.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Solve()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult getData(Models.UserData data)
        {

            Models.Bionical temp = new Models.Bionical(data.Nums, data.Individ, data.Gen);
            string output = "";
            switch (data.Method)
            {
                case "Бионический": 
                        List<Models.GenPoint> answer = new List<Models.GenPoint>();
                        answer = temp.getX();
                        double[] ans = new double[3] { (double)answer.First().x1, (double)answer.First().x2, (double)answer.First().y };
                    output += "Значение функции: " + ans[2] + ". X1: " + ans[0] + ". X2: " + ans[1]; break;
                case "Симплекс":
                    
                        double[] result = new double[2];
                        double[,] table_result;
                        Models.Simplex S = new Models.Simplex(data.Nums);
                        table_result = S.Calculate(result);
                    output += "Значение функции: " + table_result[4,0] + ". X1: " + result[0] + ". X2: " + result[1]; break;
            }

         
            return Json(output);
        }

    }
}