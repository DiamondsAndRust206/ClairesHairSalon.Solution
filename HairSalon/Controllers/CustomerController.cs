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

    
  }
}