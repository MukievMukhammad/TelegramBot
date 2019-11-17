using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrChloe_.Models;

namespace PrChloe_.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "It is my Telegram Bot";
        }
    }
}