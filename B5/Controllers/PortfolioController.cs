using Microsoft.AspNetCore.Mvc;
using B5.Models;
using System.Collections.Generic;
using System.Linq;

namespace B5.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 9)
        {
            var allItems = new List<PortfolioItem>();
            for (int i = 1; i <= 30; i++)
            {
                allItems.Add(new PortfolioItem { Id = i, Title = $"Học Web Chuẩn {i}" });
            }

            var pagedItems = allItems.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)System.Math.Ceiling(allItems.Count / (double)pageSize);

            return View(pagedItems);
        }
    }
}
