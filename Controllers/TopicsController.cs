using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Oppimispäiväkirja_versio1.Models;

namespace Oppimispäiväkirja_versio1.Controllers
{
    public class TopicsController : Controller
    {
        private readonly Oppimispäiväkirja_versio1Context _context;

        public TopicsController(Oppimispäiväkirja_versio1Context context)
        {
            _context = context;
        }

        // GET: Topics
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Topic.ToListAsync());
        }

        public async Task<IActionResult> Index(string hakusana)
        {
            var topics = await _context.Topic.ToListAsync();
            if (!String.IsNullOrEmpty(hakusana))
            {
                topics = topics.Where(topic => topic.Title.Contains(hakusana)).ToList();
            }

            return View(topics);
        }

        //public ActionResult IndexSearch(string searchString)
        //{
        //    var title = from m in _context.Topic
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        title = title.Where(s => s.Title.Contains(searchString));
        //    }

        //    return View(title);
        //}
        

        // GET: Topics/Details/5
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var topic = await _context.Topic
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (topic == null)
            {
                return NotFound();
            }


            return View(topic);
        }


        // GET: Topics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Topics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Description,EstimatedTimeToMaster,TimeSpent,Source,StartLearningDate,InProgress,CompletionDate")] Topic topic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(topic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }

        // GET: Topics/Edit/5
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var topic = await _context.Topic.FindAsync(Id);
            if (topic == null)
            {
                return NotFound();
            }
            return View(topic);
        }

        public async Task<IActionResult> FindTitle(string title)
        {
            if (title == null)
            {
                return NotFound();
            }
            var topic = await _context.Topic.FindAsync(title);
            if (topic == null)
            {
                return NotFound();
            }
            return View(title);
        }

        // POST: Topics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,Title,Description,EstimatedTimeToMaster,TimeSpent,Source,StartLearningDate,InProgress,CompletionDate")] Topic topic)
        {
            if (Id != topic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicExists(topic.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }

        // GET: Topics/Delete/5
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var topic = await _context.Topic
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        // POST: Topics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var topic = await _context.Topic.FindAsync(Id);
            _context.Topic.Remove(topic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicExists(int Id)
        {
            return _context.Topic.Any(e => e.Id == Id);
        }
    }
}
