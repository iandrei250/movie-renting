using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renter.Models;
using Renter.Database;
using Microsoft.EntityFrameworkCore;
using Renter.ViewModels;
using AutoMapper;

namespace Renter.Controllers
{
    public class CustomersController : Controller
    {
        private Context _context;

        public CustomersController()
        {
            _context = new Context();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

       public ActionResult New()
        {
            var membershipTypes = _context.MembershipType.ToList();
            var viewModel = new CustomerFormViewModel {  MembershipTypes = membershipTypes };
            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {

            if(customer.Id == 0)
            {
                _context.Customers.Add(customer);

            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.isSubcribedToNewsletter = customer.isSubcribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }


        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return NotFound();
            }

            var viewModel = new CustomerFormViewModel { Customer = customer, MembershipTypes = _context.MembershipType.ToList() };

            return View("CustomerForm", viewModel);
        }
    }
}
