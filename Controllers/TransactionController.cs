﻿using AccountTransactionAPP.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
//using System.Transactions;
using AccountTransactionAPP.Models;
using System.Diagnostics;

public class TransactionsController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    // GET: Transactions
    public ActionResult Index()
    {
        //var transactions = db.Transac.Include(t => t.NaturalPerson).Include(t => t.Company).ToList();        
        var transactions = db.Transac;

        return View(transactions);
    }

    // GET: Transactions/Create
    public ActionResult Create()
    {
        ViewBag.NaturalPersonId = new SelectList(db.NaturalPersons, "Id", "FullName");
        ViewBag.CompanyId = new SelectList(db.Companies, "Id", "CompanyName");
        return View();
    }

    // POST: Transactions/Create
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Create([Bind(include: "Id,TransactionDate,Amount,TransactionType,NaturalPersonId,CompanyId")] Transaction tr)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        db.Transac.Add(tr);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    ViewBag.NaturalPersonId = new SelectList(db.NaturalPersons, "Id", "FullName", tr.NaturalPersonId);
    //    ViewBag.CompanyId = new SelectList(db.Companies, "Id", "CompanyName", tr.CompanyId);
    //    return View(tr);
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}