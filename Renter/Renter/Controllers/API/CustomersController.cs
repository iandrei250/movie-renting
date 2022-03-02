using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Renter.Database;
using Renter.Dtos;
using Renter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Renter.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private Context _context;
        private readonly IMapper _mapper;

        public CustomersController(IMapper mapper)
        {
            _context = new Context();
            _mapper = mapper;
        }

        //GET /api/customers
        [HttpGet]
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(_mapper.Map<Customer, CustomerDto>);
        }

        //GET /api/customers/{id}
        [HttpGet("{id}")]
        public ActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer == null) return NotFound();

            return Ok(_mapper.Map<Customer, CustomerDto>(customer));
        }

        //POST /api/customers/{id}
        [HttpPost]
        public ActionResult CreateCustomer(CustomerDto customer)
        {
            if (!ModelState.IsValid) return BadRequest();

            var customerDto = _mapper.Map<CustomerDto, Customer>(customer);
            _context.Customers.Add(customerDto);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.Host + Request.Path +  customer.Id), customerDto);

        }

        //PUT /api/customers/{id}
        [HttpPut("{id}")]
        public void UpdateCustomer(int id, CustomerDto customer)
        {
            if (!ModelState.IsValid) throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customerInDb == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            _mapper.Map(customer, customerInDb);

            _context.SaveChanges();
        }

        //DELETE /api/customers/{id}
        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();
        }


    }


}
