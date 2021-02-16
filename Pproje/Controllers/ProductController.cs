using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PagedList.Core;

using Pproje.Models;

namespace Pproje.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private DataContext _db = new DataContext();

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index(int page = 1, int pageSize = 4)
        {
            PagedList<Product> model = new PagedList<Product>(_db.Product, page, pageSize);

            return View("Index", model);
        }
    }
}
