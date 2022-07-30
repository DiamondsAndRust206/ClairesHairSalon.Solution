using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class CustomerController : Controller
  {
    private readonly HairSalonContext _db; 

    public CustomerController(HairSalonContext db)
    {
      _db = db; 
    } 

    public ActionResult Create(int id)
    {
      ViewBag.PageTitle = "Add Appt.";
      ViewBag.StylistId = id;
      return View();
    }
    [HttpPost]
    public ActionResult Create(Customer customer)
    {
      _db.Customers.Add(customer);
      _db.SaveChanges();
      // redirect to stylists details after customer is created
      return RedirectToAction("Details", "Stylist", new { id = customer.StylistId});
    }

    public ActionResult Details(int id)
    {
      ViewBag.PageTitle = "Customer Details";
      Customer thisCust = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
      return View(thisCust);
    }

  }
}