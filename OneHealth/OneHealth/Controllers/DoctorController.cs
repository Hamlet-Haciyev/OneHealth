using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneHealth.Data;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DoctorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
          List<Doctor> doctors=  _appDbContext.Doctors.Include(d => d.HealthCategory).ToList();
            return View(doctors);
        }
    }
}
