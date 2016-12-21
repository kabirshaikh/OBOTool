using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OBOTool.Models;

namespace OBOTool.Controllers
{
    public class WellDetailsController : Controller
    {
        private OBOModel db = new OBOModel();

        // GET: WellDetails
        public ActionResult Index(string searchString)
        {
            var wellDetails = db.WellDetails.Include(w => w.BusinessUnit).Include(w => w.Election);

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                wellDetails = wellDetails.Where(s => s.Name.Contains(searchString));
            }

            return View(wellDetails.ToList());
        }

        // GET: WellDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WellDetail wellDetail = db.WellDetails.Find(id);
            if (wellDetail == null)
            {
                return HttpNotFound();
            }
            return View(wellDetail);
        }

        // GET: WellDetails/Create
        public ActionResult Create()
        {
            ViewBag.BusinessUnitId = new SelectList(db.BusinessUnits, "Id", "Name");
            ViewBag.ElectionId = new SelectList(db.Elections, "Id", "Name");
            return View();
        }

        // POST: WellDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Commenter,CommentDate,Name,ApiNumber,Duwi,BusinessUnitId,FieldName,PartnerAfe,Operator,ElectionId,County,State,Section,Township,Range,Datum,Latitude,Longitude,ProposedEstimatedSpudDate,ProposedFormation,ProposedNumberOfCsgStrings,ProposedStringOneDepth,ProposedStringOneDescription,ProposedStringTwoDepth,ProposedStringTwoDescription,ProposedStringThreeDepth,ProposedStringThreeDescription,ProposedStringFourDepth,ProposedStringFourDescription,ProposedPlanDays,ProposedAfeCost,ProposedIncludesConstruction,ProposedIncludesRigMove,ProposedIncludesProdCsgCmt,ProposedBatchDrilling,ProposedSpudderRig,ProposedTotalDepth,ProposedTvd,ProposedLateralLength,ProposedUsingRss,ProposedMudComments,ProposedOtherComments,PostDrillSpudDate,PostDrillFormation,PostDrillNumberOfCsgStrings,PostDrillStringOneDepth,PostDrillStringOneDescription,PostDrillStringTwoDepth,PostDrillStringTwoDescription,PostDrillStringThreeDepth,PostDrillStringThreeDescription,PostDrillStringFourDepth,PostDrillStringFourDescription,PostDrillDrillingDays,PostDrillFieldEstimate,PostDrillActualCost,PostDrillIncludesConstruction,PostDrillIncludesRigMove,PostDrillIncludesProdCsgCmt,PostDrillSidetrack,PostDrillBatchDrilling,PostDrillSpudderRig,PostDrillTotalDepth,PostDrillTvd,PostDrillLateralLength,PostDrillUsingRss,PostDrillMudComments,PostDrillOtherComments")] WellDetail wellDetail)
        {
            if (ModelState.IsValid)
            {
                db.WellDetails.Add(wellDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessUnitId = new SelectList(db.BusinessUnits, "Id", "Name", wellDetail.BusinessUnitId);
            ViewBag.ElectionId = new SelectList(db.Elections, "Id", "Name", wellDetail.ElectionId);
            return View(wellDetail);
        }

        // GET: WellDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WellDetail wellDetail = db.WellDetails.Find(id);
            if (wellDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessUnitId = new SelectList(db.BusinessUnits, "Id", "Name", wellDetail.BusinessUnitId);
            ViewBag.ElectionId = new SelectList(db.Elections, "Id", "Name", wellDetail.ElectionId);
            return View(wellDetail);
        }

        // POST: WellDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Commenter,CommentDate,Name,ApiNumber,Duwi,BusinessUnitId,FieldName,PartnerAfe,Operator,ElectionId,County,State,Section,Township,Range,Datum,Latitude,Longitude,ProposedEstimatedSpudDate,ProposedFormation,ProposedNumberOfCsgStrings,ProposedStringOneDepth,ProposedStringOneDescription,ProposedStringTwoDepth,ProposedStringTwoDescription,ProposedStringThreeDepth,ProposedStringThreeDescription,ProposedStringFourDepth,ProposedStringFourDescription,ProposedPlanDays,ProposedAfeCost,ProposedIncludesConstruction,ProposedIncludesRigMove,ProposedIncludesProdCsgCmt,ProposedBatchDrilling,ProposedSpudderRig,ProposedTotalDepth,ProposedTvd,ProposedLateralLength,ProposedUsingRss,ProposedMudComments,ProposedOtherComments,PostDrillSpudDate,PostDrillFormation,PostDrillNumberOfCsgStrings,PostDrillStringOneDepth,PostDrillStringOneDescription,PostDrillStringTwoDepth,PostDrillStringTwoDescription,PostDrillStringThreeDepth,PostDrillStringThreeDescription,PostDrillStringFourDepth,PostDrillStringFourDescription,PostDrillDrillingDays,PostDrillFieldEstimate,PostDrillActualCost,PostDrillIncludesConstruction,PostDrillIncludesRigMove,PostDrillIncludesProdCsgCmt,PostDrillSidetrack,PostDrillBatchDrilling,PostDrillSpudderRig,PostDrillTotalDepth,PostDrillTvd,PostDrillLateralLength,PostDrillUsingRss,PostDrillMudComments,PostDrillOtherComments")] WellDetail wellDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wellDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessUnitId = new SelectList(db.BusinessUnits, "Id", "Name", wellDetail.BusinessUnitId);
            ViewBag.ElectionId = new SelectList(db.Elections, "Id", "Name", wellDetail.ElectionId);
            return View(wellDetail);
        }

        // GET: WellDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WellDetail wellDetail = db.WellDetails.Find(id);
            if (wellDetail == null)
            {
                return HttpNotFound();
            }
            return View(wellDetail);
        }

        // POST: WellDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WellDetail wellDetail = db.WellDetails.Find(id);
            db.WellDetails.Remove(wellDetail);
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
