using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Servicios.Controllers
{
    public class ClientesController : ApiController
    {
        bdpruebaEntities context = new bdpruebaEntities();

        //GET: Clientes
        [HttpGet]
        public List<clientes> Index()
        {
            try
            {
                return context.clientes.ToList();
            }
            catch
            {
                return new List<clientes>();
            }
        }

        // GET: Clientes/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Clientes/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Clientes/Create
        [HttpPost]
        public bool Create([FromBody] clientes cliente)
        {
            try
            {
                context.clientes.Add(cliente);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // GET: Clientes/Edit/5
        [HttpPut]
        public bool Edit(string id, [FromBody] clientes cliente)
        {
            try
            {
                var c = context.clientes.Where(cli => cli.identificacion == id).FirstOrDefault();
                if (c != null)
                {
                    c.nombre = cliente.nombre;
                    c.correo = cliente.correo;
                    c.estado = cliente.estado;
                    c.saldo = cliente.saldo;
                    context.SaveChanges();

                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        // POST: Clientes/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Clientes/Delete/5
        [HttpDelete]
        public bool Delete(string id)
        {
            try
            {
                var cliente = context.clientes.Where(c => c.identificacion == id).FirstOrDefault();
                if (cliente != null)
                {
                    context.clientes.Remove(cliente);
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;

            }
            catch
            {
                return false;
            }
        }

        // POST: Clientes/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
