using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CadastroEstabelecimento.Models;
using CadastroEstabelecimento.Models.Repository;

namespace CadastroEstabelecimento.Controllers
{
    public class Estabelecimentoes1Controller : Controller
    {
        private Contexto db = new Contexto();

        // GET: Estabelecimentoes1
        public ActionResult Index()
        {
            return View(db.Estabelecimentos.ToList());
        }

        // GET: Estabelecimentoes1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimentos.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimentoes1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estabelecimentoes1/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEstabelecimento,RazaoSocial,NomeFantasia,Cnpj,Email,Endereco,Cidade,Estado,Telefone,DataInclusao,Categoria,Status,Agencia,Conta")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Estabelecimentos.Add(estabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estabelecimento);
        }

        // GET: Estabelecimentoes1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimentos.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // POST: Estabelecimentoes1/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEstabelecimento,RazaoSocial,NomeFantasia,Cnpj,Email,Endereco,Cidade,Estado,Telefone,DataInclusao,Categoria,Status,Agencia,Conta")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimentoes1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimentos.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(estabelecimento);
        }

        // POST: Estabelecimentoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimentos.Find(id);
            db.Estabelecimentos.Remove(estabelecimento);
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
