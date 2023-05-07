using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Data;
using Vena.Models;
using Vena.Services;
using Vena.ViewModels;

namespace Vena.Controllers
{
    public class CustomerController : Controller
    {
        private readonly VenaDbContext _context;
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service, VenaDbContext context)
        {
            _service = service;
            _context = context;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(_service.List());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerFormViewModel viewModel)
        {
            try
            {
                //Customer customer = new Customer
                //{
                //    FirstName = viewModel.FirstName,
                //    LastName = viewModel.LastName,
                //    Email = viewModel.Email,
                //    Phone = viewModel.Phone,
                //    Birthdate = viewModel.Birthdate,
                //    MembershipType = _context.MembershipTypes.Find(viewModel.MembershipTypeId)
                //};
                //_context.Customers.Add(customer);
                //_context.SaveChanges();
                //return RedirectToAction(nameof(Index));

                if (ModelState.IsValid)
                {
                    _service.Add(viewModel);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CustomerFormViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Delete(viewModel);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
