using aygunmedia.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aygunmedia.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.profil = x.profil;
            ag.isim = x.isim;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ikonListesi()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            c.ikonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        public ActionResult ikonGetir(int id)
        {
            var ig = c.ikonlars.Find(id);
            return View("ikonGetir", ig);
        }
        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.ikonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        public ActionResult ikonSil(int id)
        {
            var sl = c.ikonlars.Find(id);
            c.ikonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        // skills işlemleri ------------------------------
        public ActionResult SkillListesi()
        {
            var deger = c.Skills.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSkill(Skill p)
        {
            c.Skills.Add(p);
            c.SaveChanges();
            return RedirectToAction("SkillListesi");
        }
        public ActionResult SkillGetir(int Id)
        {
            var ig = c.Skills.Find(Id);
            return View("SkillGetir", ig);
        }
        public ActionResult SkillGuncelle(Skill x)
        {
            var ig = c.Skills.Find(x.Id);
            ig.yetenekAd = x.yetenekAd;
            ig.yuzde = x.yuzde;
            c.SaveChanges();
            return RedirectToAction("SkillListesi");
        }
        public ActionResult SkillSil(int Id)
        {
            var sl = c.Skills.Find(Id);
            c.Skills.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("SkillListesi");
        }
    }
}