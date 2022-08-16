using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Oppimispäiväkirja_versio1.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;



namespace Oppimispäiväkirja_versio1.Controllers
{
    public class NotesController : Controller
    {
        private readonly Oppimispäiväkirja_versio1Context _context;

        public NotesController(Oppimispäiväkirja_versio1Context context)
        {
            _context = context;
        }

        // GET: Notes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Note.ToListAsync());
        }

        // GET: Notes/Details/5
        public async Task<IActionResult> Details(int? NoteID)
        {
            if (NoteID == null)
            {
                return NotFound();
            }

            var note = await _context.Note
                .FirstOrDefaultAsync(m => m.NoteId == NoteID);
            if (note == null)
            {
                return NotFound();
            }

            return View(note);
        }

        // GET: Notes/Create
        public async Task<IActionResult> Create()
        {
            ViewModels uusiModels = new ViewModels();
            uusiModels.Topics = await _context.Topic.ToListAsync();
            IEnumerable<SelectListItem> titletListaan = _context.Topic.Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
               Text = x.Title

            });
           ViewBag.Topikit = titletListaan;
           return View(uusiModels);
        }

        //GET: Notes/Create
        //public async Task<IActionResult> HaeValitutOtsikot(IEnumerable<Topic> titleTopics)
        //{
        //    ViewModels uusiModels = new ViewModels();
        //      uusiModels.Topics = await _context.Topic.ToListAsync();
        //      IEnumerable<SelectListItem> titletListaan = _context.Topic.Select(x => new SelectListItem(){
        //          Value = x.ID.ToString(),
        //          Text = x.Title

        //      });
        //}

        //var model = new VariousWayBindingDropDownListInMVC5.Models.MySkills();
        //    using(CSharpCornerEntities cshparpEntity = new CSharpCornerEntities()) {
        //    var dbData = cshparpEntity.MySkills.ToList();
        //    model.Skills = GetSelectListItems(dbData);
        //}
        //private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<MySkill> elements)
        //{
        //    var selectList = new List<SelectListItem>();
        //    foreach (var element in elements)
        //    {
        //        selectList.Add(new SelectListItem
        //        {
        //            Value = element.ID.ToString(),
        //            Text = element.Name
        //        });
        //    }
        //    return selectList;
        //}

// POST: Notes/Create
// To protect from overposting attacks, enable the specific properties you want to bind to, for 
// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID", "NoteText")] ViewModels note ) //nyt tää ei enää toimi, eli tämä pitää korjata, jotta se sitten tallentuu ihan oikein sinne databaseen jne. 
        {
            if (ModelState.IsValid)
            {
                _context.Add(note);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(note);
        }

        //public List<ProductDTO> GetProducts(int categoryID)
        //{
        //    return (from p in db.Products
        //        where p.CategoryID == categoryID
        //        select new ProductDTO { Name = p.Name }).ToList();
        //}

        // GET: Notes/Edit/5
        public async Task<IActionResult> Edit(int? NoteID)
        {
            if (NoteID == null)
            {
                return NotFound();
            }

            var note = await _context.Note.FindAsync(NoteID);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }

        // POST: Notes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int NoteID, [Bind("Id,NoteText,Topic")] ViewModels note)
        {
            if (NoteID != NoteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(note);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoteExists(NoteID))
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
            return View(note);
        }

        // GET: Notes/Delete/5
        public async Task<IActionResult> Delete(int? NoteId)
        {
            if (NoteId == null)
            {
                return NotFound();
            }

            var note = await _context.Note
                .FirstOrDefaultAsync(m => m.NoteId == NoteId);
            if (note == null)
            {
                return NotFound();
            }

            return View(note);
        }

        // POST: Notes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int NoteId)
        {
            var note = await _context.Note.FindAsync(NoteId);
            _context.Note.Remove(note);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoteExists(int NoteId)
        {
            return _context.Note.Any(e => e.NoteId == NoteId);
        }
        public async Task<IActionResult> ViewJoku()
        {
          
           return View(await _context.Topic.ToListAsync());
        }


    }
}
