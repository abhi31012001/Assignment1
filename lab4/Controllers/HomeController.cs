﻿
using lab4.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*student name- Abhi Patel;
 * 
 * Student No:040978822;
 * 
 partner Name -Meet Patel;

Student no: 040979409

Assignment 1

Lab Instructor - Aamir Rad 

*/

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
      
       
        public IActionResult Index()
        {
            return View();
        }
       

    }
}
