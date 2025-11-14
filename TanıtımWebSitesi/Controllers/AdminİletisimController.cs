using Microsoft.AspNetCore.Mvc;
using TanıtımWebSitesi.Models;

namespace TanıtımWebSitesi.Controllers
{
    public class AdminİletisimController : Controller
    {
        public IActionResult IletisimListele()
        {
            Context context =new Context();
            var mesajlar =context.İletişimFormu.ToList();
            return View(mesajlar);
        }
        public IActionResult Sil(int id)
        {
            Context context =new Context();
            var silinecek=context.İletişimFormu.FirstOrDefault(x=>x.Id == id);
            if (silinecek != null)
            {
                context.Remove(silinecek);
                context.SaveChanges();
            }
            return RedirectToAction("IletisimListele");
        }
    }
}
