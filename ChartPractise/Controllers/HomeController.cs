using ChartPractise.Data;
using ChartPractise.Models;
using Newtonsoft.Json; // Add this using directive
using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Util;

namespace ChartPractise.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                using (AddressEntities school = new AddressEntities())
                {


                    var myModel = new MyModel();

                    var result = school.MyDemoTables
                     .GroupBy(t => t.TransactionDate)
                     .Select(g => new
                     {
                         TransactionDate = g.Key,
                         Amount = g.Sum(t => t.Amount)
                     });

                    myModel.MyTransactions = result.Select(x => new MyModel
                    {
                        TransactionDate = x.TransactionDate,
                        Amount = x.Amount
                    }).ToList();

                    return View(myModel);
                }
            }
            catch (Exception ex)
            {
                
                return View("Error", new HandleErrorInfo(ex, "ControllerName", "Index"));
            }
        }
    }
     
    }

