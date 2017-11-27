using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SISv3.Models;

namespace SISv3.Controllers
{
    public class AttendancePerDayController : Controller
    {
        private SISv3dBEntities db = new SISv3dBEntities();

        // GET: AttendancePerDay
        public ActionResult Index()
        {
            var attendancePerDay = db.AttendancePerDay.Include(a => a.Student).Include(a => a.TimetablePerDay);
            return View(attendancePerDay.ToList());
        }

        // GET: AttendancePerDay/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendancePerDay attendancePerDay = db.AttendancePerDay.Find(id);
            if (attendancePerDay == null)
            {
                return HttpNotFound();
            }
            return View(attendancePerDay);
        }

        // GET: AttendancePerDay/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name");
            ViewBag.TimetablePerDayId = new SelectList(db.TimetablePerDay, "Id", "MorningRemark");
            return View();
        }

        // POST: AttendancePerDay/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TimetablePerDayId,StudentId,M_IN,M_OUT,M_Status,A_IN,A_OUT,A_Status,Total_Marks,Total_Status,Remarks,CreatedDate,CreatedBy,UpdatedDate,UpdateBy,Status")] AttendancePerDay attendancePerDay)
        {
            if (ModelState.IsValid)
            {
                db.AttendancePerDay.Add(attendancePerDay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name", attendancePerDay.StudentId);
            ViewBag.TimetablePerDayId = new SelectList(db.TimetablePerDay, "Id", "MorningRemark", attendancePerDay.TimetablePerDayId);
            return View(attendancePerDay);
        }

        // GET: AttendancePerDay/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendancePerDay attendancePerDay = db.AttendancePerDay.Find(id);
            if (attendancePerDay == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name", attendancePerDay.StudentId);
            ViewBag.TimetablePerDayId = new SelectList(db.TimetablePerDay, "Id", "MorningRemark", attendancePerDay.TimetablePerDayId);
            return View(attendancePerDay);
        }

        // POST: AttendancePerDay/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TimetablePerDayId,StudentId,M_IN,M_OUT,M_Status,A_IN,A_OUT,A_Status,Total_Marks,Total_Status,Remarks,CreatedDate,CreatedBy,UpdatedDate,UpdateBy,Status")] AttendancePerDay attendancePerDay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendancePerDay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Student, "Id", "Name", attendancePerDay.StudentId);
            ViewBag.TimetablePerDayId = new SelectList(db.TimetablePerDay, "Id", "MorningRemark", attendancePerDay.TimetablePerDayId);
            return View(attendancePerDay);
        }

        // GET: AttendancePerDay/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendancePerDay attendancePerDay = db.AttendancePerDay.Find(id);
            if (attendancePerDay == null)
            {
                return HttpNotFound();
            }
            return View(attendancePerDay);
        }

        // POST: AttendancePerDay/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendancePerDay attendancePerDay = db.AttendancePerDay.Find(id);
            db.AttendancePerDay.Remove(attendancePerDay);
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
