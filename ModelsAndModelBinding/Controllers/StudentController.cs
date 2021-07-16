﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsAndModelBinding.Models;

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
            Student stu = new Student();
            // populate each property:
            stu.FullName = form["full_name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]);
            stu.PhoneNumber = form["home_phone"];
            stu.EmailAddress = form["email"];

            return View();
        }
    }
}
