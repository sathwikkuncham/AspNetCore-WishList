using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;

namespace WishList.Controllers
{
    public class DeleteController : Controller
    {
        private readonly ApplicationDbContext context;

        public DeleteController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Delete(int id)
        {
            var item = context.Items.FirstOrDefault(i => i.Id == id);
            context.Items.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
