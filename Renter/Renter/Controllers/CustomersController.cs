﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renter.Models;
namespace Renter.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {

            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> {
                new Customer { Id = 1, Name = "Customer1"},
                new Customer { Id = 2, Name = "Customer2"}
            };
        }
    }
}