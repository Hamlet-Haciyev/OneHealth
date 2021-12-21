using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneHealth.Data;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Areas.admin.Controllers
{
    [Area("admin")]
    public class DoctorController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DoctorController(AppDbContext appDbContext,IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Doctor> doctors = _appDbContext.Doctors.Include(d=>d.HealthCategory).ToList(); 
            return View(doctors);
        }
        public IActionResult Create()
        {
            ViewBag.HealthCategory = _appDbContext.HealthCategories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                if (doctor.ImageFile != null)
                {
                    if (doctor.ImageFile.ContentType=="image/png"|| doctor.ImageFile.ContentType == "image/jpeg")
                    {
                        if (doctor.ImageFile.Length <= 2097152)
                        {

                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + doctor.ImageFile.FileName;
                            string pathFile = Path.Combine(_webHostEnvironment.WebRootPath,"Uploads", fileName);

                            using (var stream = new FileStream(pathFile,FileMode.Create))
                            {
                                doctor.ImageFile.CopyTo(stream);
                            }
                            doctor.CreatedDate = DateTime.Now;
                            doctor.Image = fileName;

                            _appDbContext.Doctors.Add(doctor);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            return View(doctor);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        return View(doctor);
                    }

                }
                else
                {
                    doctor.CreatedDate = DateTime.Now;
                    _appDbContext.Doctors.Add(doctor);
                    
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(doctor);
        }
        public IActionResult Update(int? id)
        {
            Doctor doctor = _appDbContext.Doctors.Include(d => d.HealthCategory).FirstOrDefault(i=>i.Id==id);
            ViewBag.HealthCategory = _appDbContext.HealthCategories.ToList();
            return View(doctor);
        }
        [HttpPost]
        public IActionResult Update(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                    if (doctor.ImageFile != null)
                    {
                        if (doctor.ImageFile.ContentType == "image/png" || doctor.ImageFile.ContentType == "image/jpeg")
                        {
                            if (doctor.ImageFile.Length <= 2097152)
                            {
                                string oldPathImage = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", doctor.Image);

                                if (!string.IsNullOrEmpty(oldPathImage))
                                {
                                    if (System.IO.File.Exists(oldPathImage))
                                    {
                                        System.IO.File.Delete(oldPathImage);
                                    }
                                }
                                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + doctor.ImageFile.FileName;
                                string pathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                                using (var stream = new FileStream(pathFile, FileMode.Create))
                                {
                                    doctor.ImageFile.CopyTo(stream);
                                }
                                doctor.Image = fileName;

                                _appDbContext.Doctors.Update(doctor);
                                _appDbContext.SaveChanges();
                                return RedirectToAction("Index");
                            }
                        }
                    }       
                else
                {
                    _appDbContext.Doctors.Update(doctor);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                
            }


            return View(doctor);
        }
        public IActionResult Delete(int? id)
        {
            Doctor doctor = _appDbContext.Doctors.Find(id);

            if (id!=null)
            {
                string oldPathImage = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", doctor.Image);
                if (!string.IsNullOrEmpty(doctor.Image))
                {

                    if (System.IO.File.Exists(oldPathImage))
                    {
                        System.IO.File.Delete(oldPathImage);
                    }
                }
            }

            if (doctor!=null)
            {
                _appDbContext.Doctors.Remove(doctor);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor);
        }
        #region HealthCategoryCRUD
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(HealthCategory healthCategory)
        {
            if (ModelState.IsValid)
            {
                if (healthCategory!=null)
                {
                    _appDbContext.HealthCategories.Add(healthCategory);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

            }

            return View(healthCategory);
        }
        
        #endregion

    }
}
