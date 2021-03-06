﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityofLouisvilleVaccine.DataContexts;
using UniversityofLouisvilleVaccine.Models;

namespace UniversityofLouisvilleVaccine.App_Start.Controllers
{
    public class VaccineUseController : Controller
    {
        private VaccineUseDBContext db = new VaccineUseDBContext();

        // GET: /VaccineUse/
        public ActionResult Index()
        {
            return View(db.VaccineUses.ToList());
        }

        // GET: /VaccineUse/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VaccineUse vaccineuse = db.VaccineUses.Find(id);
            if (vaccineuse == null)
            {
                return HttpNotFound();
            }
            return View(vaccineuse);
        }

        // GET: /VaccineUse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /VaccineUse/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VaccineUseId,vaccineID,lotNumber,patientID,LinjectionSite,RinjectionSite,quantity,VaccineUseDate")] VaccineUse vaccineuse)
        {

            if (ModelState.IsValid)
            {
                db.VaccineUses.Add(vaccineuse);
                db.SaveChanges();

                    //Decrease amount from quantity
                    VaccineDBContext VaccineDB = new VaccineDBContext();
                    Vaccine Vac = new Vaccine();

                    string vaccineID = vaccineuse.vaccineID;
                    string lot = vaccineuse.lotNumber;
                    int decreaseby = vaccineuse.quantity;
                    
                    var query =
                        from VDB in VaccineDB.Vaccines
                        where VDB.lotNumber == lot && VDB.vaccineID == vaccineID
                        select VDB;

                    foreach (Vaccine vdb in query)
                    {
                        int currentvaccinequantity = vdb.numofDoses;
                        int newvaccinetotal = currentvaccinequantity - decreaseby;                    
                        vdb.numofDoses = newvaccinetotal;
                    }

                    try
                    {
                        VaccineDB.SaveChanges();
                        Console.WriteLine("Vaccine Amount Updated!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
 
                return RedirectToAction("Index");
            }

            return View(vaccineuse);

        }

        // GET: /VaccineUse/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VaccineUse vaccineuse = db.VaccineUses.Find(id);
            if (vaccineuse == null)
            {
                return HttpNotFound();
            }
            return View(vaccineuse);
        }

        // POST: /VaccineUse/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VaccineUseId,vaccineID,lotNumber,patientID,LinjectionSite,RinjectionSite,quantity,VaccineUseDate")] VaccineUse vaccineuse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vaccineuse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vaccineuse);
        }

        

        // GET: /VaccineUse/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VaccineUse vaccineuse = db.VaccineUses.Find(id);
            if (vaccineuse == null)
            {
                return HttpNotFound();
            }
            return View(vaccineuse);
        }

        // POST: /VaccineUse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            VaccineUse vaccineuse = db.VaccineUses.Find(id);
            db.VaccineUses.Remove(vaccineuse);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
