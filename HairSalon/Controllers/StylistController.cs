using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    private readonly HairSalonContext _db; // our database declared as an object, so it connect

    public StylistController(HairSalonContext db) // 
    {
      _db = db; // database object
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      ViewBag.PageTitle = "Stylists";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add Stylist";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ViewBag.PageTitle = "Stylist Details";
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }
    
  }
}