using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MegaMartchain.Models;

namespace MegaMartchain.Controllers
{
    
    public class HomeController : Controller
    {
        static List<Customers> customers;

        public ActionResult Index()
        {

             customers = new List<Customers>
            {
                new Customers {FirstName = "Erick", LastName = "Barbosa", Email = "email@email.com", Id = 0,PhoneNumber = "305",Address = "123 Main st"},
                new Customers {FirstName = "Brian", LastName = "smith", Email = "Brian@email.com", Id = 1,PhoneNumber = "786",Address = "321 Main st"},
                new Customers {FirstName = "John", LastName = "Doe", Email = "John@email.com", Id = 2,PhoneNumber = "55",Address = "676 Main st"}
            };
            
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customers Cust = new Customers();
            foreach (Customers c in customers)
            {
                if (c.Id == id)
                {
                    Cust.FirstName = c.FirstName;
                    Cust.LastName = c.LastName;
                    Cust.Address = c.Address;
                    Cust.Id = c.Id;
                    Cust.PhoneNumber = c.PhoneNumber;
                    Cust.Email = c.Email;
                }
            }


            return View(Cust);
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
    }
}