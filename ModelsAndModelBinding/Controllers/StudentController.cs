using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet] // When user navigates to the URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // Call this Add() method after user submits (posts) form data
        public IActionResult Add(IFormCollection form)
        {
            return View();
        }
    }
}
