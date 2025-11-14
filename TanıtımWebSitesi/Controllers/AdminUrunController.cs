using Microsoft.AspNetCore.Mvc;
using TanıtımWebSitesi.Models;

namespace TanıtımWebSitesi.Controllers
{
    public class AdminUrunController : Controller
    {
        public IActionResult UrunListele()
        {
            Context context = new Context();
            var urunler = context.Ürünler.ToList();
            return View(urunler);
        }
        public IActionResult Sil(int id)
        {
            Context context = new Context();
            var silinecek = context.İletişimFormu.FirstOrDefault(x => x.Id == id);
            if (silinecek != null)
            {
                context.Remove(silinecek);
                context.SaveChanges();
            }
            return RedirectToAction("UrunListele");
        }
    }
}
