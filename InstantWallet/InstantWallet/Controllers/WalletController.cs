using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstantWallet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NBitcoin;

namespace InstantWallet.Controllers
{
    public class WalletController : Controller
    {
        // GET: WalletController
        public ActionResult Index()
        {

            //IQueryable<Wallet> wallet;
            var wallet = new Wallet();

            wallet.generateKey();

            return View(wallet);
        }

        // GET: WalletController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WalletController/Create
        public ActionResult Create()
        {
            return View(new Wallet());
        }

        // POST: WalletController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Wallet wallet)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    //var freshWallet = new Wallet();

                    return RedirectToAction(nameof(Index));
                }
            }

            catch
            {
                return View(wallet);
            }

            return View(wallet);

        }
                

        // GET: WalletController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalletController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalletController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalletController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
