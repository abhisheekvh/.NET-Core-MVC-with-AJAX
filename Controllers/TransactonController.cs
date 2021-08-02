using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JqueryAjax.Models;
using JqueryAjax.vscode;

namespace JqueryAjax.Controllers
{
    public class TransactonController : Controller
    {
        private readonly TransactionDBContext _context;

        public TransactonController(TransactionDBContext context)
        {
            _context = context;
        }

        // GET: Transacton
        public async Task<IActionResult> Index()
        {
            return View(await _context.transaction.ToListAsync());
        }

        // GET: Transacton/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionModel = await _context.transaction
                .FirstOrDefaultAsync(m => m.transactionId == id);
            if (transactionModel == null)
            {
                return NotFound();
            }

            return View(transactionModel);
        }

        // GET: Transacton/AddOrEdit
        // GET: Transacton/AddOrEdit/5
        public async Task<IActionResult> AddOrEdit(int id=0)
        {
            if(id==0)
            {
                return View(new TransactionModel());
            }
            else
            {
                    var transactionModel = await _context.transaction.FindAsync(id);
                    if (transactionModel == null)
                    {
                        return NotFound();
                    }
                    return View(transactionModel);
            }
        }

        // POST: Transacton/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("transactionId,accountNumber,BenificiaryName,bankName,swiftCode,amount")] TransactionModel transactionModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transactionModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transactionModel);
        }

      

        // POST: Transacton/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("transactionId,accountNumber,BenificiaryName,bankName,swiftCode,amount,Date")] TransactionModel transactionModel)
        {

            if (ModelState.IsValid)
            {
                if(id==0)
                {
                    transactionModel.Date=DateTime.Now;
                    _context.Add(transactionModel);
                await _context.SaveChangesAsync();

                }
                else
                {
                try
                {
                    _context.Update(transactionModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionModelExists(transactionModel.transactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                }

              
                return Json(new {isValid=true,html=Helper.RenderRazorViewToString(this,"_ViewAll",_context.transaction.ToList())});
            }
             return Json(new {isValid=false,html=Helper.RenderRazorViewToString(this,"AddOrEdit",transactionModel)});
        }

       

        // POST: Transacton/Delete/5
        [HttpPost, ActionName("Delete")]
      
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionModel = await _context.transaction.FindAsync(id);
            _context.transaction.Remove(transactionModel);
            await _context.SaveChangesAsync();
             return Json(new {html=Helper.RenderRazorViewToString(this,"_ViewAll",_context.transaction.ToList())});
        }

        private bool TransactionModelExists(int id)
        {
            return _context.transaction.Any(e => e.transactionId == id);
        }
    }
}
