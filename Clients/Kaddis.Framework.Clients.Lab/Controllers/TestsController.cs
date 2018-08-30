using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kaddis.Framework.Data.KaddisFrameworkModel.Model;
using System.Net.Http;
using Kaddis.Framework.Common.Entities;
using Newtonsoft.Json;

namespace Kaddis.Framework.Clients.Lab.Controllers
{
    public class TestsController : Controller
    {
        private KaddisFrameworkContext db = new KaddisFrameworkContext();

        private readonly HttpClient client = new HttpClient();

        // GET: Tests
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:65476/api/test/getall");
            response.EnsureSuccessStatusCode();

            var contents = await response.Content.ReadAsStringAsync();
            List<TestDto> list = JsonConvert.DeserializeObject<List<TestDto>>(contents);

            return View(list);

            //return View(await db.Tests.ToListAsync());
        }

        // GET: Tests/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Test test = await db.Tests.FindAsync(id);

            HttpResponseMessage response = await client.GetAsync(string.Format("http://localhost:65476/api/test/getbyid/{0}", id));
            response.EnsureSuccessStatusCode();

            var contents = await response.Content.ReadAsStringAsync();
            TestDto testDto = JsonConvert.DeserializeObject<TestDto>(contents);

            if (testDto == null)
            {
                return HttpNotFound();
            }
            return View(testDto);
        }

        // GET: Tests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] Test test)
        {
            if (ModelState.IsValid)
            {
                db.Tests.Add(test);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(test);
        }

        // GET: Tests/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = await db.Tests.FindAsync(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: Tests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] Test test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(test);
        }

        // GET: Tests/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = await db.Tests.FindAsync(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Test test = await db.Tests.FindAsync(id);
            db.Tests.Remove(test);
            await db.SaveChangesAsync();
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
