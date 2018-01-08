using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EatmMVC.Models;

namespace EatmMVC.Controllers
{
    public class EamController : Controller
    {
        //
        // GET: /Eam/

        private ApplicationDbContext context;

        public EamController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult logineatm()
        {
            return View();
        }

        public ActionResult cheking(int accountno, int pinNo)
        {
            var account = context.Accounts.FirstOrDefault(x => x.Id == accountno && x.PinNumber == pinNo);
            if (account !=null)
            {
                return View(account);
            }
            else
            {
                return RedirectToAction("logineatm");
            }
        }
        public ActionResult withdraw(int value, int id)
        {
            var account = context.Accounts.FirstOrDefault(x => x.Id == id);

            account.Balance -= value;
            context.SaveChanges();
            return RedirectToAction("logineatm");
        }
	}
}