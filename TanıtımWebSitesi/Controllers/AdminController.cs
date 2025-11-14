using Microsoft.AspNetCore.Mvc;
using TanıtımWebSitesi.Models;

namespace TanıtımWebSitesi.Controllers
{
    public class AdminController : Controller
    {       
        public IActionResult KategoriListele()
        {
            Context context = new Context();
            var kategoriler=context.Kategoriler.ToList();
            return View(kategoriler);
        }
        public IActionResult KategoriEkleGüncelle(int? Id)
        {
            Context context = new Context();

            if (Id != null && Id > 0)
            {
                var kayit = context.Kategoriler.FirstOrDefault(k => k.Id == Id);
                return View(kayit);
            }
            else
            {
                Akategori kayit =new Akategori();
                return View(kayit);
            }
            
        }
        [HttpPost]
        public IActionResult KategoriEkleGüncelle(Akategori kayit)
        {
            if (ModelState.IsValid)
            {
                Context context=new Context();
                if (kayit.Id > 0)
                {
                    context.Kategoriler.Update(kayit);
                }
                else
                {
                    context.Kategoriler.Add(kayit);
                }
                context.SaveChanges();
                return RedirectToAction("KategoriListele");
            }
            return View(kayit);
        }
        
        public IActionResult kategoriSil(int Id)
        {
            if (Id > 0)
            {
                Context context = new Context();
                var kayit = context.Kategoriler.FirstOrDefault(i => i.Id == Id);
                if (kayit != null)
                {
                    context.Kategoriler.Remove(kayit);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("KategoriListele");
        }
        
    }
}
