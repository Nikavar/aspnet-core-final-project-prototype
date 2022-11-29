using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_apllication.Models;

namespace todo_apllication.Controllers
{
    public class ToDoController : Controller
    {
        public string Index()
        {
            return "Hello! It's only a first prototype of my ToDo App";
        }
    }
}
