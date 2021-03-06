using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pierres.Models;

namespace Pierres.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierresContext _db;

    public FlavorsController(PierresContext db)
    {
        _db = db;
    }

    public ActionResult Index(string searchString)
    {
      return View(_db.Flavors.ToList());
    }

    public ActionResult Create()
    {
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int TreatId)
    {
        _db.Flavors.Add(flavor);
        if (TreatId != 0)
        {
            _db.TreatFlavor.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisFlavor = _db.Flavors
            .Include(flavor => flavor.Treats)
            .ThenInclude(join => join.Treat)
            .FirstOrDefault(flavor => flavor.FlavorId == id);
        return View(thisFlavor);
    }

    public ActionResult Delete(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        _db.Flavors.Remove(thisFlavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
        return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor, int TreatId)
    {
      if (TreatId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = flavor.FlavorId });
      }
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
        return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int TreatId)
    {
        if (TreatId != 0)
        {
        _db.TreatFlavor.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTreat(int joinId)
    {
        var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
        _db.TreatFlavor.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}